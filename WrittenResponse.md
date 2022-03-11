# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

to let a person Generate a random type of weapon of their choice

**TODO: Complete this section**

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can generate a list of random loot

The video demonstrates that my program can generate a random sprite depending on user input.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

The input of the program is the user pressing a button and the outputs are sprites derived from two sets of lists

**TODO: Complete this section**

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.



### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
 foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Weapon"))
       {
           AllWeapons.Add(obj);
       }
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (GameObject weapon in AllWeapons)
        {
            weapon.SetActive(false);
        }
```
?
### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

AllWeapons is the name of the list being used.

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all the possible weapon sprites that can be generated.



### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.



Without a list, the complexity of my program would greatly increase because I would have to create a variable for every single sprite that I would want to add and I would not be able to write a loop that generalizes my code to a single line. It also makes it easy to add new weapons without changing any code.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
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

        foreach (GameObject weapon in RangeWeapons)
        {
            weapon.SetActive(false);
        }

        int index1 = generator.Next(0, RangeWeapons.Count);
        RangeWeapons[index1].SetActive(true);
    }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 public void OnClickButton(GameObject sprite)
    {
        SetWeapon(sprite);
    }
```
?
### 3c iii. 

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program. 

Given a game object, new sprite is passed in and turns off all weapon sprites. Then after that, a random weapon is generated from the AllWeapons list and that weapon is set active. 
?
### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Prompts the user to select projectile weapon or melee weapon
2. Loads a list of possible projectile weapons 
3. Loads a list of possible melee weapons 
4. Randomly selects a  projectile weapon if the user selects projectile weapon
5. Randomly selects a melee weapon if the user selects melee weapon 
6. Shows the randomly generated weapon in unity
7. If more weapons need to be generated, go to step 1


## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.


SetWeapon(null);
**TODO: Complete this section**

Second call:
SetWeapon(DaggerObject);


**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:

I am testing if the prompt the user has inputted is null. This will cause the body of the if statement to execute.
 
**TODO: Complete this section**

Condition(s) tested by the second call:

I am testing if the prompt the use has inputted is not null. THis will skip the body of the if statement.

**TODO: Complete this section**

### 3d iii.

Result of the first call:



**TODO: Complete this section**

Result of the second call:



**TODO: Complete this section**