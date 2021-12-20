using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisor : MonoBehaviour
{

    private GameObject cube;
    public void Start()
    {
        cube = GameObject.Find("Cube");
    }

    public void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "Plane")
        {
            Debug.Log("Colidiu com o chão.");
        }

        else if (collider.gameObject.name == "Player")
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Sai de cima, idiota!");
        }
    }

    public void OnCollisionExit(Collision collider)
    {
        Debug.Log("Obrigado, idiota!");
        cube.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
