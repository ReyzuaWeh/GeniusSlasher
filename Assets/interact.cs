using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    [SerializeField] Transform area;
    [SerializeField] float size; 
    [SerializeField] LayerMask npc; 
    [SerializeField] bool izin; 
    // Start is called before the first frame update
    void Start()
    {
        izin = true;
    }

    // Update is called once per frame
    void Update()
    {
        hey();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(area.position,size);
    }
    void hey()
    {
        Collider2D npcKah = Physics2D.OverlapCircle(area.position, size, npc);

        if(Input.GetMouseButtonDown(1) && izin)
        {
            izin = false;
            if (npcKah != null)
            {
                if(npcKah.CompareTag("TNPC")) {
                    Debug.Log("Ini TNPC, namanya "+ npcKah.name);
                    if(npcKah.name == "siPejuang")
                    {
                        npcKah.GetComponent<introTrade>().ditanya();
                    }
                }
            }
        }
        else if (Input.GetMouseButtonUp(1))
        {
            izin=true;
        }
    }
}
