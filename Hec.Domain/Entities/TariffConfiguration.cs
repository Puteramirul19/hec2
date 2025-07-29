using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hec.Entities
{
    public class TariffConfiguration : Entity
    {
        public string ConfigurationName { get; set; } = "";  // Default value
        public DateTime EffectiveFrom { get; set; } = DateTime.Now; // Default value
        public DateTime? EffectiveTo { get; set; }           // Nullable
        public bool IsActive { get; set; } = true;           // Default value

        // Tax configurations with defaults
        public double ServiceTaxRate { get; set; } = 0.08;   // Default 8%
        public int ServiceTaxThresholdKwh { get; set; } = 0; // Default 0

        public double KwtbbRate { get; set; } = 0.016;       // Default 1.6%
        public int KwtbbThresholdKwh { get; set; } = 0;      // Default 0

        // Other thresholds with defaults
        public int EnergyEfficiencyMaxKwh { get; set; } = 0; // Default 0
        public int RetailChargeThresholdKwh { get; set; } = 0; // Default 0

        public string Description { get; set; } = "";        // Default value
    }
}