using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCherry : MonoBehaviour
{
    public GameObject cherryPrefab;
    public float respawnTime = 10.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(cherryWave());
    }
    private void spawnCherry()
    {
        GameObject a = Instantiate(cherryPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x-6, screenBounds.y+1);
    }

    IEnumerator cherryWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCherry();
        }
    }

}
