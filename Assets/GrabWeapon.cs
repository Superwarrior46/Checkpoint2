using UnityEngine;

public class GrabWeapon : MonoBehaviour
{
    [SerializeField]private GameObject weapon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WeaponActive()
    {
        weapon.SetActive(true);
    }
}
