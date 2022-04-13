using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public SpriteRenderer WeaponRenderer;
    public List <GameObject> RangeWeapons = new List<GameObject>();
    public List <GameObject> MeleeWeapons = new List<GameObject>();
    public List <GameObject> FillInShoes = new List<GameObject>();
    public List <GameObject> DifferentShoes = new List<GameObject>();


    public void OnClickButton1(string shoeType)
    {
        SetArmor(shoeType);
    }
    public void OnClickButton(string weaponType)
    {
        /// <summary>
        /// A method that is called when the user clicks a button and then prints a sprite on the users interface.
        /// </summary>
        /// <param name="newSprite"></param>
        SetWeapon(weaponType);
        /// SetArmor(armorType);

    }


    public void SetWeapon(string weaponType)
    {
        /// <summary>
        /// This method checks if there is an image to be shown and if not, the system throws an exception. 
        /// Then all other weapons are turned off and are not displayed except the singular range or melee game object that gets called.
        /// </summary>
        /// <param name="newSprite"></param>

        if (weaponType == null )
        {
             throw new System.Exception("bro where the object at");
        }
        foreach (GameObject weapon in MeleeWeapons)
        {
            weapon.SetActive(false);
        }

        foreach (GameObject weapon in RangeWeapons)
        {
            weapon.SetActive(false);
        }

        System.Random generator = new System.Random();

        if (weaponType == "melee") 
        {
            int index = generator.Next(0, MeleeWeapons.Count);
            MeleeWeapons[index].SetActive(true);
        } 
        else 
        {
            int index1 = generator.Next(0, RangeWeapons.Count);
            RangeWeapons[index1].SetActive(true);
        }
    }

    public void SetArmor(string armorType)
    {
        foreach(GameObject armor in FillInShoes)
        {
            armor.SetActive(false);
        }
        foreach (GameObject armor in DifferentShoes)
        {
            armor.SetActive(false);
        }

        System.Random generator1 =  new System.Random();
        if (armorType == "cartoon")
        {
            int index2 = generator1.Next(0, FillInShoes.Count);
            FillInShoes[index2].SetActive(true);
        }
        else 
        {
            int index3 =  generator1.Next(0, DifferentShoes.Count);
            DifferentShoes[index3].SetActive(true);
        }
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

        foreach(GameObject obj in GameObject.FindGameObjectsWithTag(""))
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
