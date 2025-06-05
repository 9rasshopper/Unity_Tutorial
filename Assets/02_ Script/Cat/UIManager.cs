using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
      public TMP_InputField inputField;
      public TextMeshProUGUI nameTextUI;

        public Button startButton;

        void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
        }
        public void OnStartButton()
        {
            if (inputField.text == "")
            {
                nameTextUI.text = "°ø¾çÀÌ";
            }
            else
            {
                startButton.interactable = false;
                nameTextUI.text = inputField.text;
            }
        }
    }

}
