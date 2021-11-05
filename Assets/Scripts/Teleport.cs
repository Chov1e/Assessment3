using UnityEngine;
public class Teleport : MonoBehaviour
{
    public Transform Destination;
    public Transform player;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pac-student")
        {
            player.transform.position = Destination.transform.position;
        }
    }
}