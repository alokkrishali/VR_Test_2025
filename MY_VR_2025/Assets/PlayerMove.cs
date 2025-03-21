using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform camera;
    [SerializeField] float Speed = 10;

    bool CanMove = true; 
    public void OnBtnPress()
    {
        CanMove = !CanMove;
    }

    // Update is called once per frame
    void Update()
    {
        if(CanMove)
        transform.Translate(camera.forward*Speed*Time.deltaTime);
    }

}
