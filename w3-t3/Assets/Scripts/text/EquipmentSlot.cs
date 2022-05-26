using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSlot : ItemSlot // t??ng tu. ItemSlot
{
    public EquipmentType EquipmentType;
    protected override void OnValidate() //? //? fix ItemSlot
    {
        base.OnValidate();
        gameObject.name = EquipmentType.ToString() + " Slot";
    }

}
