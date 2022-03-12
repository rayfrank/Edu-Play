using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collusion : MonoBehaviour
{
    public Text cartext;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cartext.text="You hit another car...dangerous driving";
        }
    }
}
