using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkelonTestWork
{
    /// <summary>
    /// Перечисление типов распределения сумм
    /// <br/>
    /// proportional - (ПРОП) через пропорции
    /// <br/>
    /// first_count - (ПЕРВ) на всю сумму по порядку
    /// <br/>
    /// last_count - (ПОСЛ) на всю сумму в обратном порядке
    /// </summary>
    public enum DistributionType
    {
        proportional,
        first_count,
        last_count
    }
    /// <summary>
    /// класс для работы над
    /// </summary>
    class SumCount
    {
        public string Distribute(double sum, string sums, DistributionType type)
        {
            double[] distribution_sums = Array.ConvertAll<string, double>(sums.Split(';'), Double.Parse);
            double[] result_sums = new double[distribution_sums.Count()];
            switch (type)
            {
                case DistributionType.proportional:
                    double[] sums_weight = new double[distribution_sums.Count()];
                    for (int i=0; i < sums_weight.Count(); i++)
                    {
                        sums_weight[i] = distribution_sums[i] / distribution_sums.Sum();
                        result_sums[i] = Math.Round(sum * sums_weight[i], 2);
                    }
                    if (result_sums.Sum() > sum)
                        result_sums[result_sums.Count() - 1] = result_sums[result_sums.Count() - 1] - (result_sums[result_sums.Count() - 1] - sum);
                    break;

                case DistributionType.first_count:
                    result_sums = DistributeLikeCount(sum, distribution_sums);
                    break;

                case DistributionType.last_count:
                    Array.Reverse(distribution_sums);
                    result_sums = DistributeLikeCount(sum, distribution_sums);
                    Array.Reverse(result_sums);
                    break;

                default:

                    break;
            }
            return String.Join(";", result_sums);
        }

        private double[] DistributeLikeCount(double sum, double[] distribution_sums)
        {
            double[] result = new double[distribution_sums.Count()];
            int i = 0;
            while ((sum > 0) && (i < distribution_sums.Count()))
            {
                if (sum - distribution_sums[i] > 0)
                    result[i] = distribution_sums[i];
                else
                    result[i] = sum;
                sum -= result[i];
                i++;
            }
            return result;
        }
    }
}
