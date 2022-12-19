using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner2 : MonoBehaviour
{
    
    public List<GameObject> animals;
    public GameObject circle;

    public RectTransform par;
    public float t=0;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if(Timer.clock<45){
        if(t>=3){
            int rand=Random.Range(0,animals.Count);
            int rand2=Random.Range(0,8);
            GameObject animal=Instantiate(animals[rand], new Vector3(16, -3, 0), Quaternion.identity);
            
            if (rand2>=4){
                    Instantiate(circle,new Vector3(16,-2.13f,0),Quaternion.identity);

                    animal.GetComponent<bottoni>().circ=1;
            }
            else{
                animal.GetComponent<bottoni>().circ=0;
            }
            
            t=0;
        }
        else{
            t+=Time.deltaTime;
        }
    }
    }
}
