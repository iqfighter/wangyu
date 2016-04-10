using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBilling
{
    public class TaxiBilling
    {
        private double _unitPrice = 0.8;
        private double _extraPercentage = 0.5;
        private int _extraChargeStartDistance = 8;
        public double Bill(double distance)
        {
            double result;
            if (distance >= _extraChargeStartDistance)
            {
                result = _unitPrice * distance + _unitPrice * _extraPercentage * (distance - _extraChargeStartDistance);
                return Math.Round(result, 2);
            }
            result = distance*_unitPrice;
            return Math.Round(result, 2);
        }
    }
}
