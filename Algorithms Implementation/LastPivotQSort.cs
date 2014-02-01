using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class LastPivotQSort
	{
		public static void QSort(int[] a, int left, int right)
		{
			if (left < right)
			{
				int i = left - 1, j = right, pivot = a[right];
				while (i < j)
				{
					while (i < j && a[++i] < pivot) ;
					a[j] = a[i];
					while (i < j && a[--j] > pivot) ;
					a[i] = a[j];
				}
				a[i] = pivot;
				QSort(a, left, i - 1);
				QSort(a, i + 1, right);
			}
		}
	}
}
