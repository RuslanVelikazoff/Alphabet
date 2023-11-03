using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private Button openSettingsButton;
    [SerializeField] private Button closeSettingsButton;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject mainPanel;

    [Space(7)]

    [SerializeField] private Button musicButton;
    [SerializeField] private Button soundButton;
    [SerializeField] private Sprite onSprite;
    [SerializeField] private Sprite offSprite;

    private UIAnimations animations;

    public void Initialize(UIAnimations UIAnimations)
    {
        animations = UIAnimations;

        SetSprites();

        ButtonClickAction();

        Debug.Log("SettingsManager initialized");
    }

    private void ButtonClickAction()
    {
        if (openSettingsButton != null && settingsPanel != null)
        {
            openSettingsButton.onClick.RemoveAllListeners();
            openSettingsButton.onClick.AddListener(() =>
            {
                animations.ButtonClickAnimation(openSettingsButton);
                animations.OpenSettingsPanelAnimation(settingsPanel);
            });
        }

        if (closeSettingsButton != null && settingsPanel != null)
        {
            closeSettingsButton.onClick.RemoveAllListeners();
            closeSettingsButton.onClick.AddListener(() =>
            {
                animations.CloseSettingsPanelAnimation(settingsPanel);
            });
        }

        if (musicButton != null)
        {
            musicButton.onClick.RemoveAllListeners();
            musicButton.onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetFloat("MusicVolume") == 1)
                {
                    AudioManager.instance.OffMusic();
                }
                else
                {
                    AudioManager.instance.OnMusic();
                }

                SetSprites();
            });
        }

        if (soundButton != null)
        {
            soundButton.onClick.RemoveAllListeners();
            soundButton.onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetFloat("SoundVolume") == 1)
                {
                    AudioManager.instance.OffSound();
                }
                else
                {
                    AudioManager.instance.OnSound();
                }

                SetSprites();
            });
        }
    }

    private void SetSprites()
    {
        if (PlayerPrefs.GetFloat("MusicVolume") == 0)
        {
            musicButton.GetComponent<Image>().sprite = offSprite;
        }

        else if (PlayerPrefs.GetFloat("MusicVolume") == 1)
        {
            musicButton.GetComponent<Image>().sprite = onSprite;
        }

        if (PlayerPrefs.GetFloat("SoundVolume") == 0)
        {
            soundButton.GetComponent<Image>().sprite = offSprite;
        }

        else if (PlayerPrefs.GetFloat("SoundVolume") == 1)
        {
            soundButton.GetComponent<Image>().sprite = onSprite;
        }
    }
}
