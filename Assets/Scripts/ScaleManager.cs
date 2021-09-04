using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleManager : MonoBehaviour
{
    [SerializeField] List<GameObject> Targets;
    [SerializeField] float Scale = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // update the game object scales
        foreach(var target in Targets)
        {
            var scaleableInterface = target.GetComponent<IScaleable>();

            if (scaleableInterface != null)
                scaleableInterface.SetScale(Scale);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
