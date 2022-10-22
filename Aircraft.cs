using System;
using System.Collections.Generic;
using System.Text;

namespace CS_DP_Builder
{
    class Aircraft
    {
        string aircraftType;
        Dictionary<string, string> parts = new Dictionary<string, string>();

        public Aircraft(string type)
        {
            aircraftType = type;
        }

        public string GetPart(string key) {
		    if (!CheckForPart(key)) {
			    throw new Exception("There is no such key!");
		    }
		    return parts[key];
        }

        public void SetPart(string key, string value) {
		    parts[key] = value;
	    }

        public bool CheckForPart(string key)
        {
            return parts.ContainsKey(key);
        }

        public void Show()
        {
            Console.WriteLine("\n====================\n");
            Console.WriteLine($"Aircraft Type: {aircraftType}");
            Console.WriteLine($"Frame: {parts["frame"]}");
            Console.WriteLine($"Engine: {parts["engine"]}");
            Console.WriteLine($"Wheels: {parts["wheels"]}");
            Console.WriteLine($"Doors: {parts["doors"]}");
        }
    }
}
