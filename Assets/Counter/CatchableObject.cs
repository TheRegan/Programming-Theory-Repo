using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchableObject : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField] private int m_PointValue;
    public int PointValue
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

    //ABSTRACTION
    public virtual void addPoints()
    {
        //TODO: add points to Counter.cs
    }

    //ABSTRACTION
    private void deactivate()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            addPoints();
            deactivate();
        }   
    }
}
