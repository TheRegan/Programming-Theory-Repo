using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchableObject : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField] private int m_PointValue;
    public virtual int PointValue
    {
        get { return m_PointValue; }
        private set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative point value!");
            }
            else
            {
                m_PointValue = value;
            }
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        ClassifyTriggerEntered(other);
    }

    //ABSTRACTION
    public virtual void ClassifyTriggerEntered(Collider triggerEntered)
    {
        if (triggerEntered.CompareTag("Player"))
        {
            CaughtObject();
            return;
        }
        if (triggerEntered.CompareTag("Respawn"))
        {
            ObjectFellIntoTheVoid();
            return;
        }
    }

    public virtual void CaughtObject()
    {
        addPoints();
        deactivate();
    }

    public virtual void ObjectFellIntoTheVoid()
    {
        deactivate();
    }

    private void addPoints()
    {
        Counter.Instance.IncreaseScore(PointValue);
    }

    private void deactivate()
    {
        gameObject.SetActive(false);
    }
}
