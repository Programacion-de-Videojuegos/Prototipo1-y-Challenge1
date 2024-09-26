using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float velocidad = 30;
    public float inputForward;
    public float inputGiro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputForward = Input.GetAxis("Vertical");
        inputGiro = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*inputForward);
        transform.Rotate(Vector3.up, Time.deltaTime*80*inputGiro);
    }
}
