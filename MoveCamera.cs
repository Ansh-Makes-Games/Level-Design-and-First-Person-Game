using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform playerHeadForTheCameraToFollow;

    private void Update()
    {
        transform.position = playerHeadForTheCameraToFollow.transform.position;
    }
}
