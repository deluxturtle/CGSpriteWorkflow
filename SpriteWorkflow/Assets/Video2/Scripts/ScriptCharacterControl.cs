using UnityEngine;
using System.Collections;

/// <summary>
/// @Author:Andrew Seba
/// @Description: Controls animation and moves character.
/// </summary>
public class ScriptCharacterControl : MonoBehaviour {

    public float speed = 3f;

    private Animator animator;
    private Vector3 screenSW;
    private Vector3 screenNE;
    private float wrapPadding = 1;


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();

        screenSW = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.localPosition.z));
        screenNE = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.localPosition.z));

	}
	
	// Update is called once per frame
	void Update ()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if(verticalInput < 0)
        {
            //walk foward
            animator.SetInteger("Direction", 0);
        }
        else if(verticalInput > 0)
        {
            animator.SetInteger("Direction", 1);
        }

        if(horizontalInput < 0)
        {
            animator.SetInteger("Direction", 2);
        }
        else if(horizontalInput > 0)
        {
            animator.SetInteger("Direction", 3);
        }
	}
}
