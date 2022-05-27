using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] Transform dropHandlerParent;
    public DropHandler[] slots;

    private void OnValidate()
    {
    
    }
    private void Update()
    {
        //QuantityDisplay();
        if (dropHandlerParent != null)
        {
            slots = dropHandlerParent.GetComponentsInChildren<DropHandler>();
        }
    }

    public Transform GetClosestSlot() //gan nhat
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (Vector2.Distance(slots[i].transform.position, Input.mousePosition) < 35)
            {
                return slots[i].transform;
            }
        }
        return null;
    }

   // public void QuantityDisplay()
   // {
       // for (int i = 0; i < 6; i++)
       // {
         //   if (slots[i].transform.childCount != 0)
         //   {
       //        slots[i].transform.GetChild(0).GetComponentInChildren<Text>().enabled = false;
          //  }
      //  }

     //   for (int i = 0; i < slots.Length; i++)
      //  {
          //  if (slots[i].transform.childCount != 0)
          //  {
           //    /slots[i].transform.GetChild(0).GetComponentInChildren<Text>().enabled = true;
          //  }
      //  }
  //  }
}
