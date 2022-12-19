using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endTransition : MonoBehaviour
{   public float startTime=0;
    [SerializeField] RectTransform fader;
    float c=0;
    // Start is called before the first frame update
    void Start()
    {
        //startTime=0;
    }

    // Update is called once per frame
    void Update()
    {
        startTime+=Time.deltaTime;
           if(startTime>=10 && c==0){
            fader.gameObject.SetActive (true);
            LeanTween.alpha (fader, 0,0f);
            LeanTween.scale (fader, new Vector3(25,25,1), 0f);
            LeanTween.alpha (fader, 2,1f);
            c+=1;
           }
    }
}
