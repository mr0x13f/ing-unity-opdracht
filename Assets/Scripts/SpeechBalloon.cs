using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class SpeechBalloon : MonoBehaviour
    {
        [SerializeField]
        private Text text;
        [SerializeField]
        private float duration = 5;

        public void Say(string message)
        {
            gameObject.SetActive(true);
            text.text = message;

            // Stop the Deactivate coroutine in case it's already running
            StopCoroutine(nameof(Deactivate));
            // Disable this gameObject after the duration
            StartCoroutine(nameof(Deactivate));
        }

        private IEnumerator Deactivate()
        {
            yield return new WaitForSeconds(duration);
            gameObject.SetActive(false);
        }
    }
}
