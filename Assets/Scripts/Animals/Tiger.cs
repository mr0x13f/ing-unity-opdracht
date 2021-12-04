using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Tiger : Animal, ICarnivore, ITrickPerformer
    {
        [SerializeField]
        private Trick trick;

        override public void SayHello()
        {
            speechBalloon.Say("rraaarww");
        }

        public void EatMeat()
        {
            speechBalloon.Say("nomnomnom thx wubalubadubdub");
        }

        public void PerformTrick()
        {
            trick.Perform();
        }
    }
}
