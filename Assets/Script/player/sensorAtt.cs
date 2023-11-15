using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorAtt : MonoBehaviour
{
    Vector3 posisi;
    public bool keKanan = true;
    // Start is called before the first frame update
    public void Start()
    {
        posisi = transform.localPosition;
    }
    public void kanan()
    {
        transform.localPosition = new Vector3(posisi.x, posisi.y, posisi.z);
    }
    public void kiri()
    {
        transform.localPosition = new Vector3(-posisi.x, posisi.y, posisi.z);
    }
}
