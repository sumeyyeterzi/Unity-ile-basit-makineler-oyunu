using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bulmaca : MonoBehaviour
{


    int index = 0;
    public void bulmaca(int ID)
    {
        
        this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + index;
        BulmcaKontrol.init.verilenCevap[ID] = index;
        BulmcaKontrol.init.CevapKontrol();
        index++;
        if (index == 2)
        {
            index = 0;
        }
    }
}
