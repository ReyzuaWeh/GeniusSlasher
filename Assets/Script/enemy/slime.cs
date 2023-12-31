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
    [SerializeField] private float delay = 0f;
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
        else if (timeJump <= 0)
        {
            rb.AddForce(new Vector2(0,Random.Range(100, jump+1)));
            timeJump = Random.Range(2f, 6f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(delay > 0)
        {
            delay -= Time.timeScale;
        }
        else
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("Terjadi tabrakan fisik dengan User dengan tag :" + collision.gameObject.tag);
                aSlime.SetTrigger("Attack");
                collision.gameObject.GetComponent<hp>().diserang(damageSlime);
                if ((transform.localPosition.x - collision.gameObject.transform.localPosition.x) < 0 )
                {
                    rb.velocity = new Vector2(-5, 0);
                }
                else
                {
                    rb.velocity = new Vector2(5, 0);
                }
                    delay = 1.5f;
            }
        }

        if (collision.gameObject.CompareTag("tembok"))
        {
            Debug.Log("Terjadi tabrakan fisik dengan User dengan tag :" + collision.gameObject.tag);
            if (isMovingRight == true)
            {
                isMovingRight = false;
            }
            else
            {
                isMovingRight = true;
            }
        }

    }
    public void SlashSlime(float uDmg)
    {
        hp -= uDmg;
    }
}
