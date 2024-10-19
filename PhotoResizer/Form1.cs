using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoResizer
{
    public partial class Form1: Form
    {
        private Image originalImage; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the image
                originalImage = Image.FromFile(openFileDialog.FileName);
                pictureBox.Image = originalImage;
            }
        }

        // Button to resize and save the image
        private void btnSave_Click(object sender, EventArgs e) 
        {
            if (originalImage != null)
            {

                // User input for the size
                int width = int.Parse(txtWidth.Text);
                int height = int.Parse(txtHeight.Text);

                // Resize
                Image resizedImage = ResizeImage(originalImage, width, height);

                // Save 
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JPEG Image|*.jpg;*.jpeg;|PNG Image|*.png;",
                    Title = "Save Resized Image"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save to the location
                    resizedImage.Save(saveFileDialog.FileName);
                    MessageBox.Show("Image save successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please upload an image first.");
            }
        }

        // Function to resize image
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height); // Create blank bitmap
            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedBitmap;
        }
    }
}