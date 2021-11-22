using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public bool isSelected = false;

    Rigidbody r;
    // Start is called before the first frame update
    
    void Start()
    {
        r = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSelected)
            return;

        if (Input.GetKey(KeyCode.A)) {
            r.AddForce(Vector3.left * 10 * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D)) {
            r.AddForce(Vector3.right * 10 * Time.deltaTime, ForceMode.Impulse);
        }


        bool active = Input.GetMouseButtonUp(0);
        if (active) {
            //r.AddForce(Vector3.forward, ForceMode.Impulse);
        }
    }
}
