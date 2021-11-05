using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public Transform wayPoint01, wayPoint02, wayPoint03, wayPoint04;
    private Transform wayPointTarget;
    [SerializeField] private float moveSpeed;

    public AudioSource deathAudio;
    private Animator animator;

    private SpriteRenderer _spriteRenderer;

    private BoxCollider2D _boxCollider2D;
    public int Lives;
    private PlayerLives playerLives;



    private void Start()
    {
        wayPointTarget = wayPoint01;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
        playerLives = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLives>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPointTarget.position, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, wayPoint01.position) < 0.01f)
        {
            wayPointTarget = wayPoint02;


            Vector3 localTemp = transform.localScale;
            localTemp.x *= -1;
            transform.localScale = localTemp;
        }

        if (Vector2.Distance(transform.position, wayPoint02.position) < 0.01f)
        {
            wayPointTarget = wayPoint01;

  
            Vector3 localTemp = transform.localScale;
            localTemp.x *= -1;
            transform.localScale = localTemp;
        }
    }

    //destroy player when collide
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")

        {
            playerLives.Damageplayer(Lives);
            other.gameObject.SetActive(false);        
            deathAudio.Play();
            StartCoroutine(Respawn(other.gameObject));
        }
    }

    IEnumerator Respawn(GameObject gObj)
    {
        yield return new WaitForSeconds(3);
        gObj.transform.position = new Vector3(-7.08f, 8.07f, 0f);
        gObj.SetActive(true);
    }
}