
using UnityEngine;

public class RotateSpawers : MonoBehaviour
{
    public float SPEED = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, SPEED, 0f));
    }
}
