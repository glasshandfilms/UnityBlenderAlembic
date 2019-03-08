using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlenderShapes : MonoBehaviour
{
    SkinnedMeshRenderer thisSkinnedMeshRenderer;

    void Start()
    {
        thisSkinnedMeshRenderer = this.gameObject.GetComponent<SkinnedMeshRenderer>();
        StartCoroutine(ShapeKeyAnimation());
    }

    

    IEnumerator ShapeKeyAnimation()
    {
        for(float i = 0.0f; i<100.0f; i += 1.0f)
        {
            thisSkinnedMeshRenderer.SetBlendShapeWeight(0, i);
            yield return new WaitForSeconds(0.02f);
        }

        for(float i = 0.0f; i < 100.0f; i += 1.0f)
        {
            thisSkinnedMeshRenderer.SetBlendShapeWeight(0, 100 - i);
            yield return new WaitForSeconds(0.02f);
        }
        StartCoroutine(ShapeKeyAnimation());
    }
}
