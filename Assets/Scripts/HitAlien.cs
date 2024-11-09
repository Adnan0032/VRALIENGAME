using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAlien : MonoBehaviour
{

    public float speed = 1f;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);


        transform.LookAt(target);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {

            


            this.GetComponent<Animator>().SetBool("kill_alien", true);

            Destroy(this.gameObject, 2f);

           
        }
    }

    IEnumerator KILL()
    {

        yield return new WaitForSeconds(2);
    }
}
