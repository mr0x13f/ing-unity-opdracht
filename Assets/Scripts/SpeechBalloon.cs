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

        public void Say(string message)
        {
            gameObject.SetActive(true);
            text.text = message;
        }

    }
}