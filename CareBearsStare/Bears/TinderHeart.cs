﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    class TinderHeart : CareBearBase
    {
        public TinderHeart()
        {
            Name = "Tinder Heart";
            BellyBadge = "Cell Phone";
            Color = BearColor.Gold;
        }

        public override void Stare()
        {
            Console.WriteLine("Swipe Left");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Swipe right on {careBearToHug.Name}");
        }
    }
}
