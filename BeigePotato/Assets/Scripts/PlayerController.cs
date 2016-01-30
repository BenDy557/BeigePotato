using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Vector2 m_Velocity;
    public float m_MaxVelocity;
    private Rigidbody2D m_RigidBody;

	// Use this for initialization
	void Start () {

        m_RigidBody = GetComponent<Rigidbody2D>();

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

        //transform.position += new Vector3(m_Velocity.x,m_Velocity.y)*Time.deltaTime;
	}
}
