using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Debugger : MonoBehaviour
    {
        private static Debugger instance;
        public static Debugger Instance {
            get {
                if (instance != null)
                    return instance;
                else
                    throw new Exception("No instance of Debugger");
            }
        }

        private void Awake() {
            if (instance != null && instance != this) {
                Destroy(gameObject);
                return;
            } else 
                instance = this;
        }

        public void Log(string message)
        {
            Debug.Log(message);
        }
    }
}