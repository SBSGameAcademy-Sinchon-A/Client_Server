using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{
    public bool isMove;

    public Vector2 smoothInputVelocity;
    public Vector2 moveVector;
    public Vector2 curVector;

    public float smoothRatio;

    private void FixedUpdate()
    {
        curVector = Vector2.SmoothDamp(curVector, moveVector, ref smoothInputVelocity, smoothRatio);

        Vector3 destination = new Vector3(curVector.x, 0, curVector.y) + transform.position;

        transform.DOMove(destination, 1f);
    }

    public void OnMove(InputValue value)
    {
        moveVector = value.Get<Vector2>();
    }
}
