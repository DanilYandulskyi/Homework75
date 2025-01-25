using UnityEngine;

public class Flag : MonoBehaviour, IUnitTarget
{
    public Transform Transform => transform;

    public void SetPosition(Vector3 position)
    {
        gameObject.SetActive(true);
        Transform.position = position;
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }

    public Flag Spawn(Vector3 position)
    {
        return Instantiate(this, position, Quaternion.identity);
    }
}
