using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Camera _Camera;

    private string CameraName = "Game_Camera";
    
    private Vector3 _PositionMause;



    private void Start()
    {
        _Camera = GameObject.Find(CameraName).GetComponent<Camera>();
    }

    private void Update()
    {
        _PositionMause = _Camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pos = _PositionMause - transform.position;

        float rot2 = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rot2 - 90);
    }
}