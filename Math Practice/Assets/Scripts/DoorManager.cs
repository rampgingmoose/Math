using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] int doorType = 0;

    private void Start()
    {
        SetDoorType();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.GetComponent<AttributeManager>().attributes & doorType) == doorType)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<BoxCollider>().isTrigger = false;
        other.gameObject.GetComponent<AttributeManager>().attributes &= ~doorType;
    }

    private void SetDoorType()
    {
        if (this.gameObject.tag == "MAGIC DOOR") doorType = AttributeManager.MAGIC;
        if (this.gameObject.tag == "INTELLIGENCE DOOR") doorType = AttributeManager.INTELLIGENCE;
        if (this.gameObject.tag == "FLY DOOR") doorType = AttributeManager.FLY;
    }
}
