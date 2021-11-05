using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pacdot : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private BoxCollider2D _boxCollider2D;
    public int score;
    private PlayerScore playerScore;
    public AudioSource aAudio;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
        playerScore = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScore>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")

        {
            playerScore.Scoreplayer(score);
            _spriteRenderer.enabled = false;
            _boxCollider2D.enabled = false;
            Destroy(gameObject);
            aAudio.Play();
        }
    }
}

