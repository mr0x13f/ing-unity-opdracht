using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Capybara : Animal, IHerbivore, ITrickPerformer
    {
        [SerializeField]
        private Trick trick;
        
        override public void SayHello()
        {
            speechBalloon.Say("squeek squeek");
        }

        public void EatLeaves()
        {
            speechBalloon.Say("lekkere smikkel");
        }

        public void PerformTrick()
        {
            trick.Perform();
        }
    }
    
}
