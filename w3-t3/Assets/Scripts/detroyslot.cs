using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detroyslot : MonoBehaviour
{
    public GameObject chil;


    // Update is called once per frame
    void Update()
    {
        if (chil == null) 
        {
            Destroy(this.gameObject);
        }
    }
}
