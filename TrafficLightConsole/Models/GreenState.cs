using Trafficlight.Models;

namespace TrafficLightConsole
{
    public class GreenState : LightState
    {
        public override void Change(TrafficLight trafficLight)
        {
            trafficLight.State = new RedState();
        }

        public override string ReportState()
        {
            return Colors.Green;
        }
    }
}