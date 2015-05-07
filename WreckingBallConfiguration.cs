using Rocket.RocketAPI;

namespace ApokPT.RocketPlugins
{
    public class WreckingBallConfiguration : IRocketConfiguration
    {

        public bool Enabled;

        public IRocketConfiguration DefaultConfiguration
        {
            get
            {
                WreckingBallConfiguration config = new WreckingBallConfiguration();
                config.Enabled = true;
                return config;
            }
        }
    }
}
