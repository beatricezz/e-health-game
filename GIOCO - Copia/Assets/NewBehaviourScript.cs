using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   public float t;
    // Start is called before the first frame update
    void Start()
    {
        t=0;
    }

    // Update is called once per frame
    public void cazzo(int op)
    {  if(op==0){  
        t+=4;}
    }
      
    }

