using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{
    [SerializeField]
    Transform SectionInfo;

    Vector3 DesiredScale = Vector3.zero;

    const float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, DesiredScale, Time.deltaTime * speed);
    }

    public void OpenInfo()
    {
        DesiredScale = Vector3.one;
    }

    public void CLosedInfo()
    {
        DesiredScale = Vector3.zero;
    }
}
