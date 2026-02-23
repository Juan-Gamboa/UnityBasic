using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarHudPick : MonoBehaviour
{

    public GameObject imgControllers;

    void Start(){
        imgControllers.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "PlayerInteractionZone"){
            imgControllers.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other){
        if(other.tag == "PlayerInteractionZone"){
            imgControllers.SetActive(false);
        }
    }
}
