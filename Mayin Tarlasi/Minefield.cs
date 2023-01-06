using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Mayin_Tarlasi
{
    public class Minefield
    {
        Size Minefiled_Size;
        List<Mines> mines;
        int NumberFullMines;
        Random rnd = new Random();

        public Minefield(Size size_Minefield, int numberMines)
        {
            mines = new List<Mines>();
            NumberFullMines = numberMines ;
            Minefiled_Size = size_Minefield;

            for(int i = 0; i<size_Minefield.Width; i= i +20)
            {
                for (int j=0; j<size_Minefield.Height; j= j+20)
                {
                    Mines m = new Mines(new Point(i, j));
                    AddMine(m);
                }
            }
            Fill_Mines();
        }

        public void AddMine(Mines m)
        {
            mines.Add(m);
        }

        private void Fill_Mines()
        {
            int Number = 0;
            while(Number < NumberFullMines)
            {
                int i = rnd.Next(0, mines.Count);
                Mines item = mines[i];

                if(item.IsThereMines == false)
                {
                    item.IsThereMines = true;
                    Number++;
                }
            }
        }

        public Size sphere
        {
            get
            {
                return Minefiled_Size;
            }
        }


        public Mines Mines_by_Location(Point Location)
        {
            foreach (Mines a in mines)
            {
                if(a.GetLocation == Location)
                {
                    return a;
                }
            }
            return null;
        }

        public List<Mines> GetAllMines
        {
            get
            {
                return mines;
            }
        }

        public int totalMines
        {
            get
            {
                return NumberFullMines;
            }
        }

        public int totatSphere
        {
            get
            {
                return (Minefiled_Size.Width * Minefiled_Size.Height) / 400;
            }
        }

    }
}
