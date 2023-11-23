using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class pertanyaan : MonoBehaviour
{
    public question[] tanya;
    private static List<question> blumJawab;

    private question tanyaNow;
    // Start is called before the first frame update
    void Start()
    {
        if(blumJawab == null || blumJawab == 0)
        {
            blumJawab = tanya.toList<question>();
        }
        nanya();
    }

    // Update is called once per frame
    void nanya()
    {
        int randomTanya = Random.Range(0, blumJawab.Count);
        tanyaNow = blumJawab[randomTanya];
        blumJawab.RemoveAt(tanyaNow);
    }
}
