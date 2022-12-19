using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{   float t=0;  
    [SerializeField] RectTransform fader;
    public GameObject skip;
    // Start is called before the first frame update
    void Start()
    {
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 2,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
        LeanTween.alpha (fader, 0,1f).setOnComplete(()=>{skip.gameObject.SetActive(true);});
    }

    // Update is called once per frame
    void Update()
    {
        t=t+Time.deltaTime;

        if(t>=7.5){
            fader.gameObject.SetActive (true);
            LeanTween.alpha (fader, 0,0);
            LeanTween.scale (fader, new Vector3(30,30,1), 0f);
            LeanTween.alpha (fader, 2,1f).setOnComplete(()=>{Invoke("loadscene",0f);});
                   
        }
    }

     public void loadscene(){
        SceneManager.LoadScene("Scenes/S4");
    }
}


