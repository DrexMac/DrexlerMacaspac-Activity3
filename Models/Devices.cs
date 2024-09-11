namespace DrexlerMacaspac_Activity3.Models
{
    public class Devices
    {
        protected string powerState;
        public Devices(string powerState)
        {
            this.powerState = powerState;
        }


        public virtual string PowerOn()
        {
            powerState = "On";
            return "Device is powering On.";
        }

    }

}
