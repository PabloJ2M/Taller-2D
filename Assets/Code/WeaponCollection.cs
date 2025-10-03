using UnityEngine;

public class WeaponCollection : MonoBehaviour
{
    [SerializeField] private Transform _hands;
    [SerializeField] private GameObject[] _weapons;

    public void Seleccion(int index)
    {
        if (_hands.childCount > 0)
            Destroy(_hands.GetChild(0).gameObject);

        Transform weapon = Instantiate(_weapons[index], _hands).transform;
        weapon.localPosition = Vector3.zero;
    }
}