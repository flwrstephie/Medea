using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthAnim : MonoBehaviour
{
    public ScoreTracker score;
    public Animator heart5;
    public Animator heart4;
    public Animator heart3;
    public Animator heart2;
    public Animator heart1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(score.hp == 5)
        {
            heart5.SetBool("Alive", true);
            heart4.SetBool("Alive", true);
            heart3.SetBool("Alive", true);
            heart2.SetBool("Alive", true);
            heart1.SetBool("Alive", true);
        }
        else if(score.hp == 4)
        {
            heart5.SetBool("Alive", false);
            heart4.SetBool("Alive", true);
            heart3.SetBool("Alive", true);
            heart2.SetBool("Alive", true);
            heart1.SetBool("Alive", true);
        }
        else if (score.hp == 3)
        {
            heart5.SetBool("Alive", false);
            heart4.SetBool("Alive", false);
            heart3.SetBool("Alive", true);
            heart2.SetBool("Alive", true);
            heart1.SetBool("Alive", true);
        }
        else if (score.hp == 2)
        {
            heart5.SetBool("Alive", false);
            heart4.SetBool("Alive", false);
            heart3.SetBool("Alive", false);
            heart2.SetBool("Alive", true);
            heart1.SetBool("Alive", true);
        }
        else if (score.hp == 1)
        {
            heart5.SetBool("Alive", false);
            heart4.SetBool("Alive", false);
            heart3.SetBool("Alive", false);
            heart2.SetBool("Alive", false);
            heart1.SetBool("Alive", true);
        }
        else if (score.hp == 0)
        {
            heart5.SetBool("Alive", false);
            heart4.SetBool("Alive", false);
            heart3.SetBool("Alive", false);
            heart2.SetBool("Alive", false);
            heart1.SetBool("Alive", false);
        }
    }
}
