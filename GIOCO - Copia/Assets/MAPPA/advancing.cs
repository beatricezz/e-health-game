using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advancing : MonoBehaviour
{   public List<GameObject> points;
    public float t=0;
    private int i=0;
    [SerializeField] RectTransform red_button;
    [SerializeField] RectTransform yellow_button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t>=2&&i<points.Count){
            LeanTween.alpha(points[i],1,0.01f);
            t=1.5f;
            i+=1;
        }
        else{
            t+=Time.deltaTime;
        }

        if(i==points.Count&&t>=2){
            red_button.gameObject.SetActive(false);
            yellow_button.gameObject.SetActive(true);
        }
    }
}
