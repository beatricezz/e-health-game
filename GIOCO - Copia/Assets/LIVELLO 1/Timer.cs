using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{   [SerializeField] Text tempo;
    public static float clock;
    public int s=0;
    // Start is called before the first frame update
    void Start()
    {  clock=0;
    }

    // Update is called once per frame
    void Update()
    {
        clock+=Time.deltaTime;
        s=45-(int)clock;
        tempo.text=s.ToString();
        
    }
}
