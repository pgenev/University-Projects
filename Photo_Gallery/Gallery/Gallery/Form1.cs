using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gallery
{
    public partial class Form1 : Form
    {
        Size defaultSize = new Size(643, 292);
        List<string> imageList;
        int imageCurrentPosition;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void loadAlbum_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                imageList = new List<string>();
                path.Text = folderBrowserDialog.SelectedPath;
                string imageFullPath;
                string imageExtension;
                foreach (string images in Directory.GetFiles(path.Text))
                {
                    imageFullPath = Path.GetFullPath(images);
                    imageExtension = Path.GetExtension(images);
                    if (imageExtension == ".jpg" || imageExtension == ".JPG" ||
                        imageExtension == ".gif" || imageExtension == ".bmp")
                    {
                        imageList.Add(imageFullPath);
                    }
                    else
                    {
                        continue;
                    }
                }
                pictureBox.ImageLocation = imageList[imageCurrentPosition];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox.Width += 20;
            pictureBox.Height += 20;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox.Height -= 20;
            pictureBox.Width -= 20;
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            if (imageList == null)
            {
                MessageBox.Show("No picture to rotate!");
                return;
            }
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox.Refresh();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
             if (imageList == null)
            {
                MessageBox.Show("No picture to rotate!");
                return;
            }
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageList == null)
            {
                MessageBox.Show("No pictures to showing!");
                return;
            }
            if (imageCurrentPosition < imageList.Count-1)
            {
                imageCurrentPosition += 1;
            }
            else if (imageCurrentPosition == imageList.Count - 1)
            {
                imageCurrentPosition = 0;
            }
            pictureBox.ImageLocation = imageList[imageCurrentPosition];
            pictureBox.Size = defaultSize; 
         }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (imageList == null)
            {
                MessageBox.Show("No pictureя to showing!");
                return;
            }
            if (imageCurrentPosition > 0)
            {
                imageCurrentPosition -= 1;
            }
            else if (imageCurrentPosition == 0)
            {
                imageCurrentPosition = imageList.Count - 1;
            }
            pictureBox.ImageLocation = imageList[imageCurrentPosition];
            pictureBox.Size = defaultSize; 
       }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
    }
}
