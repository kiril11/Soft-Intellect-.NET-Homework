using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket_Sort
{
    class Program
    {
        public void BucketSort(int[] integers)
        {
            if (integers == null || integers.Length == 0)
                return;
            int maxValue = integers[0];
            int minValue = integers[0];
            for (int i = 1; i < integers.Length; i++)
            {
                if (integers[i] > maxValue)
                    maxValue = integers[i];
                if (integers[i] < minValue)
                    minValue = integers[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < integers.Length; i++)
            {
                bucket[integers[i] - minValue].Add(integers[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        integers[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }
    }
}
