using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulmcaKontrol : MonoBehaviour
{
    public static BulmcaKontrol init;

    private void Awake() {
        init = this;
    }

    public int[] sorununCevabi = new int[4];
    public int[] verilenCevap = new int[] { 0, 0, 0, 0 };

    bool sonuc = false;

    public Animator anim;

    public void CevapKontrol()
    {
        for (int i = 0; i < sorununCevabi.Length; i++)
        {
            if (sorununCevabi[i] == verilenCevap[i])
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
                break;
            }
        }
        if(sonuc){
             anim.Play("kapi");
             anim.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
