using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImovement : MonoBehaviour
{   public RectTransform button;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = button.anchoredPosition;
        position.x -= speed * Time.deltaTime;
        button.anchoredPosition = position;
    }
}
