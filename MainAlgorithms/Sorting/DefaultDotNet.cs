using MainAlgorithms.Services;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class DefaultDotNet : BaseAlgorithm, ISort
    {
        public DefaultDotNet(IStat? stat) : base(stat, nameof(DefaultDotNet)){}
        public bool CanMore100K()
        {
            return true;
        }

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
