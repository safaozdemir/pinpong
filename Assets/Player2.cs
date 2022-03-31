using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float movementSpeed=3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1*Time.deltaTime*movementSpeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
           transform.position += new Vector3(Time.deltaTime*movementSpeed, 0, 0);

        }
    }
}
