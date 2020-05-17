using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    public float destroyPosition;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
