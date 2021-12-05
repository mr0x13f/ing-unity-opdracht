using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class SpinTrick : Trick
    {
        [SerializeField]
        [Tooltip("Duration of the trick in seconds")]
        private float duration = 2f;
        private bool playing = false;

        override public void Perform()
        {
            if (!playing)
                StartCoroutine(DoTrick());
        }

        private IEnumerator DoTrick()
        {
            playing = true;
            float startTime = Time.time;

            while (true)
            {
                // Find how far we are into the animation as a fraction
                float currentProgress = (Time.time - startTime) / duration;
                // Cap it to the duration of the animation
                // Otherwise we might rotate too far on the last frame
                currentProgress = Mathf.Min(currentProgress, 1);

                // Find how far we need to rotate
                float rotation = 360 * currentProgress;

                // Rotate
                transform.localRotation = Quaternion.Euler(rotation, 0, 0);

                // Keep going if there's still time left in the animation
                if (currentProgress < 1)
                    yield return new WaitForEndOfFrame();
                else
                    break;
            }

            playing = false;
        }
    }
}
