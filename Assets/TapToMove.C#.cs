using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = System.Numerics.Vector3;

public class TapToMove : MonoBehaviour
{
    float mspd = 1f;
    Rigidbody2D rb;
  
      void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     
        
      }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.position = rb.position;
            Vector2 mousePos = Input.mousePosition; //The postion mouse location equals the input
            rb.MovePosition(mousePos); //move the position
            Vector2.Lerp(rb.position,mousePos, mspd); // where are u pressing
            rb.position = Vector2.Lerp(rb.position, Camera.main.ScreenToWorldPoint(mousePos), Time.deltaTime * mspd);
            
        }
    
        
    }
  
}



