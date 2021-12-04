using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;

namespace ImageManipulator
{
    public partial class GUI : Form
    {

        IServer server;
        //1. Populate list in GUI with image file paths
        //2. Send that list to server.load()
        //3. Servers loads the images from the paths in that list

        // Create a list to store the image paths
        IList<string> imagePath = new List<string>();

        public GUI()
        {
            InitializeComponent();
            server = new Server.Server();
        }

        // Through OpenFileDialog window, select an image to be loaded and save it's path
        private void AddImage_Click(Object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG files *.png|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath.Add(ofd.FileName);
                // Send the list to server.load() through IServer
                server.Load(imagePath);
                pictureBox1.Image = server.GetImage("0", 128, 128);
            }    
        }
    }
}
