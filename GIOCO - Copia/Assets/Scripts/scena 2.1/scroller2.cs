using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroller2 : MonoBehaviour
{   float speed=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*(speed*Time.deltaTime));
    }
}
