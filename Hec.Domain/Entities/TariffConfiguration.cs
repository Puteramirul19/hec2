using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hec.Entities
{
    public class TariffConfiguration : Entity
    {
        public string ConfigurationName { get; set; }  // "OLD_TARIFF" or "NEW_TARIFF"
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        
        // Tax configurations
        public double ServiceTaxRate { get; set; }     // 8%
        public int ServiceTaxThresholdKwh { get; set; } // 600 kWh
        
        public double KwtbbRate { get; set; }          // 1.6%
        public int KwtbbThresholdKwh { get; set; }     // 300 kWh
        
        // Other thresholds
        public int EnergyEfficiencyMaxKwh { get; set; } // 1000 kWh
        public int RetailChargeThresholdKwh { get; set; } // 600 kWh
        
        public string Description { get; set; }
    }
}