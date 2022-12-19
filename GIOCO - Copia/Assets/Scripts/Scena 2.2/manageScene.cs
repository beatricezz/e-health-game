using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manageScene : MonoBehaviour
{   public float t=0;
    int c=0;
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
       t+=Time.deltaTime;
       if(t>10 && c==0){
       fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 0,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
        LeanTween.alpha (fader, 2,1f).setOnComplete(()=>{Invoke("loadscene",0f);}); 
        c+=1;
       }
       
    }
    public void loadscene(){
        SceneManager.LoadScene("Scenes/S5");
    }
  
}

