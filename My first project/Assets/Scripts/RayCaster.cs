using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // get center of the screen
            Vector3 centerPoint = new Vector3(_camera.pixelWidth / 2, _camera.scaledPixelHeight / 2, 0);
            // create a ray through the center of the screen
            Ray ray = _camera.ScreenPointToRay(centerPoint);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10.0f, 1))
            {
                StartCoroutine(PlaceHitIndicator(hit.point));
            }
        }   
    }

    private IEnumerator PlaceHitIndicator(Vector3 hitPoint)
    {
        // create a new Sphere game object
        GameObject hitIndicator = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hitIndicator.transform.position = hitPoint;

        yield return new WaitForSeconds(1.0f);

        Destroy(hitIndicator);
    }
}
