using UnityEngine;

public class Loader : MonoBehaviour
{
    [SerializeField] private SettingsManager settingsManager;

    private void Start()
    {
        settingsManager.Initialize();
    }
}
