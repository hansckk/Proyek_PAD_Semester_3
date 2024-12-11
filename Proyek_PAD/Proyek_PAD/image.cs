using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyek_PAD
{
    class image
    {
        private string name;
        private string id;
        private Image img;

        public image(string name, string id, Image img)
        {
            this.name = name;
            this.id = id;
            this.img = img;
        }
    }
}
