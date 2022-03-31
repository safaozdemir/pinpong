using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score2 : MonoBehaviour
{
    public static int scoree2=0;
    Text Score22;
    // Start is called before the first frame update
    void Start()
    {
        Score22 =GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        Score22.text = ""+scoree2;
    }
}
