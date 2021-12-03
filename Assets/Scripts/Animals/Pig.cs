using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Pig : Animal, IHerbivore, ICarnivore, ITrickPerformer
    {
        override public void SayHello()
        {
            ShowBalloonMessage("oink oink");
        }

        public void EatLeaves()
        {
            ShowBalloonMessage("munch munch oink");
        }

        public void EatMeat()
        {
            ShowBalloonMessage("nomnomnom oink thx");
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
