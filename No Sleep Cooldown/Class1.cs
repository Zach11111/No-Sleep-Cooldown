
using UnityEngine;
using TLDLoader;

namespace NoSleepCooldown
{
    public class NoSleepCooldown : Mod
    {
        public override string ID => "NoSleepCooldown";

        public override string Name => "No Sleep Cooldown";

        public override string Author => "Zach.O";

        public override string Version => "1";

        public override void Update()
        {
            mainscript.M.minTimeBeforeSleep = 0;
        }
    }

}

