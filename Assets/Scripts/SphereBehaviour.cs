using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{

    public float destroyPosition;

    void Update()
    {
        if(transform.position.z > destroyPosition)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        Destroy(gameObject);
    }
}
