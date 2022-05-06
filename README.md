# ALootGenerator

## Description 
The Unity Loot Generator is used to generate a list of possible loot. It uses projectile weapon types melee weapon types to generate a random type of weapon that the user desires and a visual for it.

## Overview
The purpose of A Loot Generator is to provide entertainment to the user by creating unique weapon loot. It accepts input from the user by letting them specify which type of weapon they want to generate. After accepting the type of weapons to generate, unity shows the user a random type of weapon they wanted.


## High level design
1. Prompts the user to select projectile weapon or melee weapon
2. Loads a list of possible projectile weapons 
3. Loads a list of possible melee weapons 
4. Randomly selects a  projectile weapon if the user selects projectile weapon
5. Randomly selects a melee weapon if the user selects melee weapon 
6. Shows the randomly generated weapon in unity
7. If more weapons need to be generated, go to step 1


### flowchart
![Connector Image](images/HighLevelFlowChart.jpg)

### Methods

To help manage the complexity of the program, I have written three helper methods:

- setWeapon(Sprite, newSprite);
- SetRandomWeapon


- int GetValidInt(string prompt);
- string GenerateRandomName(List<string> weapons, List<string> powers, List<string>, elements);

#### Public void SetWeapon(Sprite, newSprite)

Given a prompt to show the user, displays the prompt then reads input from the keyboard until the user enters a valid type. If the user enters an invalid type, this method displays an error message and prompts the user to try again.
![Connector Image](images/Display.jpg)


1. Creating an integer variable called randomNumber and assigning it to a random range of passed in weapons
2. let a random number be chosen when the user clocks 

1. Validate the prompt is a string
2. Display the prompt
3. read input from the user 
4. If the user entered an invalid weapon, power, or element type,
    - display an error message
    - go to step 2
5. Otherwise, return the users input

#### Public void SetRandomWeapon()

Given a list of weapons, powers and elements, generate random loot using one entry from each list.
![Connector Image](images/Generator.jpg)

1. Create a random number generator
2. Generate a random number, first index, between 0 and weapons.Count
3. Generate a random number, midIndex, between 0 and powers.count
4. Generate a random number, lastIndex, between 0 and elements.count
5. Combine the weapon, power, and element together
    - weapons[firstIndex] + " " + power[midIndex] + " " + element[lastIndex];
6. Return the loot


### Tests

1. First the user opens the program
2. The user should press the start game button and the result should be the opening of another screen
3. When the user has arrived to the main screen, the user can press either the projectile weapon button or the melee weapon button
4. If the user clicks the projectile weapon button, the result should be a random projectile weapon sprite showing up.
5. If the user clicks the melee weapon button, the result should be a random melee weapon sprite showing up.
6. The program should print that the user found the resulting weapon.