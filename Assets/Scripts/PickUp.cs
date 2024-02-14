using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    void Update()
    {
        Rotation();
    }

    public void Rotation()
    {
        transform.Rotate(new Vector3(5f, 5f, 5f) * Time.deltaTime * 15f);
    }

    public virtual void Picked()
    {
        Debug.Log("Podnios³em");
        Destroy(this.gameObject);
    }
}
