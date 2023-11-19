using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialog : MonoBehaviour
{
    public TextMeshProUGUI tempatText;
    public string[] dialogText;
    public float spdText;
    public GameObject tnpc;
    public GameObject answer;
    public bool nextClick;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        nextClick = false;
        index = 0;
        tempatText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
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
            tnpc.GetComponent<introTrade>().sudahBeres();
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
