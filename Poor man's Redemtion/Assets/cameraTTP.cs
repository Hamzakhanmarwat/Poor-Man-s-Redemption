using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTTP : MonoBehaviour
{
    public Transform player;
    public Vector3 Offset;
    void Update()
    {
        transform.position = player.position + Offset;
        
    }
}
