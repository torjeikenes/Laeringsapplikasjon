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

        string title;   // Title
        string info;    // Info
        string photo;   // Picture file path
        string audio;   // Sound file path
        bool isPhoto;   // true if only Picturepath

        #endregion

        #region Konstruktør

        /// <summary>
        /// Default constructor for TeachData 
        /// </summary>
        public TeachData() { }

        /// <summary>
        /// Creates TeachData with Title, Info, Picturepath and Soundpath
        /// </summary>
        /// <param name="t">Teach title</param>
        /// <param name="i">Info text</param>
        /// <param name="p">Path for picture file</param>
        /// <param name="au">Path for sound file</param>
        public TeachData(string t, string i, string p, string au)
        {
            title = t;
            info = i;
            photo = p;
            audio = au;

        }
        /// <summary>
        /// Creates TeachData with Title, Info, Sound
        /// </summary>
        /// <param name="t">Teach title</param>
        /// <param name="i">Info text</param>
        /// <param name="f">Filepath for picture or sound</param>
        /// <param name="iP">If a picturefile is specified, this MUST be true</param>
        public TeachData(string t, string i, string f, bool iP)
        {
            title = t;
            info = i;
            if (iP)
                photo = f;
            else
                audio = f;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t">Teach title</param>
        /// <param name="i">Info text</param>
        public TeachData(string t, string i)
        {
            title = t;
            info = i;
        }
        #endregion

        #region set_get_metoder

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Info
        {
            get { return title; }
            set { title = value; }
        }
        public string Photo
        {
            get { return title; }
            set { title = value; }
        }
        public string Audio
        {
            get { return title; }
            set { title = value; }
        }
        public bool IsPhoto
        {
            get { return isPhoto; }
            set { isPhoto = value; }
        }

        #endregion
    }
}
