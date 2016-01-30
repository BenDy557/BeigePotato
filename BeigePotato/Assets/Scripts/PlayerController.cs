using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Vector2 m_Velocity;
    public float m_MaxVelocity;
    private Rigidbody2D m_RigidBody;
    public GameObject m_AnimatorObject;
    private Animator m_Animator;

	// Use this for initialization
	void Start () {

        m_RigidBody = GetComponent<Rigidbody2D>();


        m_Animator = m_AnimatorObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        m_RigidBody.velocity += new Vector2(Input.GetAxis("Horizontal"),0.0f);

        m_RigidBody.velocity *= 0.9f;
        if (m_RigidBody.velocity.x > m_MaxVelocity)
        {
            m_RigidBody.velocity = new Vector2(m_MaxVelocity, m_RigidBody.velocity.y);
        }
        else if (m_RigidBody.velocity.x < -m_MaxVelocity)
        {
            m_RigidBody.velocity = new Vector2(-m_MaxVelocity, m_RigidBody.velocity.y);
        }

        float speedRatio =  Mathf.Abs((float)(m_RigidBody.velocity.x / m_MaxVelocity));
        if (speedRatio < 0.2f)
        {
            m_Animator.speed = 0.2f;
            m_Animator.SetBool("IsRunning", false);
        }
        else
        {
            m_Animator.speed = speedRatio;
            m_Animator.SetBool("IsRunning", true);
        }

        if (m_RigidBody.velocity.x > 0.1f)
        {
            transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        }
        else if (m_RigidBody.velocity.x < -0.1f)
        {
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }

        //transform.position += new Vector3(m_Velocity.x,m_Velocity.y)*Time.deltaTime;
	}
}
