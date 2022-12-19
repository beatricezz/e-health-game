using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class bottoni : MonoBehaviour, IPointerDownHandler
{
    public float t=0;
    public GameObject animal;
    public int circ;
    public int pressed;
    
    void Start()
    {
         AddPhysics2DRaycaster();

    }
 
    void Update(){
        if(circ==1){
        Vector2 pos=animal.transform.position;

        if(pos.x<-10.5f&&t==0&&Timer.clock<45){
            punteggio.missed+=1;
            t=1;
        }
        }
    }

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {   if(Timer.clock<45&&pressed==0){
        if(circ==1){
            punteggio.tot+=1;}
        else{
            punteggio.missed+=1;
        }
        
        t=1;
        pressed=1;}
    }

    private void AddPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }
}

