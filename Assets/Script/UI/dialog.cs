using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialog : MonoBehaviour
{
    public TextMeshProUGUI tempatText;
    public string[] dialogText;
    public string[] dialogClose;
    public float spdText;
    public GameObject tnpc;
    public GameObject answer;
    public bool nextClick;

    public bool close;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(dialogClose.Length - 1);
        if(close != true)
        {
            close = false;
            nextClick = false;
            index = 0;
            tempatText.text = string.Empty;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!close)
            {
                if(tempatText.text == dialogText[index] && index != 4)
                {
                    dialogLanjutan();
                }
                else if(index == 4)
                {
                    nextClick = true;
                    answer.SetActive(true);
                }
                else if(nextClick == false)
                {
                    StopAllCoroutines();
                    Debug.Log("Index = " + index);
                    Debug.Log("Dialog = " + dialogText[index]);
                    tempatText.text = dialogText[index];
                }
            }
            else
            {
                if(tempatText.text == dialogClose[index])
                {
                    StartCoroutine(ketikPenutup());
                }
                else
                {
                    StopAllCoroutines();
                    tempatText.text = dialogClose[index];
                }
            }

        }
    }

    public void MulaiDialog()
    {
        StartCoroutine(ketik());
    }
    IEnumerator ketik()
    {
        foreach (char huruf in dialogText[index].ToCharArray())
        {
            tempatText.text += huruf;
            yield return new WaitForSeconds(spdText);
        }
    }
    IEnumerator ketikPenutup()
    {
        if(index < dialogClose.Length - 1)
        {
            index++;
            tempatText.text = string.Empty;
            foreach (char huruf in dialogClose[index].ToCharArray())
            {
                tempatText.text += huruf;
                yield return new WaitForSeconds(spdText);
            }
        }
        else
        {
            tnpc.GetComponent<introTrade>().sudahDihitung();
        }
    }
    public void penutup()
    {
        index = -1;
        StopAllCoroutines();
        StartCoroutine(ketikPenutup());
    }
    public void dialogLanjutan()
    {
        if (index < dialogText.Length - 1)
        {
            index++;
            tempatText.text = string.Empty;
            StartCoroutine(ketik());
        }
        else
        {
            tnpc.GetComponent<introTrade>().pertanyaanBeres();
            gameObject.SetActive(false);
        }
    }
    public void YESSS()
    {
        answer.SetActive(false);
        nextClick = false;
        dialogLanjutan();
    }
    public void NONONO()
    {
        if(index < dialogText.Length - 1)
        {
            index = dialogText.Length;
            dialogLanjutan();
        }
    }
}
