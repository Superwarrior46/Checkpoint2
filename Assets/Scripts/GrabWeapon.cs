using UnityEngine;

public class GrabWeapon : MonoBehaviour
{
    [SerializeField]private GameObject weapon;

    public void WeaponActive()
    {
        weapon.SetActive(true);
    }
}
