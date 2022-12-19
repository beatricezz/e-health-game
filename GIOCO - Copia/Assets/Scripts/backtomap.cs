using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtomap : MonoBehaviour
{   public RectTransform fader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void back()
    {
         fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 0,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f);
        LeanTween.alpha (fader, 2,1.5f).setOnComplete(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);});
    }

    public void LoadLevel(){
       fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 0,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f);
        LeanTween.alpha (fader, 2,1.5f).setOnComplete(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}); 
    }
}
