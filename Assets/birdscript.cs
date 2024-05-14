using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class birdscript : MonoBehaviour
{
    private InputAction tapAction;
    private InputAction spaceAction;
    public Rigidbody2D myrigidbody;
    public float flapStregth;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "bob bird";
    }

    private void Awake()
    {
        // Create the input action instance
        tapAction = new InputAction("Tap", binding: "<Pointer>/press");
        //spaceAction = new InputAction("Space", binding: "<Keyboard>/space");

        tapAction.performed += _ => OnTap();
        //spaceAction.performed += _ => OnSpace();
    }

    private void OnEnable()
    {
        tapAction.Enable();
        //spaceAction.Enable();
    }

    private void OnDisable()
    {
        tapAction.Disable();
        //spaceAction.Disable();
    }

    private void OnTap()
    {
        // When tapped on the screen, apply force to make the bird fly
        myrigidbody.velocity = Vector2.up * flapStregth;
    }
    /*private void OnSpace()
    {
        // When tapped on the screen, apply force to make the bird fly
        myrigidbody.velocity = Vector2.up * flapStregth;
    }*/
    // Update is called once per frame
    // Add your update logic here
}


