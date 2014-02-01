using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	public static class QSRevisited
	{
		public static void Sort(int[] a, int start, int end)
		{
			if (start < end)
			{
				var pivot = a[start];
				int i = start, j = end;
				while (i < j)
				{
					while (i < j && pivot < a[--j]) ;
					a[i] = a[j];
					while (i < j && pivot > a[++i]) ;
					a[j] = a[i];
				}
				a[i] = pivot;
				Sort(a, start, i);
				Sort(a, i + 1, end);
			}
		}
	}
}
