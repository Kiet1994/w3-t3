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
            if (_item == null) // = vì mình cho ??i t??ng mình g?i t?i gán 1 giá tr? sau ?ó. dùng ??i t??ng ?ó gán vào 1 ??i t??ng trong script
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
    private void OnValidate()
    {
        if(Image == null)
        {
            Image = GetComponent<Image>(); //gan' component

        }
    }
}
