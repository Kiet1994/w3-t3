using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddItem3 : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] List<Item> items; // danh sach cac item
    [SerializeField] Transform itemsParent; // Vi. tri' UIObject chuas cacs Item Slot
    [SerializeField] ItemDisplay[] itemSlots; // goi. mang? cua? script ItemSlot
    [SerializeField] Item Null;
    public void OnPointerDown(PointerEventData eventData)
    {

        RandomItem();
    }
    private void RandomItem()
    {
        int xx = Random.Range(1, 10);
        Debug.Log(xx);
        itemSlots[1].item = Null; //không ho?t ??ng????
    }
    public void OnValidate()
    {
        if (itemsParent != null) //rongx
        {
            itemSlots = itemsParent.GetComponentsInChildren<ItemDisplay>(); //lays cacs Component scpipt Item Slot tuf UIobject chuas Item Slot 
        }
    }

}
