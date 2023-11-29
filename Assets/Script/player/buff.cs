using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buff : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D buff)
    {
        if (buff.gameObject.CompareTag("BM"))//buff merah
        {
            Destroy(buff.gameObject);
            gameObject.GetComponent<HeroKnight>().dmgBuff();
        }
        if (buff.gameObject.CompareTag("BH"))
        {
            Destroy(buff.gameObject);
            gameObject.GetComponent <hp>().hpBuff();
        }
        if (buff.gameObject.CompareTag("BB"))
        {
            Destroy(buff.gameObject);
            gameObject.GetComponent <HeroKnight>().jarakBuff();
        }
        if (buff.gameObject.CompareTag("BU"))
        {
            Destroy(buff.gameObject);
            gameObject.GetComponent<HeroKnight>().spdBuff();
        }
    }
}
