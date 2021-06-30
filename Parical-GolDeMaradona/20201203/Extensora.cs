using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201203
{
    public static class Extensora
    {
        public static string Extensor(this PictureBox pb)
        {
            return pb.Name.Substring(pb.Name.Length - 1);
        }

    }
}
