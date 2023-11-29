using UnityEngine;
using Plugins.Audio.Core;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private SourceAudio sourceSounds;
    [SerializeField]
    private SourceAudio sourceMusic;

    public Sound[] sounds;

    public static AudioManager instance;

    private void Awake()
    {
        #region Singleton

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        #endregion

        SetVolume();

        foreach (Sound s in sounds)
        {
            if (s.name == "Theme")
            {
                s.source = sourceMusic;

                sourceMusic.Loop = s.loop;

                sourceMusic.Volume = s.volume = PlayerPrefs.GetFloat("MusicVolume");
            }
            else
            {
                continue;
            }
        }
    }

    private void Start()
    {
        sourceMusic.Play("Theme");

        foreach (Sound s in sounds)
        {
            if (s.name == "Theme")
            {
                continue;
            }
            else
            {
                s.source = sourceSounds;

                sourceSounds.Loop = s.loop;

                sourceSounds.Volume = s.volume = PlayerPrefs.GetFloat("SoundVolume");
            }
        }
    }

    public void Play(string name)
    {
        sourceSounds.Play(name);
    }

    private void SetVolume()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1f);
        }

        if (!PlayerPrefs.HasKey("SoundVolume"))
        {
            PlayerPrefs.SetFloat("SoundVolume", 1f);
        }
    }

    public void OffMusic()
    {
        PlayerPrefs.SetFloat("MusicVolume", 0f);

        foreach (Sound s in sounds)
        {
            if (s.name == "Theme")
            {
                s.source.Volume = s.volume = PlayerPrefs.GetFloat("MusicVolume");
            }
        }
    }

    public void OnMusic()
    {
        PlayerPrefs.SetFloat("MusicVolume", 1f);

        foreach (Sound s in sounds)
        {
            if (s.name == "Theme")
            {
                s.source.Volume = s.volume = PlayerPrefs.GetFloat("MusicVolume");
            }
        }
    }

    public void OffSound()
    {
        PlayerPrefs.SetFloat("SoundVolume", 0f);

        foreach (Sound s in sounds)
        {
            if (s.name == "Theme")
            {
                continue;
            }
            else
            {
                s.source.Volume = s.volume = PlayerPrefs.GetFloat("SoundVolume");
            }
        }
    }

    public void OnSound()
    {
        PlayerPrefs.SetFloat("SoundVolume", 1f);

        foreach (Sound s in sounds)
        {
            if (s.name == "Theme")
            {
                continue;
            }
            else
            {
                s.source.Volume = s.volume = PlayerPrefs.GetFloat("SoundVolume");
            }
        }
    }
}
