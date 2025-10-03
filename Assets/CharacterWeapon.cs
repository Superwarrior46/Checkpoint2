using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
    private GrabWeapon grabWeapon;
    void Awake()
    {
        grabWeapon = GameObject.FindGameObjectWithTag("Player").GetComponent<GrabWeapon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            grabWeapon.WeaponActive();
            Destroy(gameObject);
        }
    }
}
