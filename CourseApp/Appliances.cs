using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public abstract class Appliances
    {
        private int vendorcode;
        private int age;

        public Appliances()
        {
            Vendorcode = vendorcode;
            Age = age;
        }

        public Appliances(int md, int ag)
        {
            Vendorcode = md;
            Age = ag;
        }

        public int Vendorcode
        {
            get
            {
                return vendorcode;
            }

            set
            {
                if (value < 0)
                {
                    vendorcode = 0;
                }
                else
                {
                    vendorcode = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public abstract string Status();

        public abstract string Art();

        public abstract void GetInfo();
    }
}
