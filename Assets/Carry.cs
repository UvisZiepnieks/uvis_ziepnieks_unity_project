using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : MonoBehaviour
{
   public Transform hold;
   public GameObject aluminijs;
   public GameObject broms;
   public GameObject dzelzs;
   public GameObject helijs;
   public GameObject hroms;
   public GameObject kalijs;
   public GameObject magnijs;
   public GameObject skabeklis;
   public GameObject udenradis;
   public GameObject vars;


   void OnMouseDown() 
   {
       aluminijs.SetActive(false);
       broms.SetActive(false);
       dzelzs.SetActive(false);
       helijs.SetActive(false);
       hroms.SetActive(false);
       kalijs.SetActive(false);
       magnijs.SetActive(false);
       skabeklis.SetActive(false);
       udenradis.SetActive(false);
       vars.SetActive(false);
       GetComponent<MeshCollider>().enabled = false;
       GetComponent<Rigidbody>().useGravity = false;
       this.transform.position = hold.position;
       this.transform.parent = GameObject.Find("HoldPosition").transform;


   }
   void OnMouseUp()
   {
       aluminijs.SetActive(true);
       broms.SetActive(true);
       dzelzs.SetActive(true);
       helijs.SetActive(true);
       hroms.SetActive(true);
       kalijs.SetActive(true);
       magnijs.SetActive(true);
       skabeklis.SetActive(true);
       udenradis.SetActive(true);
       vars.SetActive(true);
       GetComponent<MeshCollider>().enabled = true;
       this.transform.parent = null;
       GetComponent<Rigidbody>().useGravity = true;
    
   }

   void OnGUI()
   {
   Cursor.lockState = CursorLockMode.Locked;
   Cursor.visible = true;
  }
}
