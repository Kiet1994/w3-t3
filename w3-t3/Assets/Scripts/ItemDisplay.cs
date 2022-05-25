using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ItemDisplay : MonoBehaviour
{
 
    public ItemData dataItem;
    public TMP_Text quantityItem;
    public Image imgItem;

    void Start()
    {
        
        quantityItem.text = dataItem.quantity.ToString();
        if(quantityItem.text == "0")
            {
            quantityItem.text = null;
            }
        imgItem.sprite = dataItem.imgItem;
    }

}
