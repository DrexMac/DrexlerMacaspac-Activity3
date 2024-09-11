namespace DrexlerMacaspac_Activity3.Models
{
    public class Laptop : Devices
    {
        protected string brand;

        public Laptop(string brand, string powerState) : base(powerState)
        {
            this.brand = brand;
        }



        public override string PowerOn()
        {
            base.powerState = "On";
            return $"{brand} Laptop is: {powerState}.";
        }

    }
}
