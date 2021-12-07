using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private float x;
    private float y;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("DeathAnim");
        x = Random.Range(-4.0f, 4.1f);
        y = Random.Range(-4.0f, 4.1f);
    }

    private void Update()
    {
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);        
    }
}
