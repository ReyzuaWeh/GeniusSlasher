using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introTrade : MonoBehaviour
{
    public Text timer;
    public GameObject interUI;
    public GameObject user;
    public GameObject buff;
    public GameObject pertanyaan;
    public LayerMask lUser;
    public Transform pDetect;
    public GameObject dialog;

    public float jDetect;
    // Start is called before the first frame update
    void Start()
    {
        pDetect.gameObject.SetActive(false);
        dialog.gameObject.SetActive(false);
        timer.gameObject.SetActive(false);
        jDetect = user.GetComponent<interact>().size;
    }
    void Update()
    {
        Collider2D areaInter = Physics2D.OverlapCircle(pDetect.position, jDetect, lUser);
        if (areaInter != null)
        {
            terdetect();
        }
        else if (areaInter == null)
        {
            takTerdetect();
        }
    }
    // Update is called once per frame
    public void ditanya()
    {
        user.GetComponent<HeroKnight>().enabled= false;
        dialog.gameObject.SetActive(true);
        dialog.GetComponent<dialog>().MulaiDialog();
    }
    public void sudahBeres()
    {
        Debug.Log("sudahBeres()");
        dialog.gameObject.SetActive(true);
        dialog.GetComponent<dialog>().close = true;
        dialog.GetComponent<dialog>().penutup();
    }
    public void sudahDihitung()
    {
        dialog.gameObject.SetActive(false);
        timer.gameObject.SetActive(true);
        user.GetComponent<HeroKnight>().enabled = true;
        gameObject.SetActive(false);
    }
    public void pertanyaanBeres()
    {
        pertanyaan.GetComponent<cDisplay>().pertanyaan();
    }
    public void terdetect()
    {
        interUI.SetActive(true);
    }
    public void takTerdetect()
    {
        interUI.SetActive(false);
    }
}
