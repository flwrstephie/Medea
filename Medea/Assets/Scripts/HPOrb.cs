using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPOrb : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreTracker score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger && other.CompareTag("Player"))
        {
            if (score.hp >= 5)
            {
                Destroy(gameObject);
            }
            else if(score.hp < 5)
            {
                score.hp++;
                Destroy(gameObject);
            }
        }
    }
}
