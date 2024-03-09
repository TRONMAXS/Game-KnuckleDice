using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class SoundStart : MonoBehaviour
{
    public Slider slidersound;
    public AudioSource soundsource;

    void Start()
    {
        if (PlayerPrefs.HasKey("ValueStart"))
        {
            slidersound.value = PlayerPrefs.GetFloat("ValueStart");
        }
    }
    void Update()
    {
        Value();
    }
    public void Value()
    {

        soundsource.volume = slidersound.value;
        PlayerPrefs.SetFloat("ValueStart",slidersound.value);
    }
}
