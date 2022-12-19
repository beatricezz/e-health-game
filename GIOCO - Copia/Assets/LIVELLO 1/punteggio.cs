using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class punteggio : MonoBehaviour
{   public static int tot=0;
    public static int missed=0;

    public static List<int> correct=new List<int>();
    public static List<int> wrong=new List<int>();
    public static List<float> results=new List<float>();

    public int s=0;
    public int k=0;
    public static int yes;
    public static int no;
    public Text score=null;
    public Text miss=null;
    [SerializeField] RectTransform fader;
    // Start is called before the first frame update
    void Start(){
       fader.gameObject.SetActive (true);
       LeanTween.alpha (fader, 2,0);
       LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
       LeanTween.alpha (fader, 0,0.5f);
    }
    
    void Update()
    {
        score.text=tot.ToString();
        miss.text=missed.ToString();
        s=tot;
        k=missed;

        if(Timer.clock>=1&&Timer.clock<45){
           fader.gameObject.SetActive (false); 
        }
        else if(Timer.clock>=45){
           fader.gameObject.SetActive (true);
           LeanTween.alpha (fader, 0,0);
           LeanTween.scale (fader, new Vector3(30,30,1), 0f);

           //yes=tot;
           //no=missed;
           //score.text=tot.ToString();
           //miss.text=missed.ToString();
           Timer.clock=0;
           //LeanTween.alpha (fader, 2,1f).setOnComplete(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);});
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
