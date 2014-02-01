using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class QuickSelect
	{
		public static int MedianOfTheThree(int[] a, int left, int right)
		{
			int center = (left + right) / 2;
			if (a[left] > a[center]) Swap(ref a[left], ref a[center]);
			if (a[center] > a[right]) Swap(ref a[center], ref a[right]);
			if (a[left] > a[right]) Swap(ref a[left], ref a[right]);
			Swap(ref a[center], ref a[right - 1]);
			return a[right - 1];
		}
		public static void QSelect(int[] a, int left, int right, int k)
		{
			if (right - left > 3)
			{
				int pivot = MedianOfTheThree(a, left, right);
				int i = left, j = right;
				while (true)
				{
					while (a[++i] < pivot) ;
					while (a[--j] > pivot) ;
					if (i < j) Swap(ref a[i], ref a[j]);
					else break;
				}
				Swap(ref a[i], ref a[right - 1]);
				int temp = right - k + 1;
				if (temp > i) QSelect(a, i + 1, right, k);
				else if (temp < i) QSelect(a, left, i - 1, k);
			}
			else
			{
				InsertionSort.Sort(a, left, right);
			}
		}
		private static void Swap(ref int a, ref int b)
		{
			a = a ^ b; b = a ^ b; a = a ^ b;
		}
	}
}
