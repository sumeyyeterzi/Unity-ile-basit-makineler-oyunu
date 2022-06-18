using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kapi : MonoBehaviour
{
    public GameObject yazi;

    bool kapiacabilir = false;
    bool kapicoll = true;

    public Animator kapiaAnim;
    public GameObject tekrarBasla;

    public GameObject[] canavarlar;
    bool canavar = false;
    private void Update()
    {
        if (kapiacabilir)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                kapiaAnim.Play("kapi");
                kapicoll = false;
                if (canavar)
                {
                   
                    yazi.SetActive(false);
                    tekrarBasla.SetActive(true);
                    this.gameObject.SetActive(false);
                }
            }
        }

    }
    int index =0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kapi") && kapicoll)
        {
            yazi.SetActive(true);
            kapiaAnim = other.GetComponent<Animator>();
            kapiacabilir = true;
            canavar = false;
            canavarlar[index].SetActive(false);
        }
        if (other.CompareTag("KapiCanavar") && kapicoll)
        {
            yazi.SetActive(true);
            canavar = true;
            kapiaAnim = other.GetComponent<Animator>();
            kapiacabilir = true;
            canavarlar[index].SetActive(true);
        }
        if (other.CompareTag("Respawn"))
        {
            
            kapiaAnim.Play("Idle");
            kapicoll = true;
            index++;
            other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Kapi"))
        {
            yazi.SetActive(false);
            kapiacabilir = false;
        }
    }


    IEnumerator geriSayim()
    {
        yield return new WaitForSeconds(2f);
        tekrarBasla.SetActive(true);
    }
}
