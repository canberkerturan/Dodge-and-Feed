using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontallInput;
    // Start is called before the first frame update
    void Start()
    {
        horizontallInput = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
