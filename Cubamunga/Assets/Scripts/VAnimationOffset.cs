using UnityEngine;

public class VAnimationOffset : MonoBehaviour
{
    private Animator animator;
    public float offset;

    void Start()
    {
        animator = GetComponent<Animator>();

        animator.Play("Moving_Obstacle2", 0, offset);

    }

}
