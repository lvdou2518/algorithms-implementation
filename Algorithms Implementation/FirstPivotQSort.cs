using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class FirstPivotQSort
	{
		public static void QSort(int[] a, int left, int right)
		{
			if (left < right)
			{
				int i = left, j = right + 1, pivot = a[left];
				while (i < j)
				{
					while (i < j && a[--j] > pivot) ;
					a[i] = a[j];
					while (i < j && a[++i] < pivot) ;
					a[j] = a[i];
				}
				a[i] = pivot;
				QSort(a, left, i - 1);
				QSort(a, i + 1, right);
			}
		}

	}
}
