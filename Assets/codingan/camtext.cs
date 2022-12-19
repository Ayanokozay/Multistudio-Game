using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camtext : MonoBehaviour
{
    public GameObject Camtext;

    public void Start()
    {
        Camtext.SetActive(false);
    }

    public void OnMouseOver()
    {
        Camtext.SetActive(true);
    }

    public void OnMouseExit()
    {
        Camtext.SetActive(false);
    }

}
