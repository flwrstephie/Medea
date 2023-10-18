using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpTracker : MonoBehaviour
{
    public ScoreTracker score;
    public PlayerMovement medea;
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
        if(score.score >= 13000)
        {
            medea.spawnDelay = 0.33f;
            medea.shootForce = 17;
            medea.moveSpeed = 8;
            score.scoreIncrementInterval = 0.5f;
        }
        if (score.score >= 26000)
        {
            medea.spawnDelay = 0.17f;
            medea.shootForce = 15;
            medea.moveSpeed = 10;
            score.scoreIncrementInterval = 0.33f;
        }
    }
}
