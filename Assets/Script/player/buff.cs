using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buff : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D buffnya)
    {
        if (buffnya.gameObject.CompareTag("BM"))//buff merah
        {
            Debug.Log("bisa");
            Destroy(buffnya.gameObject);
            gameObject.GetComponent<HeroKnight>().dmgBuff();
        }
        if (buffnya.gameObject.CompareTag("BH"))
        {
            Destroy(buffnya.gameObject);
            gameObject.GetComponent <hp>().hpBuff();
        }
        if (buffnya.gameObject.CompareTag("BB"))
        {
            Destroy(buffnya.gameObject);
            gameObject.GetComponent <HeroKnight>().jarakBuff();
        }
        if (buffnya.gameObject.CompareTag("BU"))
        {
            Destroy(buffnya.gameObject);
            gameObject.GetComponent<HeroKnight>().spdBuff();
        }
    }
}
