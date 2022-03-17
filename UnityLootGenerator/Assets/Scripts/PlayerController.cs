using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public SpriteRenderer WeaponRenderer;
    public List <GameObject> RangeWeapons = new List<GameObject>();
    public List <GameObject> MeleeWeapons = new List<GameObject>();

    public void OnClickButton(GameObject sprite)
    {
        /// <summary>
        /// A method that is called when the user clicks a button and then prints a sprite on the users interface.
        /// </summary>
        /// <param name="newSprite"></param>
        SetWeapon(sprite);
    }


    public void SetWeapon(GameObject newSprite)
    {
        /// <summary>
        /// This method checks if there is an image to be shown and if not, the system throws an exception. 
        /// Then all other weapons are turned off and are not displayed except the singular range or melee game object that gets called.
        /// </summary>
        /// <param name="newSprite"></param>
        if (newSprite == null )
        {
            throw new System.Exception("bro where the object at");
        }

        
        foreach (GameObject weapon in MeleeWeapons)
        {
            weapon.SetActive(false);
        }
        System.Random generator = new System.Random();
        int index = generator.Next(0, MeleeWeapons.Count);
        MeleeWeapons[index].SetActive(true);
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
           MeleeWeapons.Add(obj);
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
