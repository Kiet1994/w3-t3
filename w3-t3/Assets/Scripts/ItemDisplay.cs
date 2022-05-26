
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public Item item;
    public Image image;
    public TMP_Text quantity;

    // Start is called before the first frame update
    private void OnValidate()
    {
        if (image == null)
        {
            image = GetComponent<Image>(); //gan' component

        }
        if (item == null)
        {
            image.enabled = false;
            quantity.text = null;
        }
        else
        {
            image.sprite = item.Icon;
            image.enabled = true;
            quantity.text = item.Quantity.ToString();
        }
    }
}