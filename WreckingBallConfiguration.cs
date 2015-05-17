using Rocket.API;

namespace ApokPT.RocketPlugins
{
    public class WreckingBallConfiguration : IRocketPluginConfiguration
    {

        public bool Enabled;

        public IRocketPluginConfiguration DefaultConfiguration
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
