using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public SpriteRenderer WeaponRenderer;
    public List <GameObject> RangeWeapons = new List<GameObject>();
    public List <GameObject> MeleeWeapons = new List<GameObject>();
    public List <GameObject> JordanShoes = new List<GameObject>();



   
    public void OnClickButton(string weaponType)
    {
        /// <summary>
        /// A method that is called when the user clicks a button and then prints a sprite on the users interface.
        /// </summary>
        /// <param name="newSprite"></param>
        SetWeapon(weaponType);
        /// SetArmor(armorType);

    }

    public void OnClickButton1(string shoeType)
    {
        SetShoes(shoeType);
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

    public void SetShoes(string shoeType)
    {
        /// <summary>
        /// This method checks if there is an image to be shown and if not, the system throws an exception. 
        /// Then all other shoes are turned off and are not displayed except the singular pair of shoes game object that gets called.
        /// </summary>
        /// <param name="shoeType"></param>


        if (shoeType == null )
        {
            throw new System.Exception("again where ya shoes at.");
        }

        foreach(GameObject shoe in JordanShoes)
        {
            shoe.SetActive(false);
        }

        System.Random generator1 =  new System.Random();
        if (shoeType == "jordans")
        {
            int index2 = generator1.Next(0, JordanShoes.Count);
            JordanShoes[index2].SetActive(true);
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

        foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Jordans"))
        {
            JordanShoes.Add(obj);   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
