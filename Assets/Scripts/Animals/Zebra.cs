using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Zebra : Animal, IHerbivore
    {
        override public void SayHello()
        {
            ShowBalloonMessage("zebra zebra");
        }

        public void EatLeaves()
        {
            ShowBalloonMessage("munch munch zank yee bra");
        }
    }
}
