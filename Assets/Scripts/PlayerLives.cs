using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int lives;

    private Renderer myRender;


    // Start is called before the first frame update
    void Start()
    {
        myRender = GetComponent<Renderer>();
        CurrentLives.LivesCurrent = lives;

    }

    // Update is called once per frame
    void Update()
    {
        CurrentLives.LivesCurrent = lives;
    }


    public void Damageplayer(int damage)
    {
        lives -= damage;
        if (lives < 0)
        {
            lives = 0;
        }


        if (lives > 3)
        {
            lives = 3;
        }

        CurrentLives.LivesCurrent = lives;

        if (lives <= 0)
        {
            GameOver();
        }

    }

    void GameOver()
    {
        GameObject gameOverParent = GameObject.Find("HUD");
        GameObject gameOver = gameOverParent.transform.Find("DeathPanel").gameObject;
        gameOver.SetActive(true);
        AudioListener.pause = true;
        Time.timeScale = 0;
    }

}
