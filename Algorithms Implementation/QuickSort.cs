using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class QuickSort
	{
		public static int MedianOftheThree(int[] a, int left, int right)
		{
			int center = (left + right) / 2;
			if (a[left] > a[center]) Swap(ref a[left], ref a[center]);
			if (a[left] > a[right]) Swap(ref a[left], ref a[right]);
			if (a[center] > a[right]) Swap(ref a[center], ref a[right]);
			if (center != right - 1) Swap(ref a[center], ref a[right - 1]);
			return a[right - 1];
		}
		public static void QSort(int[] a, int left, int right)
		{
			int i = left, j = right - 1;

			if (right - left > 30)
			{
				int pivot = MedianOftheThree(a, left, right);
				while (true)
				{
					while (a[++i] < pivot) ;
					while (a[--j] > pivot) ;
					if (i < j) Swap(ref a[i], ref a[j]);
					else break;
				}
				if (i != (right - 1)) Swap(ref a[i], ref a[right - 1]);
				QSort(a, left, i - 1);
				QSort(a, i + 1, right);
			}
			else if (right >= left)
			{
				if (a[left] > a[right]) Swap(ref a[left], ref a[right]);
			}
		}

		private static void Swap(ref int a, ref int b)
		{
			a = a ^ b; b = a ^ b; a = a ^ b;
		}
	}
}
