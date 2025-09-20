using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveX * moveSpeed * Time.deltaTime);
    }
}
