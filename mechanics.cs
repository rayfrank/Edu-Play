using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mechanics : MonoBehaviour
{
    // Start is called before the first frame update
    public Text cartext;
    void Start()
    {
        StartCoroutine(car());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator car()
    {
        cartext.text = "Welcome to driving";
        yield return new WaitForSeconds(6f);
        cartext.text = "make sure you avoid colliding with other cars and drive safe";
        yield return new WaitForSeconds(6f);
        cartext.text = "first let us start with parking";
        yield return new WaitForSeconds(4f);
        cartext.text = "park the car on the parking spot ";

    }
}
