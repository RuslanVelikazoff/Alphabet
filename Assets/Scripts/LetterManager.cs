using UnityEngine;
using UnityEngine.UI;

public class LetterManager : MonoBehaviour
{
    [SerializeField] private Button closeLetterButton;
    [SerializeField] private GameObject letterPanel;
    [SerializeField] private Text letterText;

    [SerializeField] private string[] letters;

    private int currentLetterIndex;

    private AlphabetManager alphabetManager;
    private UIAnimations animations;

    public void Initialize(AlphabetManager alphabet, UIAnimations uIAnimations)
    {
        alphabetManager = alphabet;
        animations = uIAnimations;

        letterPanel.SetActive(false);

        letters = alphabetManager.SetLetterList();
        ButtonClickAction();

        Debug.Log("LetterManager initialize");
    }

    private void OnEnable()
    {
        currentLetterIndex = alphabetManager.currentLetterIndex;

        letterText.text = letters[currentLetterIndex];
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
