using UnityEngine;
using System.Collections;

public class Bandit : MonoBehaviour {

    [SerializeField] float      m_speed = 4.0f;
    [SerializeField] float      m_jumpForce = 7.5f;
    [SerializeField] bool      isMovingRight = true;

    private Animator            m_animator;
    [SerializeField] private Rigidbody2D         m_body2d;
    private Sensor_Bandit       m_groundSensor;
    private bool                m_grounded = false;
    private bool                m_combatIdle = false;
    private bool                m_isDead = false;

    // Use this for initialization
    void Start () {
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        m_groundSensor = transform.Find("GroundSensor").GetComponent<Sensor_Bandit>();
    }
	
	// Update is called once per frame
	void Update () {
        //Check if character just landed on the ground
        if (!m_grounded && m_groundSensor.State()) {
            m_grounded = true;
            m_animator.SetBool("Grounded", m_grounded);
        }

        //Check if character just started falling
        if(m_grounded && !m_groundSensor.State()) {
            m_grounded = false;
            m_animator.SetBool("Grounded", m_grounded);
        }

        // -- Handle input and movement --
        if (isMovingRight == true)
        {
            transform.localScale = new Vector3(-1f, 1f, 1);
            transform.Translate(Vector3.right * m_speed * Time.deltaTime);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1);
            transform.Translate(Vector3.left * m_speed * Time.deltaTime);
        }

        //Set AirSpeed in animator
        if (m_combatIdle)
            m_animator.SetInteger("AnimState", 1);

        //Idle
        else
            m_animator.SetInteger("AnimState", 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tanah"))
        {
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
}
