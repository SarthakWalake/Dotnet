using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableSorting
{
     class Utlitiy
    {
        public static void Sort(IComparable[] data)
        {
            for(int i = 0; i < data.Length-1;i++)
            {
                for(int j = i + 1; j < data.Length;j++)
                {
                    if(data[i].CompareTo(data[j]) > 0)
                    {
                        IComparable temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
}
