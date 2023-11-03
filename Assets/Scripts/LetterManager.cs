using UnityEngine;
using UnityEngine.UI;

public class LetterManager : MonoBehaviour
{
    [SerializeField] private Button closeLetterButton;
    [SerializeField] private GameObject letterPanel;

    private int currentLetterIndex;

    private AlphabetManager alphabetManager;
    private UIAnimations animations;

    public void Initialize(AlphabetManager alphabet, UIAnimations uIAnimations)
    {
        alphabetManager = alphabet;
        animations = uIAnimations;

        ButtonClickAction();

        Debug.Log("LetterManager initialize");
    }

    private void OnEnable()
    {
        currentLetterIndex = alphabetManager.currentLetterIndex;

        Debug.Log(currentLetterIndex);
    }

    private void ButtonClickAction()
    {
        if (closeLetterButton != null)
        {
            closeLetterButton.onClick.RemoveAllListeners();
            closeLetterButton.onClick.AddListener(() =>
            {
                animations.CloseLetterPanelAnimation(letterPanel);
            });
        }
    }
}
