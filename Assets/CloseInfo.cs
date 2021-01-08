using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseInfo : MonoBehaviour
{

    public GameObject info;
    // Update is called once per frame
    public void Click()
    {
          info.SetActive(false);
    }
}
