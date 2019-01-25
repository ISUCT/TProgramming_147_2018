using System;

namespace CourseApp
{
    public class Television : Appliances
    {
        private int channel;

        public Television()
            : base()
        {
            Channel = 151;
        }

        public Television(int ch)
            : base()
        {
            Channel = ch;
            if (ch < 0)
            {
                Console.WriteLine("Канал должен быть >= 0");
            }
            else
            {
                    Vendorcode = 49620;
                    Age = 7;
            }
        }

        public Television(int ch, int artcl, int ag)
            : base(artcl, ag)
        {
            Channel = ch;
        }

        public int Channel
        {
            get
            {
                return channel;
            }

            set
            {
                if (value < 0)
                {
                    channel = 0;
                }
                else if (value >= 255)
                {
                    channel = 255;
                }
                else
                {
                    channel = value;
                }
            }
        }

        public override string Status()
        {
            return "\nТелевизор включен";
        }

        public override string ToString()
        {
            return $"Канал: {Channel}, Артикул: {Vendorcode}, Возвраст телевизора: {Age}";
        }

        public override string Art()
        {
                return $"\n ▄██████████████████████████████████████▄\n █▀─▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄─▀████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒Канал {Channel}▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▄─▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀─▄████████\n ▀██████████████████████████████████████▀\n ───▄▄▄████████████████████████████▄▄▄\n ──████████████████████████████████████";
        }

        public override void GetInfo()
        {
            Console.WriteLine(Status());
            Console.WriteLine(ToString());
            Console.WriteLine(Art());
        }
    }
}