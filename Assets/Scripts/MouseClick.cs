using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform _point;

    Vector3 _mousePoint;
    Vector3 _moveMousePoint;

    // Update is called once per frame
    void Update()
    {
        getMousePosition();
        MoveRedDot();
    }

    void getMousePosition()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _mousePoint = Input.mousePosition;

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(_mousePoint);

            

            if(Physics.Raycast(ray, out hit))
            {
                _moveMousePoint = hit.point;

                Debug.DrawRay(ray.origin, ray.direction * 11, Color.blue, 5);

                if (_moveMousePoint.y <= 1)
                {
                    _moveMousePoint.y = 1.1f;
                }
            }
        }
    }

    void MoveRedDot()
    {
        _point.position = _moveMousePoint;
    }


}
