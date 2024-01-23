using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiPoint : MonoBehaviour
{
    AddPoint addPoint;

    public TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       textScore.text = "" + addPoint.newScore; 
    }
}
