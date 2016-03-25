using System;
using Trafficlight.Models;

namespace TrafficLightConsole
{
    public class TrafficLight
    {
        //build state service

        public LightState State { get; set; }

        public TrafficLight()
        {
            State = new RedState();
        }

        public void Request()
        {
            // add state service
            State.Change(this);
        }

        public void Reset()
        {
            State = new RedState();
        }
        public string ReportState()
        {
            return State.ReportState();
        }
    }
}