using System;
namespace TaxiBilling
{
    public class TaxiBilling
    {
        private readonly double _unitPrice = 0.8;
        private readonly double _extraPercentage = 0.5;
        private readonly int _extraChargeDistance = 8;
        public int StartPrice { get; } = 6;
        public int StartDistance { get; } = 2;
        public double WaitingPrice { get; } = 0.25;

        public int Bill(double distance, int waiting = 0)
        {
            if (distance < 0 || waiting < 0)
                return 0;

            var waitingFee = waiting * WaitingPrice;

            if (distance <= StartDistance)
            {
                return RoundResult(StartDistanceCalc(distance) + waitingFee);
            }

            
            if (distance >= _extraChargeDistance)
            {
                return RoundResult(ExceedDistanceCalc(distance) + waitingFee);
            }

            return RoundResult(CommonCalc(distance) + waitingFee);
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
