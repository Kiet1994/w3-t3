using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Remove : MonoBehaviour, IPointerDownHandler //IPointerUpHandler

{
    public GameObject remove;
   
    //public bool Del;
    public void OnPointerDown(PointerEventData eventData)
    {

        foreach (Transform child in remove.transform)
        {
            Destroy(child.gameObject);
        }

    }

   // public void OnPointerUp(PointerEventData eventData)
   // {
        
        //Debug.Log(Del);
   // }


}
