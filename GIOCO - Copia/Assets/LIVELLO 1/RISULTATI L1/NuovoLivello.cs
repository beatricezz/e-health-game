using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuovoLivello : MonoBehaviour
{   public float esatto;
    public float errato;
    public GameObject continua;
    public GameObject retry;
    public GameObject button_continue;
    public GameObject button_retry;
    public GameObject one_star;
    public GameObject two_star;
    public GameObject three_star;
    public GameObject happy_owl;
    public GameObject sad_owl;
    public GameObject D_Box;
    public GameObject happy_text;
    public GameObject sad_text;
    
    public float result;
    public RectTransform fader;
    private float t=0;
    // Start is called before the first frame update
    void Start()
    {
       fader.gameObject.SetActive (true);
       LeanTween.alpha (fader, 2,0);
       LeanTween.scale (fader, new Vector3(25,25,1), 0f); 
       LeanTween.alpha (fader, 0,2f);
       esatto=(float)punteggio.tot;
       errato=(float)punteggio.missed;

       punteggio.tot=0;
       punteggio.missed=0;
       result=esatto/(esatto+errato);

        if(result>=0.85){
            continua.SetActive(true);
            retry.SetActive(false);
            button_continue.SetActive(true);
            button_retry.SetActive(false);
            one_star.SetActive(true);
            two_star.SetActive(true);
            three_star.SetActive(true);
            happy_owl.SetActive(true);
            //D_Box.SetActive(true);
            happy_text.SetActive(true);
            sad_text.SetActive(false);
            
        }
        else if((result<0.85) && (result>=0.6)){
            continua.SetActive(true);
            retry.SetActive(false);
            button_continue.SetActive(true);
            button_retry.SetActive(true);
            one_star.SetActive(true);
            two_star.SetActive(true);
            three_star.SetActive(false);
            happy_owl.SetActive(true);
            //D_Box.SetActive(true);
            happy_text.SetActive(true);
            sad_text.SetActive(false);
            
        } 
        else if(result<0.6){
            continua.SetActive(true);
            retry.SetActive(false);
            button_continue.SetActive(true);
            button_retry.SetActive(true);
            one_star.SetActive(true);
            two_star.SetActive(false);
            three_star.SetActive(false);
            happy_owl.SetActive(true);
            //D_Box.SetActive(true);
            happy_text.SetActive(true);
            sad_text.SetActive(false);
            
        }
    }

    // Update is called once per frame
    void Update()
    {   t+=Time.deltaTime;
        if(t>=1){
            fader.gameObject.SetActive (false);
            D_Box.gameObject.SetActive(true);
        }
    }

    public void NextLevel(){
        punteggio.correct.Add((int)esatto);
        punteggio.wrong.Add((int)errato);
        punteggio.results.Add(result);

        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 0,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f);
        LeanTween.alpha (fader, 2,1.5f).setOnComplete(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);});
    }
    public void RepeatLevel(){
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 0,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f);
        LeanTween.alpha (fader, 2,1.5f).setOnComplete(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);});

    }
}
