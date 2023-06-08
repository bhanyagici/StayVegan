using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float runSpeed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float firstTouchX;
    

    // Update is called once per frame
    void Update()
    {
        

        Vector3 moveVector = new Vector3(runSpeed * Time.deltaTime, 0, 0);
        
        
        float different = 0;
        
        
        if (Input.GetMouseButtonDown(0))
        {
            
            firstTouchX = Input.mousePosition.x;


        }
        else if (Input.GetMouseButton(0))
        {
            //Hareket kodlarý
            
            float lastTouchX = Input.mousePosition.x;
            different = lastTouchX - firstTouchX;
            moveVector += new Vector3(0, 0, different * Time.deltaTime*-1);
            firstTouchX = lastTouchX;//Ýlk týklanan nokta son týklanan nokta olmuþtur


        }
        transform.position += moveVector;



        
        

    }
}
