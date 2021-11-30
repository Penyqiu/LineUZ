using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{

    [SerializeField] string volumeParameter = "volume";
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider slider;
    private float multiplier = 20f;
    
    void Awake()
    {
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void HandleSliderValueChanged(float value)
    {
        mixer.SetFloat(volumeParameter, Mathf.Log10(value) * multiplier);
    }

    private void onDisable()
    {
        PlayerPrefs.SetFloat(volumeParameter, slider.value);
    }
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(volumeParameter, slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
