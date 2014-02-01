using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class MergeSort
	{
		public static void Merge(int[] a, int[] tmp, int left, int right)
		{
			if (left >= right) return;
			int center = (left + right) / 2;
			Merge(a, tmp, left, center);
			Merge(a, tmp, center + 1, right);
			MSort(a, tmp, left, center + 1, right);
		}

		private static void MSort(int[] a, int[] tmp, int left, int p, int right)
		{
			int pleft = left, pright = p, presult = left;
			while (pleft < p && pright <= right)
				tmp[presult++] = a[pleft] > a[pright] ? a[pright++] : a[pleft++];
			while (pleft < p) tmp[presult++] = a[pleft++];
			while (pright <= right) tmp[presult++] = a[pright++];
			int num = right - left + 1;
			for (int i = 0; i < num; i++, right--)
				a[right] = tmp[right];
		}
	}
}
