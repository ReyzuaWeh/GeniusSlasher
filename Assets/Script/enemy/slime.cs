using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class slime : MonoBehaviour
{
    public float spd;
    public float damageSlime = 2;
    public Transform tDetect;
    public float jDetect;
    public LayerMask tembok;
    public Animator aSlime;
    bool isMovingRight;
    [SerializeField] private float delay = 2f;
    [SerializeField] private float timeJump = 3f;
    [SerializeField] private float jump;
    [SerializeField] private float hp = 2;
    Rigidbody2D rb;
    Vector2 arahDetect;
    public LayerMask user;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        if (isMovingRight == true)
        {
            transform.localScale = new Vector3(-5f, 5f, 1);
            transform.Translate(Vector3.right * spd * Time.deltaTime);
        }
        else
        {
            transform.localScale = new Vector3(5f, 5f, 1);
            transform.Translate(Vector3.left * spd * Time.deltaTime);
        }
        if(transform.localScale.x < 0)
        {
            arahDetect = Vector2.right;
            isMovingRight = true;
        }
        else
        {
            arahDetect = Vector2.left;
            isMovingRight = false;
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        if(timeJump > 0)
        {
            timeJump -= Time.deltaTime;
        }
        else if (timeJump == 0)
        {
            rb.AddForce(new Vector2(0, jump));
            timeJump = 3f;
        }
        else
        {
            timeJump = 0;
        }
        cekserang();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Terjadi tabrakan fisik dengan: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Terjadi tabrakan fisik dengan User dengan tag :" + collision.gameObject.tag);
            aSlime.SetTrigger("Attack");
            collision.gameObject.GetComponent<hp>().diserang(damageSlime);
            if (isMovingRight)
            {
                rb.velocity = new Vector2(-5, 0);
            }
            else
            {
                rb.velocity = new Vector2(5,0);
            }
        }

        if (collision.gameObject.CompareTag("tembok"))
        {
            if(isMovingRight == true)
            {
                isMovingRight = false;
            }
            else
            {
                isMovingRight = true;
            }
        }

    }
    public void OnAnimationComplete()
    {
        Debug.Log("Animasi telah selesai!");

        // Lakukan sesuatu setelah animasi selesai
    }
    void cekserang()
    {
        //RaycastHit2D serangs = Physics2D.Raycast(transform.position, arahDetect, 1f, user);
        //if (serangs != null)
        //{
        //    Debug.Log(serangs.collider.name);
        //}
        //if(delay > 0)
        //{
        //    delay -= Time.deltaTime;
        //}
        //else
        //{
        //    if (serangs.collider.tag == "Player")
        //    {
        //        aSlime.SetTrigger("Attack");
        //        System.Threading.Thread.Sleep(1000);
        //        serangs.collider.gameObject.GetComponent<hp>().diserang(damageSlime);
        //        Debug.Log("Nyerang Player");
        //    }
        //    delay = 2f;
        //}
        //foreach(var serang in serangs)
        //{
        //}
        //Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, 1f);
        //if (delay > 0)
        //{
        //    delay -= Time.deltaTime;
        //}
        //else
        //{
        //    foreach (Collider2D hit in hits)
        //    {
        //        if (hit.gameObject.CompareTag("Player"))
        //        {
        //            aSlime.SetTrigger("Attack");
        //            System.Threading.Thread.Sleep(1000);
        //            hit.gameObject.GetComponent<hp>().diserang(damageSlime);
        //            Debug.Log("Nyerang Player");
        //        }
        //    }
        //    delay = 2f;
        //}
    }
    public void SlashSlime(float uDmg)
    {
        hp -= uDmg;
    }
}
