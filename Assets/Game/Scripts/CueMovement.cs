using UnityEngine;

public class CueMovement : MonoBehaviour
{
    [SerializeField] Rigidbody m_Rigidbody;
    [SerializeField] private float BallVelocity;
    private bool _isBallMove = false;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDir = mousePos - gameObject.transform.position;

        if (!_isBallMove && Input.GetMouseButtonDown(0))
        {
            m_Rigidbody.AddForce(-mouseDir * BallVelocity);
        }

        SetCueActive(m_Rigidbody.velocity.magnitude == 0);
    }

    private void SetCueActive(bool isActive)
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(isActive);
        _isBallMove = !isActive;
    }
}