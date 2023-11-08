using UnityEngine;
using UnityEngine.UI;

public class LetterManager : MonoBehaviour
{
    [SerializeField] private Button closeLetterButton;
    [SerializeField] private GameObject letterPanel;
    [SerializeField] private Text letterText;

    [SerializeField] private string[] letters;
    [SerializeField] private GameObject[] lettersImages;

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

        for (int i = 0; i < lettersImages.Length; i++)
        {
            if (i == currentLetterIndex)
            {
                lettersImages[i].SetActive(true);
            }
            else
            {
                lettersImages[i].SetActive(false);
            }
        }
    }

    private void ButtonClickAction()
    {
        if (closeLetterButton != null)
        {
            closeLetterButton.onClick.RemoveAllListeners();
            closeLetterButton.onClick.AddListener(() =>
            {
                StartCoroutine(animations.CloseLetterPanelAnimationCO(letterPanel));
            });
        }
    }
}
