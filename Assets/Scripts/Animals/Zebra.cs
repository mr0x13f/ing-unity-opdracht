using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Zebra : Animal, IHerbivore
    {
        override public void SayHello()
        {
            speechBalloon.Say("zebra zebra");
        }

        public void EatLeaves()
        {
            speechBalloon.Say("munch munch zank yee bra");
        }
    }
}
