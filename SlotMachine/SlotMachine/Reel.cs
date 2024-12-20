using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SlotMachine.Models
{
    public class Reel
    {
        private readonly PictureBox pictureBox;
        private string currentImagePath;
        private readonly Theme theme;
        private readonly Random random = new Random();

        public Reel(PictureBox pictureBox, Theme theme)
        {
            this.pictureBox = pictureBox;
            this.theme = theme;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.Font = theme.Font;
            this.pictureBox.ForeColor = theme.Color;
        }

        public Reel(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        // Update the image of the PictureBox with a random image from the theme
        private void UpdatePictureBoxImage()
        {
            currentImagePath = theme.Symbols[random.Next(theme.Symbols.Length)];
            if (File.Exists(currentImagePath))
            {
                pictureBox.Image = Image.FromFile(currentImagePath);
            }
            else
            {
                MessageBox.Show($"Image not found: {currentImagePath}");
            }
        }

        // Spin the reel by picking a random image
        public void Spin()
        {
            UpdatePictureBoxImage();
        }

        public string GetCurrentImage()
        {
            return currentImagePath;
        }
    }
}