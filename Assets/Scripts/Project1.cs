using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Project1 : MonoBehaviour
{
    public GameObject x;
    private void OnCollisionEnter(Collision collision)
    {
       x.SetActive(true);
    }
    private void OnCollisionExit(Collision collision)
    {
       x.SetActive(false);
    }
}
