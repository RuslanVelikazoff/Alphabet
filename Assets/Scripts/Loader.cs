using UnityEngine;

public class Loader : MonoBehaviour
{
    [SerializeField] private AlphabetManager alphabetManager;
    [SerializeField] private LetterManager letterManager;
    [SerializeField] private SettingsManager settingsManager;
    [SerializeField] private DeleteAdds deleteAdds;

    private UIAnimations AnimationsUI = new UIAnimations();

    private void Start()
    {
        alphabetManager.Initialize(AnimationsUI);
        letterManager.Initialize(alphabetManager, AnimationsUI);
        settingsManager.Initialize(AnimationsUI);
        deleteAdds.Initialize();
    }
}
