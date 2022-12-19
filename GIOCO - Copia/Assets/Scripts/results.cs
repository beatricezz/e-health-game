using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class results : MonoBehaviour
{   public Text L1yes;
    public Text L2yes;
    public Text L3yes;
    public Text L1no;
    public Text L2no;
    public Text L3no;
    [SerializeField] RectTransform fader;
    public List<GameObject> stars;
    // Start is called before the first frame update
    void Start()
    {   
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 2,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
        LeanTween.alpha (fader, 0,2f);
        L1yes.text=punteggio.correct[0].ToString();
        L2yes.text=punteggio.correct[1].ToString();
        L3yes.text=punteggio.correct[2].ToString();
        L1no.text=punteggio.wrong[0].ToString();
        L2no.text=punteggio.wrong[1].ToString();
        L3no.text=punteggio.wrong[2].ToString();

        if(punteggio.results[0]>=0.85){
            stars[0].gameObject.SetActive(true);
            stars[1].gameObject.SetActive(true);
            stars[2].gameObject.SetActive(true);
        }
        else if(punteggio.results[0]>=0.6&&punteggio.results[0]<0.85){
            stars[0].gameObject.SetActive(true);
            stars[1].gameObject.SetActive(true);
        }
        else if(punteggio.results[0]<0.6){
            stars[0].gameObject.SetActive(true);
        }

        if(punteggio.results[1]>=0.85){
            stars[3].gameObject.SetActive(true);
            stars[4].gameObject.SetActive(true);
            stars[5].gameObject.SetActive(true);
        }
        else if(punteggio.results[1]>=0.6&&punteggio.results[1]<0.85){
            stars[3].gameObject.SetActive(true);
            stars[4].gameObject.SetActive(true);
        }
        else if(punteggio.results[1]<0.6){
            stars[3].gameObject.SetActive(true);
        }

        if(punteggio.results[2]>=0.85){
            stars[6].gameObject.SetActive(true);
            stars[7].gameObject.SetActive(true);
            stars[8].gameObject.SetActive(true);
        }
        else if(punteggio.results[2]>=0.6&&punteggio.results[2]<0.85){
            stars[6].gameObject.SetActive(true);
            stars[7].gameObject.SetActive(true);
        }
        else if(punteggio.results[2]<0.6){
            stars[6].gameObject.SetActive(true);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
