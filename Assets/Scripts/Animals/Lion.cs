using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Lion : Animal, ICarnivore
    {
        override public void SayHello()
        {
            speechBalloon.Say("roooaoaaaaar");
        }

        public void EatMeat()
        {
            speechBalloon.Say("nomnomnom thx mate");
        }
    }
}
