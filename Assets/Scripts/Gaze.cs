using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{
    //List<InfoBehaviour> infos = new List<InfoBehaviour>();

    public GameObject AK;
    public GameObject M4A1;

    private void Start()
    {
        //infos = FindObjectsOfType<InfoBehaviour>().ToList();
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if(go.CompareTag("AK"))
            {
                Debug.Log("AK");
                M4A1.gameObject.SetActive(false);
                AK.gameObject.SetActive(true);
            }
            else if (go.CompareTag("M4A1"))
            {
                Debug.Log("M4A1");
                AK.gameObject.SetActive(false);
                M4A1.gameObject.SetActive(true);
            }
        }
        /**else
        {
            CLoseAll();
        }*/
    }

    /*void OpenInfo(InfoBehaviour desiredInfo)
    {
        foreach(InfoBehaviour info in infos)
        {
            if(info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CLosedInfo();
            }
        }
    }

    void CLoseAll()
    {
        foreach(InfoBehaviour info in infos)
        {
            info.CLosedInfo();
        }
    }*/
}
