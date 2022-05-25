using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ItemDisplay : MonoBehaviour
{
    public ItemData dateItem;
    public TMP_Text quantityItem;
    public Image imgItem;

    void Start()
    {
        quantityItem.text = dateItem.quantity.ToString();
        imgItem.sprite = dateItem.imgItem;
    }

}
