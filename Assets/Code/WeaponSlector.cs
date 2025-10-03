using UnityEngine;

public class WeaponSlector : MonoBehaviour
{
    [SerializeField] private WeaponCollection _player;

    public void SetWeapon(int index)
    {
        _player.Seleccion(index);
    }
}