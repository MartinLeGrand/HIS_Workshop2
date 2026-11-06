using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
