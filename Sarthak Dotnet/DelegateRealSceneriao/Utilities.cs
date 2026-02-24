

namespace DelegateRealSceneriao
{
     class Utilities
    {
        public static void Sort(object[] data , CompareFn f)
        {
            for(int i = 0; i < data.Length-1;i++)
            {
                for(int j = i +1; j < data.Length;j++)
                {
                    if(f(data[i], data[j]) > 0)
                    {
                        object temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
}
