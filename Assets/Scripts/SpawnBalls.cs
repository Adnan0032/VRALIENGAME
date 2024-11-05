using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {


        InvokeRepeating("Spawn", 0.1f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        GameObject temp = Instantiate(ball, transform.forward + new Vector3(0f, 2f, 2f), Quaternion.identity);

        Destroy(temp, 5f);
    }
}
