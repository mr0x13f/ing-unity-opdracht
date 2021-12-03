using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Hippo : Animal, IHerbivore
    {
        override public void SayHello()
        {
            ShowBalloonMessage("splash");
        }

        public void EatLeaves()
        {
            ShowBalloonMessage("munch munch lovely");
        }
    }
    
}
