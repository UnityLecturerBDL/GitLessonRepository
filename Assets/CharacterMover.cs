using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position += Vector3.right * 10;
        }
    }
}
