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

/// <summary>
/// Teodor-Cristian Lutoiu
/// Version: 2.4 06.12.2021
/// </summary>
namespace ImageManipulator
{
    /// <summary>
    /// This class is the GUI/Client, it actions all the visual part of the program
    /// </summary>
    public partial class GUI : Form
    {
        //1. Populate list in GUI with image file paths
        //2. Send that list to server.load()
        //3. Servers loads the images from the paths in that list

        // REFERENCE to the Server class through IServer interface, call it server
        private IServer _server;

        // CREATE a list of type string to store the image paths, call it _imagePath
        private IList<string> _imagePath = new List<string>();

        // CREATE a list of type PictureBox to store the _pictureBoxes, call it _pictureBoxes
        private List<PictureBox> _pictureBoxes = new List<PictureBox>();

        // CREATE a variable of type integer that counts how many images were loaded, call it _counter
        private int _counter;

        // CREATE a variable of type integer that keeps in mind which pictureBox was clicked last,
        // call it _selectedPictureBox
        private int _selectedPictureBox;

        // CREATE a variable of type Image to store the modified images, call it _manipulatedimage
        private Image _manipulatedImage;

        // CREATE a variable of type static int to store the Width of the loaded image
        private static int _imageWidth = 128;

        // CREATE a variable of type static int to store the Height of the loaded image
        private static int _imageHeight = 128;

        /// <summary>
        /// Constructor of class GUI
        /// </summary>
        public GUI()
        {
            InitializeComponent();

            // INITIALISE the server
            _server = new Server.Server();

            // INITIALISE the _counter
            _counter = 0;

            // INITIALISE the _pictureBoxes list, add all the pictureBoxes to the list
            _pictureBoxes.Add(pictureBox1);
            _pictureBoxes.Add(pictureBox2);
            _pictureBoxes.Add(pictureBox3);
            _pictureBoxes.Add(pictureBox4);
            _pictureBoxes.Add(pictureBox5);
           
        }

        /// <summary>
        /// This method actions the AddImage button, it opens the OpenFileDialog
        /// and loads the selected image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddImage_Click(Object sender, EventArgs e)
        {
            // If there are more than 5 images loaded, unload the first one
            // Always keep the loaded images under 5
            if (_counter >= 5)
            {
                // Unload the loaded images
                _server.Unload();

                // Reset the counter to 0
                _counter = 0;
            }

            // Through OpenFileDialog window, select an image to be loaded and save it's path
            OpenFileDialog ofd = new OpenFileDialog();

            // Only allow .png files to be loaded
            ofd.Filter = "PNG files *.png|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Add the path of the loaded image to _imagePath
                _imagePath.Add(ofd.FileName);

                // Send the list with the paths to server.Load() through IServer
                _server.Load(_imagePath);
                
                // Show the image on screen by sending it to server.GetImage() through IServer
                _pictureBoxes[_counter].Image = _server.GetImage("" + _counter, _imageWidth, _imageHeight);
                
                // INCREASE the counter by 1
                _counter++;  
            }    
        }

        /*
         * In the pictureBoxes_Click region, we set the _selectedPictureBox integer to a value from 0 to 4, 
         * according to the last pictureBox click in order to know what image we are working with
         */
        #region pictureBoxes_Click

        /// <summary>
        /// If pictureBox1 is clicked, set the value to _selectedPictureBox to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = 0;
        }

        /// <summary>
        /// If pictureBox2 is clicked, set the value to _selectedPictureBox to 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = 1;
        }

        /// <summary>
        /// If pictureBox3 is clicked, set the value to _selectedPictureBox to 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = 2;
        }

        /// <summary>
        /// If pictureBox4 is clicked, set the value to _selectedPictureBox to 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = 3;
        }

        /// <summary>
        /// If pictureBox5 is clicked, set the value to _selectedPictureBox to 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _selectedPictureBox = 4;
        }
        #endregion

        #region Rotate and Flip implementation

        /// <summary>
        /// This method facilitates the rotation of the selected image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateImage_Click(Object sender, EventArgs e)
        {
            // Theory:
            // Select a pictureBox
            // Rotate the selected image in pictureBox
            _manipulatedImage = _server.RotateImage("" + _selectedPictureBox);

            if (_selectedPictureBox == 0) pictureBox1.Image = _manipulatedImage;
            if (_selectedPictureBox == 1) pictureBox2.Image = _manipulatedImage;
            if (_selectedPictureBox == 2) pictureBox3.Image = _manipulatedImage;
            if (_selectedPictureBox == 3) pictureBox4.Image = _manipulatedImage;
            if (_selectedPictureBox == 4) pictureBox5.Image = _manipulatedImage;
        }

        /// <summary>
        /// This method facilitates the horizontal flipping of the selected image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipHorizontal_Click(Object sender, EventArgs e)
        {
            // Select a pictureBox
            // Horizontal Flip the selected image in pictureBox
            _manipulatedImage = _server.HorizontalFlipImage("" + _selectedPictureBox);

            if (_selectedPictureBox == 0) pictureBox1.Image = _manipulatedImage;
            if (_selectedPictureBox == 1) pictureBox2.Image = _manipulatedImage;
            if (_selectedPictureBox == 2) pictureBox3.Image = _manipulatedImage;
            if (_selectedPictureBox == 3) pictureBox4.Image = _manipulatedImage;
            if (_selectedPictureBox == 4) pictureBox5.Image = _manipulatedImage;
        }

        /// <summary>
        /// This method facilitates the vertical flipping of the selected image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipVertical_Click(Object sender, EventArgs e)
        {
            // Select a pictureBox
            // Vertical Flip the selected image in pictureBox
            _manipulatedImage = _server.VerticalFlipImage("" + _selectedPictureBox);

            if (_selectedPictureBox == 0) pictureBox1.Image = _manipulatedImage;
            if (_selectedPictureBox == 1) pictureBox2.Image = _manipulatedImage;
            if (_selectedPictureBox == 2) pictureBox3.Image = _manipulatedImage;
            if (_selectedPictureBox == 3) pictureBox4.Image = _manipulatedImage;
            if (_selectedPictureBox == 4) pictureBox5.Image = _manipulatedImage;
        }
        #endregion
    }
}
