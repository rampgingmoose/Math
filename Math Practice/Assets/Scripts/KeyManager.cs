using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    [SerializeField] int keyType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<AttributeManager>() != null)
        {
            other.gameObject.GetComponent<AttributeManager>().attributes |= keyType;
        }
    }
}
