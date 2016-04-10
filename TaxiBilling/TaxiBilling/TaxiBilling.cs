using System;
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

        public int Bill(double distance, int waiting = 0)
        {
            double waitingFee = waiting * WaitingPrice;
            double distanceFee;

            if (distance <= StartDistance)
            {
                distanceFee = StartDistanceCalc(distance);
                return RoundResult(distanceFee + waitingFee);
            }

            if (distance >= _extraChargeDistance)
            {
                distanceFee = ExceedDistanceCalc(distance);
            }
            else
            {
                distanceFee = CommonCalc(distance);
            }

            return RoundResult(distanceFee + waitingFee);
        }

        private static int RoundResult(double result)
        {
            return (int) Math.Round(result);
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
