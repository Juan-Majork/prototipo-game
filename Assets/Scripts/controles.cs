using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles : MonoBehaviour
{
    [SerializeField] public Transform spawnUp;
    [SerializeField] public Transform spawnDown;
    [SerializeField] public Transform spawnLeft;
    [SerializeField] public Transform spawnRight;
    [SerializeField] public GameObject escoba;

    [SerializeField] public Vector2 velocidad;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * Time.deltaTime * velocidad.x, verticalInput * Time.deltaTime * velocidad.y, 0);

        if(verticalInput > 0)
        {
            animator.SetBool("WalkUp", true);
        }
        else
        {
            animator.SetBool("WalkUp", false);
        }
        if (verticalInput < 0)
        {
            animator.SetBool("WalkDown", true);
        }
        else
        {
            animator.SetBool("WalkDown", false);
        }
        if (horizontalInput > 0)
        {
            animator.SetBool("WalkRight", true);
        }
        else
        {
            animator.SetBool("WalkRight", false);
        }
        if (horizontalInput < 0)
        {
            animator.SetBool("WalkLeft", true);
        }
        else
        {
            animator.SetBool("WalkLeft", false);
        }

        if (Input.GetKeyDown("p") && verticalInput > 0)
        {
            Instantiate(escoba, spawnUp);
        }
        else if (Input.GetKeyDown("p") && verticalInput < 0)
        {
            Instantiate(escoba, spawnDown);
        }
        else if (Input.GetKeyDown("p") && horizontalInput > 0)
        {
            Instantiate(escoba, spawnRight);
        }
        else if (Input.GetKeyDown("p") && horizontalInput < 0)
        {
            Instantiate(escoba, spawnLeft);
        }
    }

}
