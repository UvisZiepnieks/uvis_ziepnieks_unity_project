using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject menu;
    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.P))
        {
             if(menu.activeInHierarchy == true){
                 menu.SetActive(false);
             }else{
                 menu.SetActive(true);
             }
        }
    }
}
