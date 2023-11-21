using UnityEngine;
using UnityEngine.UI;

public class AlphabetManager : MonoBehaviour
{
    [SerializeField] private Button[] letterButton;
    [SerializeField] public GameObject letterImages;
    [SerializeField] private GameObject letterPanel;

    [HideInInspector]public int currentLetterIndex = 0;

    private UIAnimations animations;

    public void Initialize(UIAnimations uIAnimations)
    {
        animations = uIAnimations;

        ButtonClickAction();

        Debug.Log("AlphabetManager initialized");
    }

    public string[] SetLetterList()
    {
        string[] allLetters = new string[letterButton.Length];

        for (int i = 0; i < allLetters.Length; i++)
        {
            allLetters[i] = letterButton[i].name;
        }

        return allLetters;
    }

    private void ButtonClickAction()
    {
        //А
        if (letterButton[0] != null)
        {
            letterButton[0].onClick.RemoveAllListeners();
            letterButton[0].onClick.AddListener(() =>
            {
                currentLetterIndex = 0;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Б
        if (letterButton[1] != null)
        {
            letterButton[1].onClick.RemoveAllListeners();
            letterButton[1].onClick.AddListener(() =>
            {
                currentLetterIndex = 1;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //В
        if (letterButton[2] != null)
        {
            letterButton[2].onClick.RemoveAllListeners();
            letterButton[2].onClick.AddListener(() =>
            {
                currentLetterIndex = 2;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Г
        if (letterButton[3] != null)
        {
            letterButton[3].onClick.RemoveAllListeners();
            letterButton[3].onClick.AddListener(() =>
            {
                currentLetterIndex = 3;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Д
        if (letterButton[4] != null)
        {
            letterButton[4].onClick.RemoveAllListeners();
            letterButton[4].onClick.AddListener(() =>
            {
                currentLetterIndex = 4;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Е
        if (letterButton[5] != null)
        {
            letterButton[5].onClick.RemoveAllListeners();
            letterButton[5].onClick.AddListener(() =>
            {
                currentLetterIndex = 5;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ё
        if (letterButton[6] != null)
        {
            letterButton[6].onClick.RemoveAllListeners();
            letterButton[6].onClick.AddListener(() =>
            {
                currentLetterIndex = 6;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ж
        if (letterButton[7] != null)
        {
            letterButton[7].onClick.RemoveAllListeners();
            letterButton[7].onClick.AddListener(() =>
            {
                currentLetterIndex = 7;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //З
        if (letterButton[8] != null)
        {
            letterButton[8].onClick.RemoveAllListeners();
            letterButton[8].onClick.AddListener(() =>
            {
                currentLetterIndex = 8;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //И
        if (letterButton[9] != null)
        {
            letterButton[9].onClick.RemoveAllListeners();
            letterButton[9].onClick.AddListener(() =>
            {
                currentLetterIndex = 9;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Й
        if (letterButton[10] != null)
        {
            letterButton[10].onClick.RemoveAllListeners();
            letterButton[10].onClick.AddListener(() =>
            {
                currentLetterIndex = 10;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //К
        if (letterButton[11] != null)
        {
            letterButton[11].onClick.RemoveAllListeners();
            letterButton[11].onClick.AddListener(() =>
            {
                currentLetterIndex = 11;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Л
        if (letterButton[12] != null)
        {
            letterButton[12].onClick.RemoveAllListeners();
            letterButton[12].onClick.AddListener(() =>
            {
                currentLetterIndex = 12;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //М
        if (letterButton[13] != null)
        {
            letterButton[13].onClick.RemoveAllListeners();
            letterButton[13].onClick.AddListener(() =>
            {
                currentLetterIndex = 13;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Н
        if (letterButton[14] != null)
        {
            letterButton[14].onClick.RemoveAllListeners();
            letterButton[14].onClick.AddListener(() =>
            {
                currentLetterIndex = 14;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //О
        if (letterButton[15] != null)
        {
            letterButton[15].onClick.RemoveAllListeners();
            letterButton[15].onClick.AddListener(() =>
            {
                currentLetterIndex = 15;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //П
        if (letterButton[16] != null)
        {
            letterButton[16].onClick.RemoveAllListeners();
            letterButton[16].onClick.AddListener(() =>
            {
                currentLetterIndex = 16;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Р
        if (letterButton[17] != null)
        {
            letterButton[17].onClick.RemoveAllListeners();
            letterButton[17].onClick.AddListener(() =>
            {
                currentLetterIndex = 17;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //С
        if (letterButton[18] != null)
        {
            letterButton[18].onClick.RemoveAllListeners();
            letterButton[18].onClick.AddListener(() =>
            {
                currentLetterIndex = 18;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Т
        if (letterButton[19] != null)
        {
            letterButton[19].onClick.RemoveAllListeners();
            letterButton[19].onClick.AddListener(() =>
            {
                currentLetterIndex = 19;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //У
        if (letterButton[20] != null)
        {
            letterButton[20].onClick.RemoveAllListeners();
            letterButton[20].onClick.AddListener(() =>
            {
                currentLetterIndex = 20;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ф
        if (letterButton[21] != null)
        {
            letterButton[21].onClick.RemoveAllListeners();
            letterButton[21].onClick.AddListener(() =>
            {
                currentLetterIndex = 21;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Х
        if (letterButton[22] != null)
        {
            letterButton[22].onClick.RemoveAllListeners();
            letterButton[22].onClick.AddListener(() =>
            {
                currentLetterIndex = 22;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ц
        if (letterButton[23] != null)
        {
            letterButton[23].onClick.RemoveAllListeners();
            letterButton[23].onClick.AddListener(() =>
            {
                currentLetterIndex = 23;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ч
        if (letterButton[24] != null)
        {
            letterButton[24].onClick.RemoveAllListeners();
            letterButton[24].onClick.AddListener(() =>
            {
                currentLetterIndex = 24;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ш
        if (letterButton[25] != null)
        {
            letterButton[25].onClick.RemoveAllListeners();
            letterButton[25].onClick.AddListener(() =>
            {
                currentLetterIndex = 25;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Щ
        if (letterButton[26] != null)
        {
            letterButton[26].onClick.RemoveAllListeners();
            letterButton[26].onClick.AddListener(() =>
            {
                currentLetterIndex = 26;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ъ
        if (letterButton[27] != null)
        {
            letterButton[27].onClick.RemoveAllListeners();
            letterButton[27].onClick.AddListener(() =>
            {
                currentLetterIndex = 27;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ы
        if (letterButton[28] != null)
        {
            letterButton[28].onClick.RemoveAllListeners();
            letterButton[28].onClick.AddListener(() =>
            {
                currentLetterIndex = 28;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ь
        if (letterButton[29] != null)
        {
            letterButton[29].onClick.RemoveAllListeners();
            letterButton[29].onClick.AddListener(() =>
            {
                currentLetterIndex = 29;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Э
        if (letterButton[30] != null)
        {
            letterButton[30].onClick.RemoveAllListeners();
            letterButton[30].onClick.AddListener(() =>
            {
                currentLetterIndex = 30;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Ю
        if (letterButton[31] != null)
        {
            letterButton[31].onClick.RemoveAllListeners();
            letterButton[31].onClick.AddListener(() =>
            {
                currentLetterIndex = 31;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }

        //Я
        if (letterButton[32] != null)
        {
            letterButton[32].onClick.RemoveAllListeners();
            letterButton[32].onClick.AddListener(() =>
            {
                currentLetterIndex = 32;
                animations.OpenLetterPanelAnimation(letterPanel, letterImages);
            });
        }
    }
}
