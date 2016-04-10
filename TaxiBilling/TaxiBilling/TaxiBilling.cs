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
        public int StartPrice { get; } = 6;
        public int StartDistance { get; } = 2;
        public double WaitingPrice { get; } = 0.25;

        public double Bill(double distance, int waiting = 0)
        {
            double result = waiting * WaitingPrice;
            
            if (distance <= StartDistance)
                return StartPrice + result;

            if (distance >= _extraChargeStartDistance)
            {
                result += _unitPrice * distance + _unitPrice * _extraPercentage * (distance - _extraChargeStartDistance);
                return Math.Round(result, 2);
            }

            result += distance*_unitPrice;
            return Math.Round(result, 2);
        }
    }
}
