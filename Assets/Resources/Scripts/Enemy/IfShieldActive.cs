using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfShieldActive : MonoBehaviour
{
    private void Update()
    {
        var rigid = gameObject.GetComponent<BoxCollider2D>();
        if (Score._shield == true)
        {
            rigid.enabled = false;
        }
        else if (Score._shield == false)
        {
            rigid.enabled = true;
        }
    }
}
