using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class ISRevisited
	{
		public static void Sort(int[] a, int start, int end)
		{
			int n = end - start;
			int j;
			for (int p = 1; p < n; p++)
			{
				int tmp = a[p];
				for (j = p; j > 0 && a[j - 1] > tmp; j--)
				{
					a[j] = a[j - 1];
				}
				a[j] = tmp;
			}
			//for (int i = 1; i < a.Length; i++)
			//{
			//	int k = -1;
			//	for (int j = i-1; j >= 0; j--)
			//	{
			//		if (a[i] < a[j])
			//		{
			//			k = j;
			//		}
			//	}
			//	if (k != -1)
			//	{
			//		int tmp = a[i];
			//		for (int t = i; t > k; t--)
			//		{
			//			a[t] = a[t - 1];
			//		}
			//		a[k] = tmp;
			//	}
			//}
		}
	}
}
