using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public float pos;
    public Color critickColor;
    public Color weakColor;
    void Awake()
    {
        pos = GetComponent<Transform>().position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.15f, 1.15f, 0) * Time.deltaTime;
        transform.localScale += new Vector3(0.1f, 0.1f, 0) * Time.deltaTime;
        if (transform.position.y > 1f + pos)
            Destroy(gameObject);
    }
}
