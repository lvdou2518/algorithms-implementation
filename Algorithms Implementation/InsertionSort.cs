using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class InsertionSort
	{
		public static void Sort(int[] a, int s, int k)
		{
			int n = k - s + 1;
			int j, p;
			for (p = 1; p < n; p++)
			{
				int temp = a[p];
				for (j = p; j > 0 && a[j - 1] > temp; j--)
					a[j] = a[j - 1];
				a[j] = temp;
			}
		}
	}
}
