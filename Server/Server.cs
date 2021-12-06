using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Server
{
    /// <summary>
    /// Teodor-Cristian Lutoiu
    /// Version: 2.4 06.12.2021
    /// 
    /// This class is the Server, it actions the backbone of the program
    /// It is loads, unloads, shows, rotates and flips images
    /// </summary>
    public class Server : IServer
    {
        // CREATE a list to store the images received from GUI
        private List<Image> _loadedImages = new List<Image>();
        // CREATE a list to hold the indeUid for the '_loadedImages' list in a string format
        private List<string> _imageNumber = new List<string>();

        // CREATE a variable of type integer, instantiate it to 0
        private int j = 0;

        // CREATE a variable of type integer, instantiate it to 0. It is the integer value of the pUid parameter
        private int Uid;

        /// <summary>
        /// Called from GUI, it's role is to load an image from a path
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns>'_imageNumber' which is the number that holds the last loaded image,
        ///             in a string</returns>
        public IList<string> Load(IList<string> imagePath)
        {

            if (imagePath.Count == imagePath.Distinct().Count())
            {
                // LOAD all images passed from GUI
                Image imag = Image.FromFile(imagePath[j]);
                // ADD the image in the _loadedImages list
                _loadedImages.Add(imag);
                // ADD the counter of the image loaded
                _imageNumber.Add(Convert.ToString(j));
                // INCREMENT the counter by 1
                j++;
            }
            else
            {
                throw new Exception ("Duplicate Loaded");
            }

            // IF the loadedImages.Count is higher then 5, initialise UnLoad process
            if (_loadedImages.Count >= 5)
            {
                imagePath.Clear();
                j = 0;
            }
            // Return a string, containing the indeUid of the last loaded image
            return _imageNumber;


        }

        /// <summary>
        /// UNLOAD the images in memory if they are more than 5
        /// </summary>
        public void Unload()
        {
            if (_loadedImages.Count >= 5)
            {

                _loadedImages.Clear();
                _imageNumber.Clear();

            }
        }

        /// <summary>
        /// Called from GUI, gives the UID of the requested image, returns the image
        /// </summary>
        /// <param name="pUid"></param>
        /// <param name="pFrameWidth"></param>
        /// <param name="pFrameHeight"></param>
        /// <returns>The image requested</returns>
        public Image GetImage(string pUid, int pFrameWidth, int pFrameHeight)
        {
            // TRANSFORM the pUid string to an integer
            Uid = Int32.Parse(pUid);

            // return the image asked by GUI
            return _loadedImages[Uid];
        }

        /// <summary>
        /// Rotate the received image by its pUid
        /// </summary>
        /// <param name="pUid"></param>
        /// <returns>RETURN the manipulated image</returns>
        public Image RotateImage(string pUid)
        {
            // TRANSFORM the pUid string to an integer
            Uid = Int32.Parse(pUid);

            // ROTATE the received image
            _loadedImages[Uid].RotateFlip(RotateFlipType.Rotate90FlipNone);

            // RETURN the manipulated image
            return _loadedImages[Uid];
        }

        /// <summary>
        /// Flips horizontally the received image by its pUid
        /// </summary>
        /// <param name="pUid"></param>
        /// <returns>RETURN the manipulated image</returns>
        public Image HorizontalFlipImage(string pUid)
        {
            // TRANSFORM the pUid string to an integer
            Uid = Int32.Parse(pUid);

            // HORIZONTAL FLIP the received image
            _loadedImages[Uid].RotateFlip(RotateFlipType.RotateNoneFlipX);

            // RETURN the manipulated image
            return _loadedImages[Uid];
        }

        /// <summary>
        /// Flip vertically the received image by its pUid
        /// </summary>
        /// <param name="pUid"></param>
        /// <returns>RETURN the manipulated image</returns>
        public Image VerticalFlipImage(string pUid)
        {
            // TRANSFORM the pUid string to an integer
            Uid = Int32.Parse(pUid);

            // VERTICAL FLIP the received image
            _loadedImages[Uid].RotateFlip(RotateFlipType.RotateNoneFlipY);

            // RETURN the manipulated image
            return _loadedImages[Uid];
        }
    }
}
