using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score;

    private Renderer myRender;

    // Start is called before the first frame update
    void Start()
    {
        myRender = GetComponent<Renderer>();
        CurrentScore.ScoreCurrent = score;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentScore.ScoreCurrent = score;
    }


    public void Scoreplayer(int scorepoint)
    {
        score += scorepoint;
        if (score < 0)
        {
            score = 0;
        }

        CurrentScore.ScoreCurrent = score;

    }



}

