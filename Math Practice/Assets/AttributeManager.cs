using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AttributeManager : MonoBehaviour
{
    static public int INVISIBLE = 1;
    static public int FLY = 2;
    static public int CHARISMA = 4;
    static public int INTELLIGENCE = 8;
    static public int MAGIC = 16;

    public Text attributeDisplay;
    public int attributes = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MAGIC KEY"))
        {
            attributes |= (MAGIC);
        }
        else if (other.CompareTag("INTELLIGENCE KEY"))
        {
            attributes |= (INTELLIGENCE);
        }
        else if (other.CompareTag("FLY KEY"))
        {
            attributes |= (FLY);
        }
        else if (other.CompareTag("GOLD KEY"))
        {
            attributes |= (MAGIC | INTELLIGENCE | FLY | CHARISMA | INVISIBLE);
        }
    }
}
