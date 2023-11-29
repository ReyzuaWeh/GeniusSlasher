using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introTrade : MonoBehaviour
{
    public GameObject[] buffan;
    public Text timer;
    public int nilai;
    public GameObject interUI;
    public GameObject user;
    public GameObject pertanyaan;
    public GameObject spawner;
    public LayerMask lUser;
    public Transform pDetect;
    public GameObject dialog;

    Vector3 spawnPosition;
    int nilaiAwal;

    public float jDetect;
    // Start is called before the first frame update
    void Start()
    {
        spawner.gameObject.SetActive(false);
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
        if(spawner != null)
        {
            spawner.gameObject.SetActive(true);
        }
        gameObject.SetActive(false);
        giveBuff();
    }
    void giveBuff()
    {
        for(nilaiAwal = 0; nilaiAwal< nilai; nilaiAwal++)
        {
            spawnPosition = transform.position + new Vector3(Random.Range(-3f, 3f), 2f, 0f);
            if (buffan != null)
            {
                Instantiate(buffan[Random.Range(0, buffan.Length-1)], spawnPosition, Quaternion.identity);
            }
            else
            {
                Debug.Log("Tidak ada buff");
            }
        }
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
