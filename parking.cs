using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class parking : MonoBehaviour
{
    public Text cartext;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cartext.text = "you are a little off try again";
        }
    }
}
