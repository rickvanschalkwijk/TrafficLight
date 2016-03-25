using Trafficlight.Models;

namespace TrafficLightConsole
{
    public class RedState : LightState
    {
        public override void Change(TrafficLight trafficLight)
        {
            trafficLight.State = new GreenState();
        }

        public override string ReportState()
        {
            return Colors.Red;
        }
    }
}