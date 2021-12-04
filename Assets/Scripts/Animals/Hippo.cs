using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Hippo : Animal, IHerbivore
    {
        override public void SayHello()
        {
            speechBalloon.Say("splash");
        }

        public void EatLeaves()
        {
            speechBalloon.Say("munch munch lovely");
        }
    }
}
