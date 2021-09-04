using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TransformExtensions;

public class CubeController : MonoBehaviour, IScaleable
{
    [SerializeField] Transform Target;
    [SerializeField] float Speed = 2f;

    public float GetScale()
    {
        return transform.localScale.magnitude;
    }

    public void SetScale(float newScale)
    {
        transform.localScale = Vector3.one * newScale;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);

        transform.MoveTowards(Target, Speed);
    }
}
