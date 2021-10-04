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

    private void Start()
    {
        wayPointTarget = wayPoint01;
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
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pac-man")
        {
            Destroy(co.gameObject);
            deathAudio.Play();
        }
    }

}
