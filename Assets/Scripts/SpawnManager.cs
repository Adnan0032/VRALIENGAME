using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject spawned;
    GameObject transformAt;

    // Start is called before the first frame update
    void Start()
    {
        

        InvokeRepeating("Spawn", 0.1f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        transformAt = this.transform.GetChild(2).gameObject;

        GameObject temp = Instantiate(spawned, transformAt.transform.position, Quaternion.identity);

    }
}
