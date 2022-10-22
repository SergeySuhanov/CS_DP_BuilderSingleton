using System;
using System.Collections.Generic;
using System.Text;

namespace CS_DP_Builder
{
    class HangGliderBuilder : AircraftBuilder
    {
        public HangGliderBuilder()
        {
            Aircraft = new Aircraft("Hang Glider");
        }

        public override void BuildFrame()
        {
            Aircraft.SetPart("frame", "Hang glider frame");
        }

        public override void BuildEngine()
        {
            Aircraft.SetPart("engine", "no engine");
        }

        public override void BuildWheels()
        {
            Aircraft.SetPart("wheels", "no wheels");
        }

        public override void BuildDoors()
        {
            Aircraft.SetPart("doors", "no doors");
        }

        public override void BuildWings()
        {
            Aircraft.SetPart("wings", "1");
        }
    }
}
