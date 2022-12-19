using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class characterName : MonoBehaviour
{   
    public static string word=null;
    int wordIndex=0;
    public Text myName=null;
    [SerializeField] RectTransform fader;
    // Start is called before the first frame update

    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 2)
            DoNotDestroy.instance.GetComponent<AudioSource>().Pause();
    }

    public void alphabetFunction(string alphabet)
    {   
        if(wordIndex<10){
            wordIndex++;
            word+=alphabet;
            myName.text=word;
         }
    }

    // Update is called once per frame
    public void DeleteCharacter()
    {   if(wordIndex>0){
        word=word.Remove(wordIndex-1);
        wordIndex--;
        myName.text=word;
    }
    }

    public void Confirmation(){
        if(wordIndex!=0){
            fader.gameObject.SetActive (true);
            LeanTween.alpha (fader, 0,0);
            LeanTween.scale (fader, new Vector3(25,25,1), 0f);
            myName.gameObject.SetActive(false);
            LeanTween.alpha(fader, 2, 1.5f).setOnComplete(()=>{SceneManager.LoadScene("Scenes/S8");});
            
        }
    }
}
