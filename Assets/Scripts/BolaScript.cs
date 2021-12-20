using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour
{

    private GameObject bola;
    public Rigidbody rig;
    private float speed = 300f;
    private float jumpPower = 25f;
    private bool pesNoChao;

    public void Start()
    {
        bola = GameObject.Find("Bola");
        rig = bola.GetComponent<Rigidbody>();
        rig.mass = 3;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            pesNoChao = true;
        }
        if (collision.gameObject.name != "Plane")
        {
            bola.GetComponent<MeshRenderer>().material.color = Color.grey;
        }
    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rig.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Acceleration);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            //rig.velocity = Vector3.right * speed * Time.deltaTime;
            rig.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Acceleration);
        }

        if(pesNoChao && Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            pesNoChao = false;
        }
    }
}
