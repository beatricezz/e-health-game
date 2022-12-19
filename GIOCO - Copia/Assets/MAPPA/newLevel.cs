using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevel : MonoBehaviour
{   [SerializeField] RectTransform fader;
    [SerializeField] RectTransform button;
    [SerializeField] RectTransform button_inactive;
    [SerializeField] RectTransform txt1;
    [SerializeField] RectTransform txt2;
    [SerializeField] RectTransform txt3;
    private int i=0;
    private float t=0;
    public float t1=0;
    // Start is called before the first frame update
    void Start(){
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 2,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
        LeanTween.alpha (fader, 0,1f);
    }

    // Update is called once per frame
    void Update()
    {   
        if(t>=0.6){
         if(i==0){
         LeanTween.scale (button, new Vector3(5f,5f,1), 0.6f); 
         i=1;
         }

        else{
          LeanTween.scale (button, new Vector3(3f,3f,1), 0.6f);
          i=0;
        }
        t=0;
    }
    else{
        t+=Time.deltaTime;
    }
        if(t1>=1){
            fader.gameObject.SetActive (false);
            
            t1=0;
            t1=-1;
        }
        else if(t1>=0&&t1<1){
            t1+=Time.deltaTime;
            if(t1>=0.5f){
                button_inactive.gameObject.SetActive(true);
                txt1.gameObject.SetActive(true);
                txt2.gameObject.SetActive(true);
                txt3.gameObject.SetActive(true);
            }
        }
    }

    public void premuto(){
       button.gameObject.SetActive(false);
       button_inactive.gameObject.SetActive(false);
       txt1.gameObject.SetActive(false);
       txt2.gameObject.SetActive(false);
       txt3.gameObject.SetActive(false);
       LeanTween.alpha(button,0,0);
       fader.gameObject.SetActive (true);
       LeanTween.alpha (fader, 0,0);
       LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
       LeanTween.alpha (fader, 2,1f).setOnComplete(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);});
    
    }
}
