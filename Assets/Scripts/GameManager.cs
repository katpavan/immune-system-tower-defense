using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    public void InvaderReachedThroat()
    {        
        this.lives--;

        if (this.lives <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        this.lives = 3;
        this.score = 0;
    }
}
