using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    [RequireComponent(typeof(Button))]
    public class HelloButton : MonoBehaviour
    {
        [SerializeField]
        private InputField nameInputField;
        private Button button;

        void Start()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClick);
        }

        void OnClick()
        {
            if (nameInputField.text == "")
                AnimalManager.instance.SayHalloToAll();
            else
                AnimalManager.instance.SayHalloByName(nameInputField.text);
        }
    }
}