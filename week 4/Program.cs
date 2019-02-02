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
            c.run();


        }
    }
    class LearningExperiment
    {
        public void run()
        {
            village Toronto;
            Toronto = new village();
            village a, b, c;
            Toronto.villagename = "version A";
            a = Toronto;
            Console.WriteLine(a.villagename);
            Toronto = new village();
            Toronto.villagename = "version B";
            b = Toronto;
            Console.WriteLine(a.villagename);
            Toronto = new village();
            Toronto.villagename = "version C";
            c = Toronto;
            Console.WriteLine(a.villagename);
        }
    }
        class village
        {
          public  bool isAstrilde;
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
                Toronto = new village();
                Ajax   = new village();
                Ajax.isAstrilde = true;
                Maple.villagename = "Toronto";
                Maple.nextvillage = Toronto;
            }
            public void travel()
            {
                village currentvillage = Toronto;
                while (!currentvillage.isAstrilde)
                {
                    if (currentvillage.isAstrilde)
                        Console.WriteLine("You found Astrilde in " + currentvillage);
                    else
                        currentvillage = currentvillage.nextvillage;
                }
            }
        }

    
}



