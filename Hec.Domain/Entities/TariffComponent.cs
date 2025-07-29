using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hec.Entities
{
    public class TariffComponent : Entity
    {
        public string ComponentName { get; set; }  // Energy, AFA, Capacity, Network, etc.
        public string ComponentType { get; set; }  // "RATE" or "FIXED"
        public double Rate { get; set; }          // Rate per kWh (sen/kWh) or fixed amount (RM)
        public string Unit { get; set; }          // "sen/kWh" or "RM/month"
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }
        
        // Special conditions
        public int? MinConsumptionKwh { get; set; }  // Minimum consumption for this component
        public int? MaxConsumptionKwh { get; set; }  // Maximum consumption for this component
        public bool ExemptServiceTax { get; set; }   // Whether this component is exempt from service tax
        public bool ExemptKWTBB { get; set; }        // Whether this component is exempt from KWTBB
        
        public string Description { get; set; }
    }
}