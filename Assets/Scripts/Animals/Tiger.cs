using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Tiger : Animal, ICarnivore, ITrickPerformer
    {
        override public void SayHello()
        {
            ShowBalloonMessage("rraaarww");
        }

        public void EatMeat()
        {
            ShowBalloonMessage("nomnomnom thx wubalubadubdub");
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
