# UnityLootGenerator Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

The purpose of the program is to provide a fun game.

**TODO: Complete this section**

### 3a ii.

Describes what functionality of the program is demonstrated in the video.


The video demonstrates that my program can generate a random sprite depending on user input.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

The input of the program is the user pressing a button and the outputs are sprites derived from three sets of lists

**TODO: Complete this section**

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.



### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
public List <GameObject> JordanShoes = new List<GameObject>();
//...
 foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Jordans"))
{
    JordanShoes.Add(obj);
}
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (GameObject shoe in JordanShoes)
{
    shoe.SetActive(false);
}
```
?
### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

JordanShoes is the name of the list being used.

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all the possible shoe sprites that can be generated.



### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.



Without a list, the complexity of my program would greatly increase because I would have to create a variable for every single sprite that I would want to add and I would not be able to write a loop that generalizes my code to a single line. It also makes it easy to add new shoes without changing any code.

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
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
public void OnClickButton1(string shoeType)
{
    SetShoes(shoeType);
}
```
?
### 3c iii. 

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program. 

Given a game object, new sprite is passed in and turns off all shoe sprites. Then after that, a random shoe is generated from the JordanShoes list and that shoe is set active. When the user clicks this button, the method gets called. This Contributes to my functionality because it is used every time the user clicks the button.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Checks if a sprite is present and if not, an exception is thrown
2. If a sprite is present, then for each shoe GameObject in MeleeWeapons, all other weapons get set to inactive.
3. Create a random sprite generator.
4. Generate a random shoe sprite.
5. Display it on the unity avatar.




## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.


SetShoes(null);


Second call:
SetShoes(RedShoesObject);


**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:

This tests that my method properly validates the input parameter and fails with an invalid input.
 
**TODO: Complete this section**

Condition(s) tested by the second call:

This tests that the method executes properly given a valid input.



### 3d iii.

Result of the first call:

The result of the first call is that sprites are null and that an exception is being thrown.


**TODO: Complete this section**

Result of the second call:
The result of calling would randomly select a sprite



**TODO: Complete this section**