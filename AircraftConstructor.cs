using System;
using System.Collections.Generic;
using System.Text;

namespace CS_DP_Builder
{
    class AircraftConstructor
    {
        public void Construct(AircraftBuilder aircraftBuilder)
        {
            aircraftBuilder.BuildFrame();
            aircraftBuilder.BuildEngine();
            aircraftBuilder.BuildWheels();
            aircraftBuilder.BuildDoors();
            aircraftBuilder.BuildWings();
        }
    }
}
