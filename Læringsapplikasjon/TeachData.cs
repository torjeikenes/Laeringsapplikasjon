using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Læringsapplikasjon
{
    class TeachData
    {

        #region Variabler
        string t; // Title
        string i; // Info
        string p; // Picture file path
        string s; // Sound file path
        bool iP;  // true if only Picturepath

        #endregion


        /// <summary>
        /// Default constructor for TeachData 
        /// </summary>
        public TeachData() { }

        /// <summary>
        /// Creates TeachData with Title, Info, Picturepath and Soundpath
        /// </summary>
        /// <param name="Title">Teach title</param>
        /// <param name="Info">Info text</param>
        /// <param name="Picture">Path for picture file</param>
        /// <param name="Sound">Path for sound file</param>
        public TeachData(string Title, string Info, string Picture, string Sound)
        {

        }
        /// <summary>
        /// Creates TeachData with Title, Info, Sound
        /// </summary>
        /// <param name="Title">Teach title</param>
        /// <param name="Info">Info text</param>
        /// <param name="File">Filepath for picture or sound</param>
        /// <param name="isPic">If a picturefile is specified, this MUST be true</param>
        public TeachData(string Title, string Info, string File, bool isPic)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Title">Teach title</param>
        /// <param name="Info">Info text</param>
        public TeachData(string Title, string Info)
        {


        }
    }
}
