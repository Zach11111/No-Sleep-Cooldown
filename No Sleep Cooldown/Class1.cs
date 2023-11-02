
using UnityEngine;
using TLDLoader;

namespace NoSleepCooldown
{
    public class NoSleepCooldown : Mod
    {
        public override string ID => "YourModUniqueID";

        public override string Name => "Your Mod Name";

        public override string Author => "Your Name";

        public override string Version => "1";

        public override void Update()
        {
            mainscript.M.minTimeBeforeSleep = 0;
        }
    }

}

