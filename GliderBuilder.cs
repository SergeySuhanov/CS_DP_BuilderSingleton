using System;
using System.Collections.Generic;
using System.Text;

namespace CS_DP_Builder
{
    class GliderBuilder : AircraftBuilder
    {
        public GliderBuilder()
        {
            Aircraft = new Aircraft("Glider");
        }

        public override void BuildFrame()
        {
            Aircraft.SetPart("frame", "Glider frame");
        }

        public override void BuildEngine()
        {
            Aircraft.SetPart("engine", "no engine");
        }

        public override void BuildWheels()
        {
            Aircraft.SetPart("wheels", "1");
        }

        public override void BuildDoors()
        {
            Aircraft.SetPart("doors", "1");
        }

        public override void BuildWings()
        {
            Aircraft.SetPart("wings", "2");
        }
    }
}
