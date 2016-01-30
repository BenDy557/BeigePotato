using UnityEngine;
using System.Collections;

public class Inevitability : MonoBehaviour {

    public int m_ForLife;
    public int m_ForDeath;

    private bool LifeButtonCurr;
    private bool LifeButtonPrev;

    private bool DeathButtonCurr;
    private bool DeathButtonPrev;


    public float m_DeathPercentage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        LifeButtonPrev = LifeButtonCurr;
        DeathButtonPrev = DeathButtonCurr;

        if (Input.GetAxis("Vote") > 0)
        {
            LifeButtonCurr = true;
        }
        else
        {
            LifeButtonCurr = false;
        }

        if (Input.GetAxis("Vote") < 0)
        {
            DeathButtonCurr = true;
        }
        else
        {
            DeathButtonCurr = false;
        }

        if (LifeButtonCurr == false && LifeButtonPrev == true)
        {
            m_ForLife++;
        }

        if (DeathButtonCurr == false && DeathButtonPrev == true)
        {
            m_ForDeath++;
        }


        float difference = m_ForDeath - m_ForLife;
        if (difference < 0)
        {
            difference = 0;
        }

        m_DeathPercentage = (float)((difference * 10) + (m_ForDeath * 0.1));

	}
}
