using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server : IServer
    {
        // Create a list to store the images received from GUI
        List<Image> _loadedImages = new List<Image>();
        // Create a list to hold the index for the '_loadedImages' list in a string format
        public List<string> _imageNumber = new List<string>();

        /// <summary>
        /// Called from GUI, it's role is to load an image from a path,
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns>'_imageNumber' which is the number that holds the last loaded image,
        ///             in a string</returns>
        public IList<string> Load(IList<string> imagePath)
        {
            // Load all images passed from GUI
            foreach (String path in imagePath)
            {
                Image i = Image.FromFile(path);
                _loadedImages.Add(i);
                _imageNumber.Add(Convert.ToString(_loadedImages.Count));
            }

            // Return a string, containing the index of the last loaded image
            return _imageNumber;
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
            // Transform the pUid string to an integer
            int x = Int32.Parse(pUid);
            
            //pFrameHeight = _loadedImages[x].Height;
            //pFrameWidth = _loadedImages[x].Width;

            // return the image asked by GUI
            return _loadedImages[x];
        }

        Image IServer.RotateImage(string pUid)
        {
            throw new NotImplementedException();
        }

        Image IServer.HorizontalFlipImage(string pUid)
        {
            throw new NotImplementedException();
        }

        Image IServer.VerticalFlipImage(string pUid)
        {
            throw new NotImplementedException();
        }
    }
}
