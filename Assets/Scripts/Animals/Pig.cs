using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Pig : Animal, IHerbivore, ICarnivore, ITrickPerformer
    {
        [SerializeField]
        private Trick trick;

        override public void SayHello()
        {
            speechBalloon.Say("oink oink");
        }

        public void EatLeaves()
        {
            speechBalloon.Say("munch munch oink");
        }

        public void EatMeat()
        {
            speechBalloon.Say("nomnomnom oink thx");
        }

        public void PerformTrick()
        {
            trick.Perform();
        }
    }
}
