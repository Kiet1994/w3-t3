using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddItem : MonoBehaviour, IPointerDownHandler
{
    public GameObject canvas;
    public GameObject enemyCar;
    public GameObject[] Items;

    void CreateItems()
    {
        int xx = Random.Range(1, 7);

        var createImage = Instantiate(Items[xx]) as GameObject;
        createImage.transform.SetParent(canvas.transform, false);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("da bam vao");
        CreateItems();
     //   AddItems();
    }
   // private void AddItems()
    //{
    //    Instantiate(Items[1], transform.position, Quaternion.identity);
   //     Items[1].transform.parent = this.transform;
   // }
//
}
