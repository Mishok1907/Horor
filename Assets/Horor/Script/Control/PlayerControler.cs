
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerControler : MonoBehaviour
{
    private CharacterController _controller;
    private float speedPlayer = 5.3f;
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 deirection = new Vector3(0,0,1) * vertical + new Vector3(1,0,0) * horizontal;
        deirection.y -= 9.81f * Time.deltaTime;
        _controller.Move(deirection * speedPlayer * Time.deltaTime);
    }
}
