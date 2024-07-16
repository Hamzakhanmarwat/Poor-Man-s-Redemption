using UnityEngine;

public class Animator 
{
    private Animator _animator;

    private int _idel = Animator.StringtoHash("Idel");
    public characterAnimationController(Animator animator) => _animator = animator;
}
