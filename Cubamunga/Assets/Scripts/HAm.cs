using UnityEngine;

public class HAm : MonoBehaviour
{
    private Animator animator;
    public float offset;

    void Start()
    {
        animator = GetComponent<Animator>();

        animator.Play("Moving", 0, offset);
    }


}
