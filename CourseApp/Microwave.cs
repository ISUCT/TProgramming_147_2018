using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Microwave : Appliances
    {
        private double voltage;

        public Microwave()
            : base()
        {
            Voltage = 800;
        }

        public Microwave(int volt)
            : base()
        {
            Voltage = volt;
                Vendorcode = 414;
                Age = 4;
        }

        public Microwave(int volt, int md, int ag)
            : base(md, ag)
        {
            Voltage = volt;
        }

        public double Voltage
        {
            get
            {
                return voltage;
            }

            set
            {
                if (value < 0)
                {
                    voltage = 0;
                }
                else
                {
                    voltage = value;
                }
            }
        }

        public override string Status()
        {
            return "\nМикроволновка включена";
        }

        public override string ToString()
        {
            return $"Напряжение в микроволновке: {Voltage} Вт, Артикул {Vendorcode}, Возраст микроволновки: {Age}. ";
        }

        public override string Art()
            {
                return $@"
                        .----------------.
                       /__________________\
                       ||\ ________ /|  _ |
                       || |:      :| |o(_)|
                       || |;-""""-;| |o(_)|
                       || |________| | __ |
                       ||/__________\|[__]| 
                       ------------------";
            }

        public override void GetInfo()
        {
            Console.WriteLine(Status());
            Console.WriteLine(ToString());
            Console.WriteLine(Art());
        }
    }
}