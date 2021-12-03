using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.animalName = "henk";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.animalName = "elsa";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.animalName = "dora";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.animalName = "wally";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.animalName = "marty";            
        }
    }
}
