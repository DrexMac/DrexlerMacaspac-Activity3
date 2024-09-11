using DrexlerMacaspac_Activity3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrexlerMacaspac_Activity3.Pages
{
    public class IndexModel : PageModel
    {
        public string? LaptopMessage { get; private set; } = "Laptop is off.";
        public string? SmartphoneMessage { get; private set; } = "Smartphone is off.";

        private const string LaptopPowerStateKey = "LaptopPowerState";
        private const string SmartphonePowerStateKey = "SmartphonePowerState";

        public void OnGet()
        {
            LaptopMessage = HttpContext.Session.GetString(LaptopPowerStateKey) ?? "Laptop is off.";
            SmartphoneMessage = HttpContext.Session.GetString(SmartphonePowerStateKey) ?? "Smartphone is off.";
        }

        public void OnPostPowerOnLaptop()
        {
            var laptop = new Laptop("Asus", "Off");
            LaptopMessage = laptop.PowerOn(); 
            HttpContext.Session.SetString(LaptopPowerStateKey, LaptopMessage);
        }

        public void OnPostPowerOnSmartphone()
        {
            var smartphone = new Smartphone("Android", "Off");
            SmartphoneMessage = smartphone.PowerOn(); 
            HttpContext.Session.SetString(SmartphonePowerStateKey, SmartphoneMessage);
        }
    }
}
