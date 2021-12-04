using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Debugger : MonoBehaviour
    {
        private static Debugger _instance;
        public static Debugger instance {
            get {
                if (_instance != null)
                    return _instance;
                else
                    throw new Exception("No instance of Debugger");
            }
        }

        private void Awake() {
            if (_instance != null && _instance != this) {
                Destroy(gameObject);
                return;
            } else 
                _instance = this;
        }

        public void Log(string message)
        {
            Debug.Log(message);
        }
    }
}