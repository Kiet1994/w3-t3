using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MoveItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        UpdatePotition();
    }

    public void OnDrag(PointerEventData eventData)
    {
        UpdatePotition();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("end drag");
    }
    void UpdatePotition()
    {
        var mousePosition = Input.mousePosition;
        transform.position = mousePosition;
    }
    
}  
