using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LabaFirstCS
{
    public class Time
    {
        private double time;
        private double timePlan;
        public Time(double timePlan, double time)
        {
                this.time = time;
                this.timePlan = timePlan;
           
        }
        public double getTime()
        {
            return time;
        }

        public double getTime1
        {
            get
            {
                return (double)time;
            }
            set
            {
                this.getTime1 = value;
            }
        }
        public double getTimePlan()
        {
            return timePlan;
        }
        public void setTime(double time)
        {
            this.time= time;
        }
        public void setTimePlan(double timePlan)
        {
            this.timePlan = timePlan;
        }
        public String toString()
        {
            return timePlan+" "+time;
        }


    }
    public class Class1
    {

        static void mmm()
        {
            int len = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[len];

            for (int i = 0; i < len; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int otr = 0;
            for (int i = 0; i < len; i++)
            {
                if (a[i] < 0)
                {
                    otr++;
                }
            }
            Console.WriteLine(otr);
        }
        static void mmm3()
        {
            
            List<Time> ToDo_List = new List<Time>();
            ToDo_List.Add(new Time(15.10, 0.15));
            ToDo_List.Add(new Time(14.15, 0.30));
            ToDo_List.Add(new Time(3.6, 0.15));
            ToDo_List.Add(new Time(15.15, 0.30));

            
            List<Time> ToDo_ = ToDo_List.FindAll(x =>x.getTimePlan()>=14.0 );
            ToDo_.ForEach(x =>Console.WriteLine(x.toString()));
           

        }
        static void mmm2()
        {
            int[,] nums2 = new int[8, 3];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nums2[i, j] = random.Next(-10, 10);
                }

            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(nums2[i, j] + " ");
                }
                Console.Write("\n");
            }
            double[] a = new double[8];
            for (int i = 0; i < 8; i++)
            {
                double temp;
                temp = (nums2[i, 0] + nums2[i, 1] + nums2[i, 1] + nums2[i, 2]) / 3;
                a[i] = temp;
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Main()
        {
            int cheic = Convert.ToInt32(Console.ReadLine());

            if (cheic == 1)
            {
                mmm();
            }
            if (cheic == 2)
            {
                mmm2();
            }
            if (cheic == 3)
            {
                mmm3();
            }
        }



    }

}
