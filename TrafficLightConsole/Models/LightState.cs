using TrafficLightConsole;

namespace Trafficlight.Models
{
    public abstract class LightState
    {
        public abstract void Change(TrafficLight trafficLight);

        public abstract string ReportState();
    }
}