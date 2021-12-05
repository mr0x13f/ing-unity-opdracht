using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lionPrefab, hippoPrefab, pigPrefab,
            tigerPrefab, zebraPrefab, capybaraPrefab, orangutanPrefab;
        
        private void Start()
        {
            Lion henk = Instantiate(lionPrefab, transform).GetComponent<Lion>();
            henk.animalName = "henk";
            Hippo elsa = Instantiate(hippoPrefab, transform).GetComponent<Hippo>();
            elsa.animalName = "elsa";
            Pig dora = Instantiate(pigPrefab, transform).GetComponent<Pig>();
            dora.animalName = "dora";
            Tiger wally = Instantiate(tigerPrefab, transform).GetComponent<Tiger>();
            wally.animalName = "wally";
            Zebra marty = Instantiate(zebraPrefab, transform).GetComponent<Zebra>();
            marty.animalName = "marty";
            Capybara coconutDog = Instantiate(capybaraPrefab, transform).GetComponent<Capybara>();
            coconutDog.animalName = "coconut dog";
            Orangutan monke = Instantiate(orangutanPrefab, transform).GetComponent<Orangutan>();
            monke.animalName = "monke";
        }
    }
}
