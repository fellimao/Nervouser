using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIon : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector2.up * speed * Time.deltaTime);
    }
    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "Proteina")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
