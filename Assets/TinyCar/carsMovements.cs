using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carsMovements : MonoBehaviour
{
    // Start is called before the first frame update
    public float impulseForce = 10.0f;
    public float speed = 5f;
    void Start()
    {
       //GetComponent<Rigidbody>().AddForce(Vector3.up * impulseForce, ForceMode.Impulse);                
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation, speed * Time.deltaTime);
        if (transform.position.z == -500.0f)
        {
            Destroy(gameObject);
        }
    }
}
