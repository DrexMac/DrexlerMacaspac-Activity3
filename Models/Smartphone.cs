namespace DrexlerMacaspac_Activity3.Models
{
    public class Smartphone : Devices
    {
        protected string operatingSystem;

        
        public Smartphone(string operatingSystem, string powerState) : base(powerState)
        {
            this.operatingSystem = operatingSystem;
        }


        public override string PowerOn()
        {
            base.powerState = "On";
            return $"{operatingSystem} Smartphone is: {powerState}.";
        }
    }
}
