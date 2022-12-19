using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

[RequireComponent(typeof(Slider))]
public class MessySlider : MonoBehaviour
{
   
    public AudioMixer mixer;
    public string volumeName;
    
    
    public void UpdateValueOnChange(float value)
    {
      
        mixer.SetFloat(volumeName, Mathf.Log(value) * 20f);

    }

}
