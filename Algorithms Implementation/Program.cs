using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Implementation
{
	class Program
	{
		static int randNum = 50;
		static void Main(string[] args)
		{
			Random r = new Random(DateTime.Now.Millisecond);
			//r.Next(100);
			int[] a = new int[randNum];
			for (int i = 0; i < randNum; i++)
			{
				a[i] = r.Next(randNum);
			}
			Stopwatch sw = new Stopwatch();
			sw.Start();
			//MergeSort.Merge(a, new int[a.Length], 0, a.Length-1);
			//QuickSort.QSort(a, 0, a.Length - 1);
			//QuickSelect.QSelect(a, 0, a.Length - 1, 10000000);
			//InsertionSort.Sort(a, 0, a.Length - 1);
			//MSRevisited.Sort(a, new int[randNum], 0, a.Length-1);
			//FirstPivotQSort.QSort(a, 0, a.Length - 1);
			//LastPivotQSort.QSort(a, 0, a.Length - 1);
			//QSRevisited.Sort(a, 0, a.Length);
			ISRevisited.Sort(a,0,a.Length);
			sw.Stop();
			OutPut(a);
			//Console.WriteLine(a[a.Length - 100]);
			Console.WriteLine(sw.ElapsedMilliseconds/1000);
			Console.ReadLine();

		}
		static void OutPut(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
			Console.ReadLine();
		}
	}
}
