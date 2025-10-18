using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private float _xspeed;
    private float _yspeed;
    public float speed = 3;
    private string Input = "horizontal";

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
        _xspeed = Input.GetAxis("horizontal");
        _xspeed = Input.GetAxis("Vertical");
        _rigidbody2D.velocity = Vector2(_xspeed, _yspeed) * speed;
    }
}
