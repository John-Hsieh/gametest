using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class checkVisible
{
    // Start is called before the first frame update
    public static bool isVisibleFrom(this Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
}
