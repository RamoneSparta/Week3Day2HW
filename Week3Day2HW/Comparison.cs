using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week3Day2HW
{
    class Comparison : ICompareByLength, ICompareByName
    {
        private string name;
        private string name1;

        public Comparison()
        {

        }

        public string Name {get; set;}
        public string Name1 { get; set; }

        public int CompareByLength()
        {
            return Name.Length - Name1.Length;
        }

        public int CompareByName(object name)
        {
            //Comparison that = name as Comparison;
            return this.Name.CompareTo(this.Name1);
        }



        public void GetLengthComparison ()
        {

            try
            {
                if (CompareByLength() > 0)
                {
                    Console.WriteLine("{0} is longer than {1}", Name, Name1);
                }
                else if (CompareByLength() < 0)
                {
                    Console.WriteLine("{0} is shorter than {1}", Name, Name1);
                }
                else
                {
                    Console.WriteLine("{0} is the same length as {1}", Name, Name1);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetNameComparison (object name2)
        {
            try
            {
                if (CompareByName(name2) > 0)
                {
                    Console.WriteLine("{0} is below {1} alphabetically", Name, Name1);
                }
                else if (CompareByName(name2) < 0)
                {
                    Console.WriteLine("{0} is above {1} alphabetically", Name, Name1);
                }
                else
                {
                    Console.WriteLine("{0} is the same as {1} alphabetically", Name, Name1);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }


        public string GetUserInput()
        {
            return Console.ReadLine();
        }




    }
}
