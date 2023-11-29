using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    public float hitpoin = 100;
    // Start is called before the first frame update
    public void hpBuff()
    {
        hitpoin += 50f;
        Debug.Log("Makin tebel : "+ hitpoin);
    }
    public void diserang(float serang)
    {
        hitpoin -= serang;
    }
}
