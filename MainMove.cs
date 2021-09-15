using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMove : MonoBehaviour
{
    

    
    public float Speed;
    public float sss;
  
    void Start()
    {
     
    }

    // Update is called once per frame

    [System.Obsolete]
    void FixedUpdate()
    {
        MoveZ();
        transform.rotation.Normalize();
        Vector3 pos = transform.position;
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        transform.Translate(h, 0f, v);
        //if (Input.GetKey(KeyCode.D)) { 
        //    transform.Rotate(new Vector3(0f, Mathf.Lerp(this.transform.rotation.y, 50, 30), 0f), sss * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.A)) {
        //    transform.Rotate(new Vector3(0f, Mathf.Lerp(this.transform.rotation.y, -50, 30), 0f), sss * Time.deltaTime);
        //}
        if(Input.GetAxis("Horizontal") != 0)
        {
            this.transform.Rotate(Vector3.up * sss * Time.deltaTime * Input.GetAxis("Horizontal"));
           //transform.rotation = Quaternion.EulerRotation (0f, h, 0f);
        }
    }
    void MoveZ()
    {
        transform.rotation.Normalize();
        Vector3 pos = transform.position;
        pos.z =+ 5f * Time.deltaTime * Speed;
      
        transform.Translate(0f, 0f, pos.z);
    }
}
