using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_ChallengeLab
{
    public class FindOddOne
    {


        public static void FindOddNumber()

        {
            int counter = 0;
            int finder=1;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            dictionary.Add(1, 2);
            dictionary.Add(2, 2);
            dictionary.Add(3, finder);


            foreach (var item in dictionary)
            {
                if (dictionary.ContainsValue(finder))
                {

                    counter++;
                    Console.WriteLine($"{finder} was found {counter} times");
                    break;
                }


            }








          
        }


    }
}
