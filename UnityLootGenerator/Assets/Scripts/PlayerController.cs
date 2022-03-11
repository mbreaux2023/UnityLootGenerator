using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public SpriteRenderer WeaponRenderer;
    public List <GameObject> RangeWeapons = new List<GameObject>();
    public List <GameObject> AllWeapons = new List<GameObject>();

    public void OnClickButton(GameObject sprite)
    {
        SetWeapon(sprite);
    }

/// <summary>
/// Given a game object, new sprite is passed in and turns off all weapon sprites. Then after that, a random weapon is generated from the AllWeapons list and that weapon is set active.
/// </summary>
/// <param name="newSprite"></param>
    public void SetWeapon(GameObject newSprite)
    {
        if (newSprite == null )
        {
            throw new System.Exception("bro where the object at");
        }

        
        foreach (GameObject weapon in AllWeapons)
        {
            weapon.SetActive(false);
        }
        System.Random generator = new System.Random();
        int index = generator.Next(0, AllWeapons.Count);
        AllWeapons[index].SetActive(true);
        // newSprite.SetActive(true);

        foreach (GameObject weapon in RangeWeapons)
        {
            weapon.SetActive(false);
        }

        int index1 = generator.Next(0, RangeWeapons.Count);
        RangeWeapons[index1].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
       foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Weapon"))
       {
           AllWeapons.Add(obj);
       }

        foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Projectile"))
        {
            RangeWeapons.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
