using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour
{
    public Animator AnimationController;

    // Use this for initialization
    void Start()
    {
        AnimationController = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AnimationController.Play("playeridle");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AnimationController.Play("Run");
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            AnimationController.Play("Jump");
        }
        
    }
}
