using UnityEngine;
using System.Collections;

public class ActionTrigger : MonoBehaviour {

    public enum actionNames{wakeUp,bathroom,commuteWork,work,commuteHome,goToBed};
    public actionNames m_ActionName;

    public GameObject m_ArrowButton;
    private GameObject m_ArrowButtonTemp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            ShowButton();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            HideButton();
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                DoAction();
            }
        }
    }

    void ShowButton()
    {
        m_ArrowButtonTemp = Instantiate<GameObject>(m_ArrowButton);
        m_ArrowButtonTemp.transform.position = transform.position + new Vector3(0.0f, 2.0f, 0.0f);
    }

    void HideButton()
    {
        Destroy(m_ArrowButtonTemp);
    }

    void DoAction()
    {

        switch (m_ActionName)
        {
            case actionNames.wakeUp:
                Debug.Log("WakeUp");
                break;
            case actionNames.bathroom:
                Debug.Log("bathroom");
                break;
            case actionNames.commuteWork:
                Debug.Log("commute work");
                break;
            case actionNames.work:
                Debug.Log("work");
                break;
            case actionNames.goToBed:
                Debug.Log("gotobed");
                break;
            default:
                break;
        }

    }
}
