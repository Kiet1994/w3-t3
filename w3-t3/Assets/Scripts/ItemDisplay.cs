
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ItemDisplay : MonoBehaviour
{
    public Item item;
    public Image image;
    public TMP_Text quantity;
    private void OnValidate()
    {
        image.sprite = item.Icon;
        if (item.Quantity == 0)
        {
            quantity.text = null;
        }
        else
            quantity.text = item.Quantity.ToString();
        
    }

}