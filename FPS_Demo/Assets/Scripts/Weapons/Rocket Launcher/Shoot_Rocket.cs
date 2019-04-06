using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Rocket : MonoBehaviour
{
    public GameObject rocketPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newRocket = (GameObject)Instantiate(rocketPrefab, transform.position, transform.parent.rotation);
            Physics.IgnoreCollision(GetComponent<Collider>(), newRocket.GetComponent<Collider>());
            float force = newRocket.GetComponent<Rocket>().speed;
            newRocket.GetComponent<Rigidbody>().AddForce(newRocket.transform.forward * force);
        }
    }
}
