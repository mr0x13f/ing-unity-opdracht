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
        protected SpeechBalloon speechBalloon;

        abstract public void SayHello();
    }
}
