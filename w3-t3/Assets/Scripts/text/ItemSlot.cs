using UnityEngine;
using UnityEngine.UI;

// truyenf hinhf anhr tu Script UI Item qua UI Item Slot
// chua xac dinh UI Item nao truyen vao nen phai thong qua iventory bang cach gan vao iventory
public class ItemSlot : MonoBehaviour
{

    [SerializeField] Image Image;
    private Item _item; //g?i scripts Item t?i
    public Item Item //ko hien Inpector
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item == null) // = v� m�nh cho ??i t??ng m�nh g?i t?i g�n 1 gi� tr? sau ?�. d�ng ??i t??ng ?� g�n v�o 1 ??i t??ng trong script
            {
                Image.enabled = false; // enabled cho ph�p c?p nh?t or khong.
            }
            else
            {
                Image.sprite = _item.Icon;
                Image.enabled = true;           
            }
        }
    }
    private void OnValidate()
    {
        if(Image == null)
        {
            Image = GetComponent<Image>(); //gan' component

        }
    }
}
