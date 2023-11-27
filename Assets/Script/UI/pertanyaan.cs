using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class pertanyaan : MonoBehaviour
{
    public question[]               tanya;
    public float                    spdText;
    public TextMeshProUGUI          kalimatTanya;
    public TextMeshProUGUI          pil1;
    public TextMeshProUGUI          pil2;
    public TextMeshProUGUI          pil3;
    public TextMeshProUGUI          pil4;
    public GameObject               pilihan;
    public GameObject               canvasPertanyaan;
    public dialogBenarSalah         trufalse;


    private bool                    dialog;
    private bool                    done;
    private bool                    jawabBener;
    private static List<question>   blumJawab;
    private question                tanyaNow;
    // Start is called before the first frame update
    void Start()
    {
        done = false;
        jawabBener = false;
        dialog = false;
        pilihan.SetActive(false);
        kalimatTanya.text = string.Empty;
        if(blumJawab == null)
        {
            blumJawab = tanya.ToList<question>();
        }
        nanya();
    }
    void Update()
    {
        if (dialog == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (kalimatTanya.text == trufalse.benar || kalimatTanya.text == trufalse.salah)
                {
                    if (blumJawab.Count != 0)
                    {
                        nanya();
                    }
                    else
                    {
                        StartCoroutine(beres());
                    }
                }
                else if (kalimatTanya.text != tanyaNow.pertanyaan)
                {
                    StopAllCoroutines();
                    kalimatTanya.text = tanyaNow.pertanyaan;
                }
            }
        }
        else
        {
            if (done == false)
            {

                if (jawabBener == true)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (kalimatTanya.text != trufalse.benar)
                        {
                            StopAllCoroutines();
                            kalimatTanya.text = trufalse.benar;
                            dialog = false;
                        }
                    }
                }
                else
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (kalimatTanya.text != trufalse.salah)
                        {
                            StopAllCoroutines();
                            kalimatTanya.text = trufalse.salah;
                            dialog = false;
                        }
                    }
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (kalimatTanya.text != trufalse.beres)
                    {
                        StopAllCoroutines();
                        kalimatTanya.text = trufalse.beres;
                    }
                    else
                    {
                        canvasPertanyaan.SetActive(false);
                    }
                }
            }
        }
        if(kalimatTanya.text == tanyaNow.pertanyaan)
        {
            pilihan.SetActive(true);
        }
    }
    // Update is called once per frame
    void nanya()
    {
        dialog = false;
        int randomTanya = Random.Range(0, blumJawab.Count);
        tanyaNow = blumJawab[randomTanya];
        blumJawab.RemoveAt(randomTanya);
        StartCoroutine(ketik());
    }
    IEnumerator ketik()
    {
        kalimatTanya.text = string.Empty;
        pil1.text = tanyaNow.pilihan1;
        pil2.text = tanyaNow.pilihan2;
        pil3.text = tanyaNow.pilihan3;
        pil4.text = tanyaNow.pilihan4;
        foreach (char huruf in tanyaNow.pertanyaan.ToCharArray())
        {
            kalimatTanya.text += huruf;
            yield return new WaitForSeconds(spdText);
        }
    }
    IEnumerator benar()
    {
        dialog = true;
        jawabBener = true;
        foreach(char words in trufalse.benar.ToCharArray())
        {
            kalimatTanya.text += words;
            if(kalimatTanya.text == trufalse.benar)
            {
                dialog = false;
            }
            yield return new WaitForSeconds(spdText);
        }
    }
    IEnumerator salah()
    {
        dialog = true;
        jawabBener = false;
        foreach(char words in trufalse.salah.ToCharArray())
        {
            if (kalimatTanya.text == trufalse.salah)
            {
                dialog = false;
            }
            kalimatTanya.text += words;
            yield return new WaitForSeconds(spdText);
        }
    }
    IEnumerator beres()
    {
        dialog = true;
        done = true;
        kalimatTanya.text = string.Empty;
        foreach(char words in trufalse.beres.ToCharArray())
        {
            kalimatTanya.text += words;
            yield return new WaitForSeconds(spdText);
        }
    }
    public void choice1()
    {
        if(tanyaNow.benernya == 1)
        {
            Debug.Log("benar");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(benar());
        }
        else
        {
            Debug.Log("salah");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(salah());
        }
    }
    public void choice2()
    {
        if(tanyaNow.benernya == 2)
        {
            Debug.Log("benar");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(benar());
        }
        else
        {
            Debug.Log("salah");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(salah());
        }
    }
    public void choice3()
    {
        if(tanyaNow.benernya == 3)
        {
            Debug.Log("benar");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(benar());
        }
        else
        {
            Debug.Log("salah");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(salah());
        }
    }
    public void choice4()
    {
        if(tanyaNow.benernya == 4)
        {
            Debug.Log("benar");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(benar());
        }
        else
        {
            Debug.Log("salah");
            pilihan.SetActive(false);
            kalimatTanya.text = string.Empty;
            StartCoroutine(salah());
        }
    }
}
