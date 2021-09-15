using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject target;
    public float speed = 0f;

    [System.Obsolete]
    private void FixedUpdate()
    {
            float r = target.transform.rotation.y;
       
            Vector3 b = target.transform.position - new Vector3(0,0,2);
     
        Vector3 a = transform.position;
        
        transform.position = Vector3.Lerp(a, b, speed);
        
        

    }
   
   
}
