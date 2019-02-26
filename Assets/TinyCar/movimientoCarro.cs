using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCarro : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    void Start()
    {

    }
    void Update (){
        transform.Translate(0, 0, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation, speed * Time.deltaTime);
        if (this.transform.rotation.z == -882.99f)
        {
            transform.Rotate(new Vector3(0f,30f ,0f) * Time.deltaTime );

        }
    }
}
