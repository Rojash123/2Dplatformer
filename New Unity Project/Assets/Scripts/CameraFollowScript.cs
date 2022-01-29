using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(2,10)]
    public float smoothFactor;

    void FixedUpdate()
    {
        Follow();
    }

    private void Follow(){
        Vector3 targetpos = target.position + offset;
        Vector3 smoothpos = Vector3.Lerp(transform.position, targetpos, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothpos;
    }
}
