
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<Item> items; //Tao. danh sach' cac' Item// cacs script Item sex dcj keo' vaof day sau do truyen hinhf anhr xuoongs UI ItemSLot thoong qua RefreshUI()
    [SerializeField] Transform itemsParent; // Vi. tri' UIObject chuas cacs Item Slot
    [SerializeField] ItemSlot[] itemSlots; // goi. mang? cua? script ItemSlot
    private void OnValidate()
    {
        if (itemsParent != null) //rongx
        {
            itemSlots = itemsParent.GetComponentsInChildren<ItemSlot>(); //lays cacs Component scpipt Item Slot tuf UIobject chuas Item Slot 
        }

        RefreshUI(); //neu hok lien ket thi hok thuc hien (why?)
    
    }
    private void RefreshUI()
    {
        int i = 0;
        for (; i < items.Count && i < itemSlots.Length;i++) // các ??i t??ng item trong list thì dùng count, cacs doois tuowngj cuar mangr thif dungf length
        {
            itemSlots[i].Item = items[i]; // xac dinh vi tri thu tu truyen vao Item 1 truyen vao slot 1
        }
        for (;i < itemSlots.Length; i++)
        {
            itemSlots[i].Item = null; //neu hok co Item thi rong => script ItemSlot hok cap nhat hinh anh (dong 19)
        }
    }
}
