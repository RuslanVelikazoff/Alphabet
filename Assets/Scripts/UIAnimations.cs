using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIAnimations
{
    [Header("Settings Panel")]
    private Vector3 settingsPanelPosition = new Vector3(0, 15.15f, 90f);
    private Vector3 mainPanelPosition = new Vector3(0, 0, 90f);


    #region SettingsPanel

    public void OpenSettingsPanelAnimation(GameObject panel)
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(panel.transform.DOMove(mainPanelPosition, .6f))
            .Join(panel.transform.DOScale(new Vector3(.8f, .8f, 1f), .3f))
            .Append(panel.transform.DOScale(new Vector3(1f, 1f, 1f), .3f));
    }

    public void CloseSettingsPanelAnimation(GameObject panel)
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(panel.transform.DOScale(new Vector3(.8f, .8f, 1f), .3f))
            .Append(panel.transform.DOMove(settingsPanelPosition, .6f))
            .Append(panel.transform.DOScale(new Vector3(1f, 1f, 1f), .3f));
    }

    public void ButtonClickAnimation(Button button)
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(button.transform.DOScale(new Vector3(.8f, .8f, 1f), .3f))
            .Append(button.transform.DOScale(new Vector3(1f, 1f, 1f), .3f));
    }

    #endregion

    #region LetterPanel
    //TODO: add normal animation
    public void OpenLetterPanelAnimation(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void CloseLetterPanelAnimation(GameObject panel)
    {
        panel.SetActive(false);
    }

    #endregion
}
