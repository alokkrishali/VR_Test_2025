using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMove : MonoBehaviour
{
    [SerializeField]
    Transform spiderTransform;
    [SerializeField] float Speed = 10;

    [SerializeField] Transform [] targetPos;
    private int targetIndex = 0;


    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(spiderTransform.position, targetPos[targetIndex].position)<1)
        {
            targetIndex++;
            if(targetIndex>2)
                targetIndex = 0;
        }
        spiderTransform.position = Vector3.MoveTowards(spiderTransform.position, targetPos[targetIndex].position, Speed*Time.deltaTime);
        spiderTransform.LookAt(targetPos[targetIndex]);
    }
}
