﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Menu_start : Button
{
         public void Update ()
     {
         Button button = this.GetComponent<Button>();
         Image imageObject = GameObject.Find("ImageDown").GetComponent<Image>();

         ColorBlock colorBlock  = this.colors;
 
       
         if (this.currentSelectionState == SelectionState.Highlighted)
         {
             imageObject.color = colorBlock.highlightedColor;
    
         }
         else if (this.currentSelectionState == SelectionState.Pressed)
         {
             imageObject.color = colorBlock.pressedColor;
         }
         else if (this.currentSelectionState == SelectionState.Disabled)
         {
             imageObject.color = colorBlock.disabledColor;
         }
         else  if (this.currentSelectionState == SelectionState.Normal)
         {
       
            
         }

     }
     public void startGame(){
          StartCoroutine(waiter());

     }
    public void quit(){
        //  UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit ();
    }
    IEnumerator waiter()
{
    //Wait for 4 seconds
    yield return new WaitForSeconds(3);
    SceneManager.LoadScene (sceneName:"Game_Scene");
}
  void OnGUI()
   {
   Cursor.lockState = CursorLockMode.None;
   Cursor.visible = true;
  }
       
}
