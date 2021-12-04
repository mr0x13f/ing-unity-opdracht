using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Orangutan : Animal, IHerbivore, ICarnivore, ITrickPerformer
    {
        [SerializeField]
        private Trick trick;
        
        override public void SayHello()
        {
            speechBalloon.Say("oo oo aa aa");
        }

        public void EatLeaves()
        {
            speechBalloon.Say("monke munch");
        }

        public void EatMeat()
        {
            speechBalloon.Say("monke munch meat");
        }

        public void PerformTrick()
        {
            trick.Perform();
        }
    }
}
