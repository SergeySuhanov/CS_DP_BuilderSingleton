using System;
using System.Collections.Generic;
using System.Text;

namespace CS_DP_Builder
{
    class AircraftBuilder
    {
        public Aircraft Aircraft { get; set; }

        public virtual void BuildFrame() { }
        public virtual void BuildEngine() { }
        public virtual void BuildWheels() { }
        public virtual void BuildDoors() { }
        public virtual void BuildWings() { }

    }
}
