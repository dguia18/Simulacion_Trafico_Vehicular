using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physis : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidBody;
    public void Shoot()
    {
        //Toma En cuenta la masa
        //GetComponent<Rigidbody>().AddForce(Vector3.right * 50f, ForceMode.Impulse);
        //No toma encuenta la masa}
        //GetComponent<Rigidbody>().AddForce(Vector3.right * 50f, ForceMode.VelocityChange);
        float x = Random.Range(-1, 1);
        GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 1f) * 100f, ForceMode.Impulse);

    }

    // Update is called once per frame
    //void Update()
    //{
    //    // Teniendo en cuenta la masa
    //    //GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMode.Force);
    //    //No teniendo en cuenta la masa
    //    //GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMode.Acceleration);

    //    GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMod.Force);
    //}
    //Se ejecuta de manera mas constante que el metodo Update
    void FixedUpdate()
    {
        // Teniendo en cuenta la masa
        //GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMode.Force);
        //No teniendo en cuenta la masa
        //GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMode.Acceleration);

        //GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMode.Force);
    }
}
