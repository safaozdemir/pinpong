using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float movementSpeed=3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 movement=new Vector3(Input.GetAxis("Horizontal"),0,0);

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1*Time.deltaTime*movementSpeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
           transform.position += new Vector3(Time.deltaTime*movementSpeed, 0, 0);

        }
        //transform.position+=movement*Time.deltaTime*movementSpeed;
    }
}
