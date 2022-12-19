using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomCamera : MonoBehaviour
{   Camera cam;
    public double zoom;
    public float startTime=0;
    public float delta;
    // Start is called before the first frame update
    public void Awake()
    {   
        cam=Camera.main;
        zoom=(float)cam.orthographicSize;
    }

    // Update is called once per frame
    public void Update()
    {  delta=Time.deltaTime;
       startTime+=delta;
       
       if(startTime>5&&zoom>1.5){
        zoom = zoom - 0.01;
        cam.orthographicSize=(float)zoom;
       }

  
    }
    
}
