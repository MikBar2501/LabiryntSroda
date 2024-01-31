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
        transform.Rotate(new Vector3(0, 5f, 0));
    }

    public virtual void Picked()
    {
        Debug.Log("Podnios�em");
        Destroy(this.gameObject);
    }
}
