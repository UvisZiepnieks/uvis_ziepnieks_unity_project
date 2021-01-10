using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScreen : MonoBehaviour
{
    
    public CharacterController cc;
    public GameObject screen;
    // Update is called once per frame
    void Start()
    {
        cc.enabled = false;
        StartCoroutine(waiter());
    }
      IEnumerator waiter()
    {   
    //Wait for 10 seconds
    yield return new WaitForSeconds(15);
    screen.SetActive(false);
    cc.enabled = true;
    }
}
