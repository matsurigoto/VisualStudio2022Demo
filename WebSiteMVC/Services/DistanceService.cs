using System.Collections.Generic;

namespace WebSiteMVC.Services
{
    
    public interface IDistanceService
    {
        double MinDistanceInMeter(List<double> distanceList);

        double MaxDistanceInMeter(List<double> distanceList);

        double SumDistanceInMeter(List<double> distanceList);

        double AvgDistanceInMeter(List<double> distanceList);
    }

    public class DistanceService : IDistanceService
    {
        double IDistanceService.AvgDistanceInMeter(List<double> distanceList)
        {
            double sum = 0;
            double average = 0;
            foreach (var distance in distanceList)
            {
                sum += distance;
            }
            average = sum / distanceList.Count;
            
            //KMToMeter(average) 
            return average * 1000;
        }

        double IDistanceService.MaxDistanceInMeter(List<double> distanceList)
        {
            double max = 0;
            foreach (var distance in distanceList)
            {
                if (distance > max)
                {
                    max = distance;
                }
            }
            return max * 1000;
        }

        double IDistanceService.MinDistanceInMeter(List<double> distanceList)
        {
            double min = 0;
            foreach (var distance in distanceList)
            {
                if (distance > min)
                {
                    min = distance;
                }
            }
            return min * 1000;
        }

        double IDistanceService.SumDistanceInMeter(List<double> distanceList)
        {
            double sum = 0;
            foreach (var distance in distanceList)
            {
                sum += distance;
            }
            //Ctrl + Alt + . 
            return sum * 1000;
        }

        private double KMToMeter(double km)
        {
            return km * 1000;
        }
    }
}
