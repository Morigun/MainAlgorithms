using MainAlgorithms.Services;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    internal class DefaultDotNet : BaseAlgorithm, ISort
    {
        public DefaultDotNet(IStat? stat) : base(stat, nameof(DefaultDotNet)){}

        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            list.Sort();//Подсчет кол-ва итерация затруднен, вставка надстроек приводит к погрешностям при расчете значений
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
    }
}
