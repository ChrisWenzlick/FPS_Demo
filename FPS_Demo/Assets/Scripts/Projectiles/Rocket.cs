using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed = 2000.0f;

    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision c)
    {
        // Instantiate the explosion
        // Note: the explosion is not destroyed after finishing, and the rocket appears
        // to collide with the player when fired below a certain angle; fix both prior
        // to using in a full game
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
