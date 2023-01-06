using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mayin_Tarlasi
{
    public class Mines
    {
        Point Mines_Location;
        bool full;
        bool Check;

        public Mines(Point Loca) // Bir konum girilecek ve mayınlar oluşturulacak
        {
            full = false;
            Mines_Location = Loca; 
        }

        public Point GetLocation
        {
            get { return Mines_Location; }
        }

        public bool IsThereMines
        {
            get
            {
                return full;
            }

            set
            {
                full = value;
            }
        }

        public bool Check_
        {
            get
            {
                return Check;
            }
            set
            {
                Check = value;
            }

        }



    }
}
