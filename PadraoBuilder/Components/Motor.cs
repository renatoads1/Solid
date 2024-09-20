using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder.Components
{
    class Motor
    {
        private int _forca;
        public int Forca {
            get => _forca;
            set => _forca = value;
        }

        public Motor(int forca)
        {
            _forca = forca;
            
        }
    }
}
