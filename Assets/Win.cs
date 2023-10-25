using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text text;
    private bool _firstWinner = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (_firstWinner == false)
        {
            _firstWinner = true;
            if (collision.transform != null)
            {
                text.text = "Winner: " + collision.transform.name;
            }
        }
        
    }
}
