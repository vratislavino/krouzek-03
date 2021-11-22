using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GraphicsChanger))]
public class PlayerSelection : MonoBehaviour
{
    Camera cam;
    GraphicsChanger graphicsChanger;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        graphicsChanger = GetComponent<GraphicsChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 50f)) {

                var playerControls = hit.collider.GetComponent<PlayerControls>();
                if(playerControls) {
                    graphicsChanger.SelectPlayer(playerControls);
                }

                /*if(hit.rigidbody) {
                    hit.rigidbody.AddForce(Vector3.forward*10f,ForceMode.Impulse);
                }*/
            }
        }
        
    }
}
