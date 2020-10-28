using System;

namespace learning_cs
{
    class Box
    {
        // Props members
        private int height;
        public int Height
        {
            get => height;

            set
            {
                if (value < 0) throw new Exception("No negative numbers allowed.");
                height = value;
            }

        }
        private int width;

        public void showInfo()
        {
            Console.Clear();
            Console.WriteLine("The box size is: {0}'' Height {1}'' Width.", Height, width);
            Console.ReadKey();
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getWidth()
        {
            return this.width;
        }
    }
}