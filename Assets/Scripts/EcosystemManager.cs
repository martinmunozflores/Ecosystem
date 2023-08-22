using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EcosystemManager : MonoBehaviour
{
    public float start_rabbit;
    public float start_fox;
    public float start_grass;
    public float ratio_grass = 0.95f;

    public GameObject Rabbit;
    public GameObject Fox;
    public GameObject Grass;


    // Start is called before the first frame update
    void Start()
    {
        // Spawn 20 Foxes at random positions and random rotations
        for (int i = 0; i < start_fox; i++)
        {
            Instantiate(Fox, new Vector3(Random.Range(-50f, 50f), 1, Random.Range(-50f, 50f)), Quaternion.Euler(0, Random.Range(0f, 360f), 0));
        }

        // Spawn 20 Rabbits at random positions and random rotations
        for (int i = 0; i < start_rabbit; i++)
        {
            Instantiate(Rabbit, new Vector3(Random.Range(-50f, 50f), 1, Random.Range(-50f, 50f)), Quaternion.Euler(0, Random.Range(0f, 360f), 0));
        }

        for (int i = 0; i < start_grass; i++){
            // grass puede no tener rotacion.
            Instantiate(Grass, new Vector3(Random.Range(-50f, 50f), 1, Random.Range(-50f, 50f)), Quaternion.Euler(0, Random.Range(0f, 360f), 0));
        }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
