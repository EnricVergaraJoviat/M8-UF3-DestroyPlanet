using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives = 3;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        score++;
        Debug.Log("Score: "+score);
    }
    
    public void TakeDamage()
    {
        lives--;
        Debug.Log("Lives: "+lives);
    }
}
