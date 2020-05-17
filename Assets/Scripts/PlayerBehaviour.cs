using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public Rigidbody sphere;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            SpawnSphere(new Vector3(-3, 0, 0));
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnSphere(new Vector3(0, 0, 0));
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            SpawnSphere(new Vector3(3, 0, 0));
        }
    }

    void SpawnSphere(Vector3 position)
    {
            Rigidbody rb = Instantiate(sphere, position, Quaternion.identity);
            rb.AddForce(Vector3.forward * speed);
    }
}
