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
        private int _extraChargeDistance = 8;
        public int StartPrice { get; } = 6;
        public int StartDistance { get; } = 2;
        public double WaitingPrice { get; } = 0.25;

        public double Bill(double distance, int waiting = 0)
        {
            double waitingFee = waiting * WaitingPrice;
            double distanceFee;

            if (distance <= StartDistance)
            {
                distanceFee = StartDistanceCalc(distance);
                return Math.Round(distanceFee + waitingFee, 2);
            }

            if (distance >= _extraChargeDistance)
            {
                distanceFee = ExceedDistanceCalc(distance);
            }
            else
            {
                distanceFee = CommonCalc(distance);
            }

            return Math.Round(distanceFee + waitingFee, 2);
        }

        private double CommonCalc(double distance)
        {
            return distance*_unitPrice;
        }

        private double ExceedDistanceCalc(double distance)
        {
            return _unitPrice * distance + _unitPrice * _extraPercentage * (distance - _extraChargeDistance);
        }

        private double StartDistanceCalc(double distance)
        {
            return StartPrice;
        }

    }
}
