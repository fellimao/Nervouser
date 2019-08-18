using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapIon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Ion-Azul")
        {
            if (Input.GetKey(KeyCode.A)){
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.tag == "Ion-Amarelo")
        {
            if (Input.GetKey(KeyCode.S))
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.tag == "Ion-Verde")
        {
            if (Input.GetKey(KeyCode.D))
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.tag == "Ion-Vermelho")
        {
            if (Input.GetKey(KeyCode.J))
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.tag == "Ion-Rosa")
        {
            if (Input.GetKey(KeyCode.K))
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.tag == "Ion-Laranja")
        {
            if (Input.GetKey(KeyCode.L))
            {
                Destroy(col.gameObject);
            }
        }
    }
}
