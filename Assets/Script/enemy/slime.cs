using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime : MonoBehaviour
{
    public float spd;
    public float damageSlime = 2;
    public Transform tDetect;
    public GameObject user;
    public float jDetect;
    public LayerMask tembok;
    public Animator aSlime;
    bool isMovingRight;
    [SerializeField] private float delay = 2f;
    [SerializeField] private float timeJump = 3f;
    [SerializeField] private float jump;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
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
        cekserang();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tanah"))
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
    void cekserang()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, 1f);
        if(delay > 0)
        {
            delay -= Time.deltaTime;
        }
        else
        {
            foreach(Collider2D hit in hits)
            {
                if (hit.gameObject.CompareTag("Player"))
                {
                    user.GetComponent<hp>().diserang(damageSlime);
                    Debug.Log("Nyerang Player");
                }
            }
            delay = 2f;
        }
    }
}
