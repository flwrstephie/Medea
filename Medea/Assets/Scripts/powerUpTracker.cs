using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpTracker : MonoBehaviour
{
    public ScoreTracker score;
    public PlayerMovement medea;
    public Scroller scroll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rateOfFire();
    }

    void rateOfFire()
    {
        if(score.score >= 10000 && score.score < 23000)
        {
            medea.spawnDelay = 0.25f;
            medea.shootForce = 17;
            medea.moveSpeed = 8;
            score.scoreIncrementInterval = 0.75f;
            fallDown.setSpeed(3f);
            scroll.setY(0.308f);
        }
        else if (score.score >= 23000 && score.score < 36000)
        {
            medea.spawnDelay = 0.17f;
            medea.shootForce = 15;
            medea.moveSpeed = 10;
            score.scoreIncrementInterval = 0.65f;
        }
        else if (score.score >= 36000 && score.score < 50000)
        {
            medea.spawnDelay = 0.10f;
            medea.shootForce = 15;
            medea.moveSpeed = 12;
            score.scoreIncrementInterval = 0.55f;
            fallDown.setSpeed(4f);
            scroll.setY(0.410f);
        }
        else if (score.score >= 50000 && score.score < 70000)
        {
            medea.spawnDelay = 0.075f;
            medea.moveSpeed = 15;
        }
        else if (score.score >= 70000 && score.score < 100000)
        {
            medea.spawnDelay = 0.066f;
            medea.moveSpeed = 16.5f;
            fallDown.setSpeed(5f);
            scroll.setY(0.513f);
        }
        else if (score.score >= 100000 && score.score < 150000)
        {
            medea.spawnDelay = 0.049f;
            medea.moveSpeed = 18.0f;
        }
        else if (score.score >= 150000)
        {
            medea.spawnDelay = 0.033f;
            medea.moveSpeed = 22.0f;
        }
    }
}
