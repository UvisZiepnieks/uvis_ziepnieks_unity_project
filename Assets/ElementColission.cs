using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementColission : MonoBehaviour
{
    public Transform place;
    public GameObject element;

    private void OnTriggerEnter(Collider other)
    {
       other.transform.position = place.position;
       element.SetActive(false);
       other.transform.localRotation = Quaternion.Euler(-90,0,-90);
    }    
}
