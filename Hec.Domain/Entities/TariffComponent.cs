using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hec.Entities
{
    public class TariffComponent : Entity
    {
        public string ComponentName { get; set; }
        public string ComponentType { get; set; } = "RATE";  // Default value
        public double Rate { get; set; } = 0.0;              // Default value
        public string Unit { get; set; } = "sen/kWh";        // Default value
        public DateTime EffectiveFrom { get; set; } = DateTime.Now; // Default value
        public DateTime? EffectiveTo { get; set; }           // Nullable
        public bool IsActive { get; set; } = true;           // Default value
        public int Sequence { get; set; } = 1;               // Default value

        // Special conditions - all nullable
        public int? MinConsumptionKwh { get; set; }
        public int? MaxConsumptionKwh { get; set; }
        public bool ExemptServiceTax { get; set; } = false;  // Default value
        public bool ExemptKWTBB { get; set; } = false;       // Default value

        public string Description { get; set; } = "";        // Default value
    }
}