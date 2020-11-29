using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject[] panels = new GameObject[2];
    public GameObject backButton;

    void Start()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
        backButton.SetActive(false);
    }

    public void OnClickCrewButton()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(true);
        backButton.SetActive(true);
    }
    public void OnClickBackButton()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
        backButton.SetActive(false);
    }
}
