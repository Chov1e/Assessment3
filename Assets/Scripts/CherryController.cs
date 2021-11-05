using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public Transform wayPoint01;
    private Transform wayPointTarget;
    [SerializeField] private float moveSpeed;

    private Vector2 screenBounds;
    private Rigidbody2D rb;

    public AudioSource cherryAudio;


    private void Start()
    {
        wayPointTarget = wayPoint01;
        rb = this.GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPointTarget.position, moveSpeed * Time.deltaTime);

        if(transform.position.x < -9.0f)
        {
            Destroy(this.gameObject);
        }
    }


}
