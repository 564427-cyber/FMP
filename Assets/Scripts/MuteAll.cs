using UnityEngine;
using UnityEngine.Audio;

public class MuteAll : MonoBehaviour
{
    public AudioMixer audioMixer;

    private bool muted = false;

    public void ToggleMute()
    {
        if (muted)
        {
            audioMixer.SetFloat("MasterVolume", 0f);
        }
        else
        {
            audioMixer.SetFloat("MasterVolume", -80f);
        }

        muted = !muted;
    }
}
