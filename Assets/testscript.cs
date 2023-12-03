using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    public float Value = 0.1f;
    public Color color = Color.white;
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 5)
        {
            flag = true;
        }
        else if (transform.position.x < -5)
        {
            flag = false;
        }

        float direction = flag ? -1 : 1; 

        transform.position += new Vector3(Value*direction, 0, 0);

  

    }
}
