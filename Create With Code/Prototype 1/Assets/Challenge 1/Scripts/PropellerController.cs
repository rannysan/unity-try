using UnityEngine;

public class PropellerController : MonoBehaviour
{
    private float turnSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 10), turnSpeed * Time.deltaTime);
    }
}
