using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{   [SerializeField] RectTransform fader;
    public GameObject play;
    public GameObject back;
    public float t=0;
    // Start is called before the first frame update
    void Start()
    {
        fader.gameObject.SetActive (true);
        LeanTween.alpha (fader, 2,0);
        LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
        LeanTween.alpha (fader, 0,1f);
    }

    // Update is called once per frame
    void Update()
    {
        t+=Time.deltaTime;
        if(t>=4){
            back.gameObject.SetActive(true);
            play.gameObject.SetActive(true);
        }
    }
}
