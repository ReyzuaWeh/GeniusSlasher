using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public float size; 
    [SerializeField] Transform area;
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
        if(Input.GetKeyDown(KeyCode.E) && izin && GetComponent<Rigidbody2D>().velocity.x == 0)
        {
            izin = false;
            Debug.Log("bisa");
            if (npcKah != null)
            {
                if(npcKah.CompareTag("TNPC")) {
                    Debug.Log("Ini TNPC, namanya "+ npcKah.name);
                    if(npcKah.gameObject.name == "siPejuang")
                    {
                        npcKah.GetComponent<introTrade>().ditanya();
                    }
                }
            }
            
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            izin=true;
        }
    }
}
