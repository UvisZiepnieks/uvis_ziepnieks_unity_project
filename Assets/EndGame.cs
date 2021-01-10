using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{
    [SerializeField]

    public TextMeshProUGUI score;
    public Rigidbody player;
    public CharacterController cc;

    public GameObject Ending;
    public GameObject Aluminijs;
    public GameObject Broms;
    public GameObject Dzelzs;
    public GameObject Helijs;
    public GameObject Hroms;
    public GameObject Kalijs;
    public GameObject Magnijs;
    public GameObject Skabeklis;
    public GameObject Udenradis;
    public GameObject Vars;

    public GameObject AX;
    public GameObject BrX;
    public GameObject FeX;
    public GameObject HEX;
    public GameObject CrX;
    public GameObject KX;
    public GameObject MgX;
    public GameObject Ox;
    public GameObject Hx;
    public GameObject CuX;

    public int points = 0;


     private void OnTriggerEnter(Collider other)
    {

        Ending.SetActive(true);
        cc.enabled = false;

        if(Aluminijs.activeSelf == true){
            points = points +1;
            AX.SetActive(false);
        }
         if(Broms.activeSelf == true){
            points = points +1;
            BrX.SetActive(false);
        }
         if(Dzelzs.activeSelf == true){
            points = points +1;
            FeX.SetActive(false);
        }
         if(Helijs.activeSelf == true){
            points = points +1;
            HEX.SetActive(false);
        }
         if(Hroms.activeSelf == true){
            points = points +1;
             CrX.SetActive(false);
        }
         if(Kalijs.activeSelf == true){
            points = points +1;
            KX.SetActive(false);
        }
         if(Magnijs.activeSelf == true){
            points = points +1;
            MgX.SetActive(false);
        }
         if(Skabeklis.activeSelf == true){
            points = points +1;
            Ox.SetActive(false);
        }   
         if(Udenradis.activeSelf == true){
            points = points +1;
            Hx.SetActive(false);
        }
         if(Vars.activeSelf == true){
            points = points +1;
            CuX.SetActive(false);
        }
        
        score = score.GetComponent<TextMeshProUGUI>() ;
        string text = points.ToString();
        Debug.Log(text);
        score.text = text+"/10";
      
        if(3 < points && points < 7 ){
            score.color = Color.blue;
        
        }else if(points > 6){
            score.color = Color.green;
        }
        Debug.Log(score);
        StartCoroutine(waiter());

        
        
    }

    IEnumerator waiter()
    {   
    //Wait for 10 seconds
    yield return new WaitForSeconds(10);
    SceneManager.LoadScene (sceneName:"Main_menu");
    }

}
