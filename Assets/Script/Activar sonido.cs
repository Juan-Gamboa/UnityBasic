using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activarsonido : MonoBehaviour
{
    public GameObject post;
    public GameObject post1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            AudioManager.Instance.Play3D("Entro", post.transform.position);
            //AudioManager.Instance.Play2D("Entro");
            //Debug.Log("Mensaje");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            AudioManager.Instance.Play3D("Salir", post1.transform.position);
            //AudioManager.Instance.Play2D("Salir");
        }
    }
}
