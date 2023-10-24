using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthAnim : MonoBehaviour
{
    public ScoreTracker score;
    private bool hp5;
    private bool hp4;
    private bool hp3;
    private bool hp2;
    private bool hp1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(score.hp == 5)
        {
            hp5 = true;
            hp4 = false;
            hp3 = false;
            hp2 = false;
            hp1 = false;
        }
        else if(score.hp == 4)
        {
            hp5 = false;
            hp4 = true;
            hp3 = false;
            hp2 = false;
            hp1 = false;
        }
        else if (score.hp == 3)
        {
            hp5 = false;
            hp4 = false;
            hp3 = true;
            hp2 = false;
            hp1 = false;
        }
        else if (score.hp == 2)
        {
            hp5 = false;
            hp4 = false;
            hp3 = false;
            hp2 = true;
            hp1 = false;
        }
        else if (score.hp == 1)
        {
            hp5 = false;
            hp4 = false;
            hp3 = false;
            hp2 = false;
            hp1 = true;
        }
    }
}
