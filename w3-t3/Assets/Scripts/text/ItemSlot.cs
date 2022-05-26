using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// truyenf hinhf anhr tu Script UI Item qua UI Item Slot
// chua xac dinh UI Item nao truyen vao nen phai thong qua iventory bang cach gan vao iventory
public class ItemSlot : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] Image Image;
    private Item _item; //g?i scripts Item t?i
    public Item Item //ko hien Inpector
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item == null) // = !!
            {
                Image.enabled = false; // enabled cho phép c?p nh?t or khong.
            }
            else
            {
                Image.sprite = _item.Icon;
                Image.enabled = true;           
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData != null && eventData.button == PointerEventData.InputButton.Right)
        {

        }
    }

    protected virtual void OnValidate() //??
    {
        if(Image == null)
        {
            Image = GetComponent<Image>(); //gan' component

        }
    }
}
