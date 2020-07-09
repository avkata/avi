using System;

namespace ClassBox
{
    public  class Box
    {
        private double length;
        private double width;
        private double hight;

        public Box(double length, double width, double hight)
        {
            this.Length = length;
            this.Hight = hight;
            this.Width = width;
        }
        private const double SIDE_MAIN_VALUE = 0;
        private const string INVALID_MESSEGE = "{0} cannot be zero or negative.";

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.ValidateSideName(value, nameof(this.Length));
                this.length = value;

            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.ValidateSideName(value, nameof(this.Width));

                this.width = value;
            }
        }
        public double Hight
        {
            get
            {
                return this.hight;
            }
            private set
            {
                this.ValidateSideName(value, nameof(this.Hight));
                this.hight = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            double surfaceArea = (2 * this.length * this.width) + (2 * this.length * this.hight) + (2 * this.width * this.hight);
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double LateralSurfaceArea = (2 * this.length * this.hight) + (2 * this.width * this.hight);
            return LateralSurfaceArea;
        }
        public double Volume()
        {
            double volume = this.length * this.hight * this.width;
            return volume;
        }

        private void ValidateSideName(double value, string sideName)
        {
            if (value <= SIDE_MAIN_VALUE)
            {
                throw new ArgumentException(String.Format(INVALID_MESSEGE, sideName));
            }
        }
    }
}