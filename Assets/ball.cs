using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject top;
    public Rigidbody2D rgb;
    public float speed;
    public Transform topKonum;
    public Transform Player1;
    public Transform Player2;

    void Start()
    {
        RandomPosition();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D Kale) 
    {
        if(Kale.name=="Player2Kale")
        {
            score.score1++;
        }
        if(Kale.name=="Player1Kale")
        {
            score2.scoree2++;
        }
        Restart();
    }
    public void Restart()
    {
        Player1.position=new Vector3(Player1.position.x,Player1.position.y,0);
        Player2.position=new Vector3(Player2.position.x,Player2.position.y,0);
        RandomPosition();

        topKonum.position=new Vector3(3,5,0);

    }
    public void RandomPosition(){
        float x=Random.Range(0,2)==0?-1:1;      
        float y=Random.Range(0,2)==0?-1:1;      
        rgb.position=new Vector3(3,5,0);
        rgb.velocity=new Vector2(x*speed,y*speed);
    }
}
