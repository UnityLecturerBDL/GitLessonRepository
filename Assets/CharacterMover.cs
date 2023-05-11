using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position += Vector3.right * 10;
        }

        transform.position -= Vector3.up * (9.8f * Time.deltaTime);
    }
}
