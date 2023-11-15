using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introTrade : MonoBehaviour
{
    public Text timer;
    public GameObject interUI;
    public GameObject user;
    public LayerMask lUser;
    public Transform pDetect;
    public float jDetect;
    // Start is called before the first frame update
    void Start()
    {
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
        timer.gameObject.SetActive(true);
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
