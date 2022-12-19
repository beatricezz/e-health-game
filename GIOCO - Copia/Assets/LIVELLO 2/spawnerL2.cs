using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerL2 : MonoBehaviour
{   
    public List<GameObject> mutants;
    public List<GameObject> animals;
    public GameObject green_circle;
    public GameObject red_circle;

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
            
            if (rand2>=4){
                    GameObject mutant=Instantiate(mutants[rand], new Vector3(12, -2f, 0), Quaternion.identity);
                    Instantiate(red_circle,new Vector3(12f,-1.13f,0),Quaternion.identity);

                    mutant.GetComponent<bottoni>().circ=0;
            }
            else{
                GameObject animal=Instantiate(animals[rand], new Vector3(12, -2f, 0), Quaternion.identity);
                Instantiate(green_circle,new Vector3(12f,-1.13f,0),Quaternion.identity);
                animal.GetComponent<bottoni>().circ=1;
            }
            
            t=0;
        }
        else{
            t+=Time.deltaTime;
        }
    }
    }
}
