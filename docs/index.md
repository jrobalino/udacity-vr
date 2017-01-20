---

layout: default
title: Udacity VR Nanodegree - Javier Robalino

---

# Udacity VR Nanodegree - Javier Robalino
This page documents the projects completed for my Udacity VR Nanodegree program.

## Project 4: Puzzler

> The wizard's dungeon has been abandoned for centuries, but dark magic still lingers within its stony confines. Rumors tell of shivering travelers seeking shelter in the dungeon, only to become forever trapped by the wizard's puzzle. How will you fare, pilgrim? Will you solve the ancient puzzle, or slowly turn to dust like all that came before you?

Puzzler is a mobile VR game that tests a player's visual memory skills. The game takes place within a mysterious dungeon, where orbs light up in a random pattern. To exit the dungeon, the player must reproduce the correct sequence in which the orbs light up.

(screenshot)

### Design Emphasis
This project emphasizes the importance of VR design methodology. After completing this project, I gained a greater understanding of:

* User Personas
* Ergonomics
* Field of View
* Text: Clarity, Face, Distance
* Simulator Sickness
* Motion Paradigms
* Prototyping
* Scale
* Mood (Lighting and Audio)
* User Testing
* Iterative Design
* Documentation

(video)

### Process
> __*Statement of Purpose:*__ Puzzler is a mobile VR application that challenges new VR users to solve a familiar puzzle in a new way.

#### Persona
![Agent Cooper](udacity-vr/img/cooper.jpg)

**Cooper**, Special Agent

> You know, this is - excuse me - a damn fine cup of coffee!

Cooper spends most of his time solving paranormal murder mysteries. He has little to no VR experience but is enthusiastic about trying new things, so long as he doesn't end up in another dimension. Some of his indulgences include good cherry pie, cups of black coffee, and speaking into a tape recorder to a woman named Diane.

#### Sketches
The following sketch represents the initial environment I envisioned for the game.
(insert image)

 The following sketches represent early ideas for the Start and Restart UI elements of the game.
(insert image)

### User Testing
The main goals of user testing were to ensure:

* The scale of the dungeon gave the player the sense of normal human height.
* The environment was perceived as mysterious or spooky.
* The motion system did not induce simulator sickness.
* The player understood how to play the game.
* The player understood how to restart the game.

I made the following changes as a result of user testing:

| Issue | Quote | Change |
| :---: | :---: | :---: |
| Scale | "I feel shorter than normal." | Move camera up |
| Mood | "It's pretty bright." | Lower ambient lighting |
| Mood | "I'm high up in the mountains. I should probably put on sunblock." | Change skybox tint settings to simulate dusk |
| Simulator Sickness | "[startled] Where is this taking me? I'm going places now." | Lower speed of translation |
| Simulator Sickness | "It's making me sick." | Add trees to cover periphery as player moves forward |
| User Comfort | "I'm going to bonk myself!" | Increase height of doorway |
| Player Satisfaction | "Did I win?" | Add win audio and scoreboard |
| Player Satisfaction | "Is that it?" | Give players the ability to  make the game longer or more difficult |

Thanks to Francisco (regular gamer, some VR experience), Stuart (nongamer, little VR experience), Trini (mobile gamer, no VR experience), and Rusty (light gamer, no VR experience, and prone to simulator sickness) for being the brave test subjects!

### Breakdown of Final Piece
By way of an iterative design process and in response to user feedback, the final game features the following components:
(add screenshots)

#### Snowy, Wind-Scourged Environment
snow, wind audio, bare trees, green lights, tinted mountain skybox

#### UI System Built into the Environment
wooden signs to start and restart the game

#### Linear Motion System
slowed down to seven seconds

#### Game Mechanics Bolstered by Audio and Video
orbs light up with particle effects and sounds, audio confirms a correct choice or not and a win game sound, event system disabled when you need to wait for the pattern

#### Scoring System
how many times it took you to pass the game

#### Adjustable Game Settings
puzzle speed and length

### Conclusion
Blah

#### Next Steps
Probably more instructions, more levels or rooms