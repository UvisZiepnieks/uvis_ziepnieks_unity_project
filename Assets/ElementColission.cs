using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementColission : MonoBehaviour
{
    public Transform place;
    public GameObject element;
    public GameObject activate;

    private void OnTriggerEnter(Collider other)
    {
    
       if(element.name == "UdenradisPostion"){
           if(other.GetComponent<Collider>().name == "udenradis"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "MagnijsPosition"){
           if(other.GetComponent<Collider>().name == "Magnijs"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
            activate.SetActive(false);
           }
       }
         if(element.name == "KalijsPosition"){
           if(other.GetComponent<Collider>().name == "kalijs"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "HromsPosition"){
           if(other.GetComponent<Collider>().name == "hroms"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "DzelzsPosition"){
           if(other.GetComponent<Collider>().name == "dzelzs"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "VarsPosition"){
           if(other.GetComponent<Collider>().name == "vars"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "AluminijsPosition"){
           if(other.GetComponent<Collider>().name == "aluminjs"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "Skabeklis Position"){
           if(other.GetComponent<Collider>().name == "Skabeklis"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "Broms Position"){
           if(other.GetComponent<Collider>().name == "broms"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
         if(element.name == "Helijs Position"){
           if(other.GetComponent<Collider>().name == "helijs"){
            Debug.Log(activate);
            activate.SetActive(true);
           }else{
                activate.SetActive(false);
           }
       }
       other.transform.position = place.position;
       element.SetActive(false);
       other.transform.localRotation = Quaternion.Euler(-90,0,-90);
    }    
}
