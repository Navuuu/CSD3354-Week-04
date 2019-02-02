using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside c = new Countryside();
        }
        
        class village
        {
          public  bool isAstrildeHere;
          public  village nextvillage;
          public  village prevvillage;
          public string villagename;

        }
        class Countryside
        {
            village Maple;
            village Toronto;
            village Ajax;

            public void run()
            {
                Maple = new village();
                Maple.villagename = "Toronto";
                Maple.nextvillage = Toronto;
            }
        }

    }
}



