using UnityEngine;

public class AnimationOffset : MonoBehaviour
{
    private Animator animator;
    public float offset;

    void Start()
    {
        animator = GetComponent<Animator>();

        animator.Play("Moving_Obstacle", 0, offset);
    }


}
