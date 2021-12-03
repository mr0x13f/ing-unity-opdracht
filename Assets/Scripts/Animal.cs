using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public abstract class Animal : MonoBehaviour
    {
        public string animalName;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;

        abstract public void SayHello();

        protected void ShowBalloonMessage(string message) {
            Balloon.SetActive(true);
            text.text = message;
        }
    }
}