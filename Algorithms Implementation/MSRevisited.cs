using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class MSRevisited
	{
		public static void Sort(int[] a, int[] tmp, int left, int right)
		{
			if (left < right)
			{
				int middle = (left + right) / 2;
				Sort(a, tmp, left, middle);
				Sort(a, tmp, middle + 1, right);
				Merge(a, tmp, left, middle + 1, right);
			}
		}
		private static void Merge(int[] a, int[] tmp, int left, int middle, int end)
		{
			
				int i = left, j = middle, k = left;

				while (i < middle && j <= end) tmp[k++] = a[i] < a[j] ? a[i++] : a[j++];
				while (i < middle) tmp[k++] = a[i++];
				while (j <= end) tmp[k++] = a[j++];

				while (--k >= left) a[k] = tmp[k];
		}
	}
}
