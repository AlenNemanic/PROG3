using System;

namespace grafika_2naloga
{
    public class DeznaKapljica: IEquatable<DeznaKapljica>
    {
        private int x;
        private int y;
        private bool naMestu = false; // Se ni potrebno več premakniti.

        public DeznaKapljica(int x, int y, bool naMestu)
        {
            this.X = x;
            this.Y = y;
            this.NaMestu = naMestu;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool NaMestu
        {
            get { return naMestu; }
            set { naMestu = value; }
        }

        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }
            DeznaKapljica otherAsKacaKomponenta = other as DeznaKapljica;
            if (otherAsKacaKomponenta == null)
            {
                return false;
            }
            else
            {
                return Equals(otherAsKacaKomponenta);
            }
        }
        public bool Equals(DeznaKapljica other)
        {
            if (other == null)
            {
                return false;
            }
            return ((X == other.X) && (Y == other.Y) && (NaMestu == other.NaMestu));
        }
    }
}