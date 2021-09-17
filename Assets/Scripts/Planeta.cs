using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    public float velocidad = 50.0f;
    private int flag = -1;
    private GameObject text;
    private TextMesh tm;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("Texto");
        tm = text.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            flag = 1;
            tm.text = "Izquierda";
            tm.color = Color.blue;
        }
        if (flag==1)
        {
            transform.Rotate(0, velocidad * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            flag = 0;
            tm.text = "Derecha";
            tm.color = Color.yellow;
        }
        if (flag == 0)
        {
            transform.Rotate(0, velocidad * Time.deltaTime*-1, 0);
        }
    }
           
}
