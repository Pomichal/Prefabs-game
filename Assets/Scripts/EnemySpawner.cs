using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public Rigidbody cube;
    public float speed;

    public float spawnTime;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            for(int i = -1; i < 2; i++)
            {
                if(Random.Range(0,2) == 1)
                {
                    SpawnCube(new Vector3(3 * i, 0, 20));
                }
            }
            timer = spawnTime;
        }
    }

    void SpawnCube(Vector3 position)
    {
        Rigidbody rb = Instantiate(cube, position, Quaternion.identity);
        rb.AddForce(Vector3.back * speed);
    }
}
