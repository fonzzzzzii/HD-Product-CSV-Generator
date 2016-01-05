using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setup_open_file_dialog(openFileDialog1);
            setup_open_file_dialog(openFileDialog2);
            setup_save_file_dialog(saveFileDialog1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            postsText.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(postsText.Text == "")
            {
                MessageBox.Show("Select posts file.");
            }
            else if(metaText.Text == "")
            {
                MessageBox.Show("Select meta file.");
            }
            else
            {
                saveFileDialog1.ShowDialog();
                //try
                {
                    generate_posts(postsText.Text);
                    generate_meta(metaText.Text);

                    MessageBox.Show(saveFileDialog1.FileName + " successfully created.");
                }
                /*catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/
                
            }
        }

        private void setup_open_file_dialog(OpenFileDialog open_file_dialog)
        {
            open_file_dialog.Filter = "Comma Separated Values|*.csv|Text Files|*.txt|All Files|*.*";
            open_file_dialog.FileName = "";
            open_file_dialog.FilterIndex = 1;
            open_file_dialog.Multiselect = false;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            metaText.Text = openFileDialog2.FileName;
        }

        private void setup_save_file_dialog(SaveFileDialog save_file_dialog)
        {
            save_file_dialog.Filter = "Comma Separated Values|*.csv|Text Files|*.txt|All Files|*.*";
            save_file_dialog.FileName = "HD_Products";
            save_file_dialog.FilterIndex = 1;
        }

        private List<Post> generate_posts(String file_directory)
        {
            List<Post> posts = new List<Post>();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(file_directory);
            file.ReadLine();//Header
            while ((line = file.ReadLine()) != null)
            {
                posts.Add(new Post(line));
            }
            file.Close();
            return posts;
        }

        private List<Meta> generate_meta(String file_directory)
        {
            List<Meta> metas = new List<Meta>();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(file_directory);
            file.ReadLine();//Header
            while ((line = file.ReadLine()) != null)
            {
               // MessageBox.Show(line);
                metas.Add(new Meta(line));
            }
            file.Close();
            return metas;
        }
    }
}
