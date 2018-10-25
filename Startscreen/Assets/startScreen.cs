using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startScreen : MonoBehaviour {
    public GameObject button;
public void buttonEvent()
    {
        if (button.activeSelf)
        {
            button.SetActive(false);
        }
        else
            button.SetActive(true);
    }
}
