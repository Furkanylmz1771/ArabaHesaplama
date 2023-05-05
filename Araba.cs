using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaUyg
{
    public class Araba
    {
        private double yakit;

        private int hiz;

        public Araba(double y, int s)          // Constructor
        {
            yakit = y;
            hiz = s;

        }

        public string gosterge()
        {
            return "Yakıt miktarı:" + yakit.ToString() + " Hız" + hiz.ToString();
        }

        public void set_Yakit(double y)             // y dısarıdan double olarak gelsin
        {
            if (y > 60)                     // y 60 ve 0 arasında sabitlenir.
            {
                y = 60;
                if (y < 0)
                {
                    y = 0;
                    yakit = y;


                }
            }
        }

        public double get_Yakit()
        {
            return yakit;               // Mevcut yakıt miktarı
        }



        public void set_Hız(int s)
        {
            if (s > 260)

                s = 260;
            if (s < 0)

                s = 40;
            hiz = s;
        }

        public int get_Hiz()
        {
            return hiz;
        }



        public void yakıt_Yukle(double y)
        {
            y = yakit + y;
            set_Yakit(y);
        }


        public void sur()
        {
            if (hiz < 50)
            {
                yakit -= 3;
            }
            else if (hiz < 90)
            {
                yakit -= 1;
            }

            else if (hiz < 140)
            {
                yakit -= 2;
            }

            else if (hiz < 180)
            {
                yakit -= 3;
            }
            else
            {
                yakit -= 4;

                set_Yakit(yakit);
            }


        }
    }
}

    
      

    