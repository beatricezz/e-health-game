using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Confirm : MonoBehaviour
{   [SerializeField] RectTransform fader;
    private float t=0;
    int c=0;
    public string nome=null;
    // Start is called before the first frame update
    void Start()
    {
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 2,0);
        LeanTween.scale (fader, new Vector3(25,25,1), 0f); 
        LeanTween.alpha (fader, 0,1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        t+=Time.deltaTime;
        if(t>=1.5&&c==0){
            fader.gameObject.SetActive (false);
            c=1;
        }
    }

    public void Confirmation(string text){
        nome=text;
        if (nome.Length != 0)
        {
            SceneManager.LoadScene(0);
        } 
        
    }
}
