using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Lion : Animal, ICarnivore
    {
        override public void SayHello()
        {
            ShowBalloonMessage("roooaoaaaaar");
        }

        public void EatMeat()
        {
            ShowBalloonMessage("nomnomnom thx mate");
        }
    }
}
