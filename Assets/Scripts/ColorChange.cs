using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void changeToAnchorColor(GameObject obj)
    {
        obj.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
    }
}
