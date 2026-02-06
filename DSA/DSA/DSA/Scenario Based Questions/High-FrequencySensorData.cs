using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Scenario_Based_Questions
{
    internal class High_FrequencySensorData
    {
       
        public class SensorMonitor
        {
        private class SensorData
        {
            public LinkedList<(long Timestamp, double Value)> Window = new LinkedList<(long, double)>();
            public double CurrentSum = 0;
        }

        private Dictionary<int, SensorData> _sensors = new Dictionary<int, SensorData>();
        private const long WindowSizeSeconds = 60;

        public void ProcessReading(int sensorId, long timestampSeconds, double value)
        {
            if (!_sensors.ContainsKey(sensorId))
            {
                _sensors[sensorId] = new SensorData();
            }

            var sensor = _sensors[sensorId];

            while (sensor.Window.Count > 0 && sensor.Window.First.Value.Timestamp <= timestampSeconds - WindowSizeSeconds)
            {
                var expired = sensor.Window.First.Value;
                sensor.CurrentSum -= expired.Value;
                sensor.Window.RemoveFirst();
            }

            if (timestampSeconds < timestampSeconds - WindowSizeSeconds)
            {
                return;
            }

            double currentAvg = sensor.Window.Count > 0 ? sensor.CurrentSum / sensor.Window.Count : 0;

            if (sensor.Window.Count > 0 && value > 3 * currentAvg)
            {
                Console.WriteLine($"ALERT: Spike detected on Sensor {sensorId}. Value: {value}, Avg: {currentAvg}");
            }

            sensor.Window.AddLast((timestampSeconds, value));
            sensor.CurrentSum += value;
        }

        public double GetAverage(int sensorId)
        {
            if (!_sensors.ContainsKey(sensorId) || _sensors[sensorId].Window.Count == 0) return 0.0;
            return _sensors[sensorId].CurrentSum / _sensors[sensorId].Window.Count;
        }
    }
}
}
