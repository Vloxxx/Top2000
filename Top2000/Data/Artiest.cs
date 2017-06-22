using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class Artiest
    {
        private int artiestid;
        private string naam;
        private string biografie;
        private OpenFileDialog foto;
        private string url;

        public int Artiestid
        {
            get
            {
                return artiestid;
            }

            set
            {
                artiestid = value;
            }
        }

        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
            }
        }

        public string Biografie
        {
            get
            {
                return biografie;
            }

            set
            {
                biografie = value;
            }
        }

        public OpenFileDialog Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public Artiest(int artiestid, string naam, string biografie, OpenFileDialog foto, string url)
        {
            this.Artiestid = artiestid;
            this.Naam = naam;
            this.Biografie = biografie;
            this.Foto = foto;
            this.Url = url;
        }
    }
}