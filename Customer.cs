using System.Collections.Generic;

namespace HelloWorld
{
    public class Customer
    {
        List<int> positions;
        public void SortArray()
        {
            int temp=0;
            int[] arr = new int[] { 20, 65, 98, 71, 64, 11, 2, 80, 5, 6, 100, 50, 13, 9, 80, 454 };
            positions = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
                positions.Add(arr[i]);

                //Console.WriteLine(arr[i]);
            }

            for (int k = 0; k < positions.Count; k++)
            {
                Console.WriteLine(positions[k]);
            }
        }
    }
}