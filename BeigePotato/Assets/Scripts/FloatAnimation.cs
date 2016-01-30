using UnityEngine;
using System.Collections;

public class FloatAnimation : MonoBehaviour {

    public float m_FloatTime;
    public float m_FloatSpeed;
    private float m_FloatTimer;
    private bool m_Direction;
    // Use this for initialization
    void Start()
    {
        m_FloatTimer = 0.0f;
        m_Direction = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (m_FloatTimer >= m_FloatTime)
        {
            m_Direction = !m_Direction;
            m_FloatTimer = 0.0f;
        }

        if (m_Direction)
        {
            transform.position += new Vector3(0.0f, m_FloatSpeed * Time.deltaTime);
        }
        else
        {
            transform.position += new Vector3(0.0f, -m_FloatSpeed * Time.deltaTime);
        }


        m_FloatTimer += Time.deltaTime;
    }
}
