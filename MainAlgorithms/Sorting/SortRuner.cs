﻿using MainAlgorithms.Shuffle;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class SortRuner
    {
        private IServiceProvider? _serviceProvider { get; set; }
        public SortRuner(IServiceProvider? serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public void Run()
        {
            #region Init Array
            Random randForInitArrays = new Random(Environment.TickCount);
            var arr1 = new List<int>(1);
            var arr10 = new List<int>(10);
            var arr100 = new List<int>(100);
            var arr1K = new List<int>(1000);
            var arr10К = new List<int>(10000);
            var arr100К = new List<int>(100000);

            arr1.Add(randForInitArrays.Next(0, 10000));
            for (int i = 0; i < 10; i++)
                arr10.Add(randForInitArrays.Next(0, 10000));
            for (int i = 0; i < 100; i++)
                arr100.Add(randForInitArrays.Next(0, 10000));
            for (int i = 0; i < 1000; i++)
                arr1K.Add(randForInitArrays.Next(0, 10000));
            for (int i = 0; i < 10000; i++)
                arr10К.Add(randForInitArrays.Next(0, 10000));
            for (int i = 0; i < 100000; i++)
                arr100К.Add(randForInitArrays.Next(0, 10000));
            #endregion

            #region Test algorithms
            Console.WriteLine("Sort 1");
            SortsArr(arr1);
            Console.WriteLine("Sort 10");
            SortsArr(arr10);
            Console.WriteLine("Sort 100");
            SortsArr(arr100);
            Console.WriteLine("Sort 1000");
            SortsArr(arr1K);
            Console.WriteLine("Sort 10000");
            SortsArr(arr10К);
            Console.WriteLine("Sort 100000");
            SortsArr(arr100К);
            #endregion
        }
        void SortsArr(List<int> arr)
        {
            var sorts = _serviceProvider!.GetServices<ISort>();
            foreach (var sort in sorts)
            {
                if (arr.Count < 100000)
                {
                    sort.Sort(arr);
                    using (var fy = _serviceProvider!.GetService<FisherYeyts>())
                        fy?.Shuffle(arr);
                }
                else if (sort.CanMore100K())
                {
                    sort.Sort(arr);
                    using (var fy = _serviceProvider!.GetService<FisherYeyts>())
                        fy?.Shuffle(arr);
                }
            }
        }
    }
}
