---

layout: default
title: Udacity VR Nanodegree - Javier Robalino

---

# Udacity VR Nanodegree - Javier Robalino
This page documents the projects completed for the core section of my Udacity VR Nanodegree program.

## Table of Contents

<table><col width="30%"><col width="70%"><tr><td><a href="#project-1-introduction"><img src="https://jrobalino.github.io/udacity-vr/img/intro_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-1-introduction"><b>Project 1: Introduction</b></a>—A mobile VR experience that places the user in a virtual world and presents them with choices that alter their surroundings via C# scripts. The emphasis of this Udacity project is to introduce the basic components of a virtual reality application and to teach students how to successfully deploy a Unity project to a mobile device for viewing in a Cardboard headset.</td></tr></table>

<table><col width="30%"><col width="70%"><tr><td><a href="#project-2-modern-apartment"><img src="https://jrobalino.github.io/udacity-vr/img/apartment_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-2-modern-apartment"><b>Project 2: Modern Apartment</b></a>—A mobile VR experience that places users within a homy, modern apartment in a happening city. The emphasis of this Udacity project is on creating high-performing virtual environments, with well-placed objects, well-chosen materials and textures, proper lighting for the build device, and the right amount of animation and ambient sound to bring the space to life.</td></tr></table>

<table><col width="30%"><col width="70%"><tr><td><a href="#project-4-puzzler"><img src="https://jrobalino.github.io/udacity-vr/img/puzzler_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-4-puzzler"><b>Project 4: Puzzler</b></a>—A mobile VR game that challenges the player to memorize a random sequence of orb flashes. The emphasis of this Udacity project is on VR design methodology: user personas, ergonomics, field of view, text choices, simulator sickness, motion paradigms, prototyping, scale, mood, user testing, iterative design, and documentation.</td></tr></table>

## Project 1: Introduction

> The red cube taunts you as it hovers in the air, coyly emitting particles. When you click it, it teleports randomly. If you try to grow it until it bursts, or shrink it until it vanishes, the laws of virtual physics get in your way. An inanimate object should not be this impudent. How will you react?

The first project in the Udacity Virtual Reality Nanodegree was designed to teach the principles of VR technology, including optics, displays, stereopsis, headset tracking (3DOF v 6DOF), and the differences between the major hardware platforms. The project culminates in the creation of a virtual environment made of Unity primitives, terrain features, a skybox, and UI elements tied to C# scripts that allow the user to modify the world around them. Of course, one of the most valuable aspects of the project was learning to successfully build and deploy the application to a mobile phone.

### Game Video

Click the screenshot to view a video of the game in action.

<a href="https://youtu.be/e-_Px46j6Ck" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/intro-video-link.png" alt="Final Game"></a>

### Project Emphasis: GoogleVR SDK, Unity Basics, and Mobile Deployment
This project emphasizes the fundamental aspects of VR technology, the Unity editor, and deploying projects to mobile platforms.

* VR Cameras in Unity using the GoogleVR SDK
* Unity primitives
* UI elements
* Skybox
* User interactions via scripts
* Build settings
* Deploying to mobile platforms

### Breakdown of Final Piece
The finished project has the following features:

#### Instructions to the User

![Instructions](https://jrobalino.github.io/udacity-vr/img/intro-video-link.png)

Simple instructions in clear lettering to help users get started.

#### Interactive UI Elements
![UI](https://jrobalino.github.io/udacity-vr/img/intro-ui.png)

The buttons located below the user are linked to different script functions which activate when the user clicks the screen through a Carboard headset. You can reset the game elements to their initial postion or recenter the view around the user's current gaze. You can also interact with the game cube (which changes color on hover) by growing or shrinking it, and interact with the skybox by changing the environment from day to night, and vice versa. Clicking directly on the cube teleports it randomly to another location in the environment.

#### Grow the Cube
![Big Cube](https://jrobalino.github.io/udacity-vr/img/intro-big-cube.png)

If the cube gets too big, the game prevents you from growing it further and displays a warning:

![Big Cube Warning](https://jrobalino.github.io/udacity-vr/img/intro-big-warning.png)

#### Shrink the Cube
![Small Cube](https://jrobalino.github.io/udacity-vr/img/intro-small-cube.png)

If the cube gets too small, the game prevents you from shrinking it further, doing funny maths, and violating the fundamental laws of the universe:

![Small Cube Warning](https://jrobalino.github.io/udacity-vr/img/intro-small-warning.png)

#### Carpe Diem (or not)
![Night](https://jrobalino.github.io/udacity-vr/img/intro-night.png)

If you've had it with the unrelenting glow of daytime, you can select the option for sweet, sweet nightime, which animates the sun setting within the virtual environment (this happens a lot quicker than IRL). You can always set it back to daytime if you change your mind.

### Conclusion

Unity is a great tool for designing VR experiences. The importance of clear text, comfortable UI interactions, and predictable script behavior should always be kept in mind. The build settings in Unity enable developers to design experiences for a variety of hardware platforms, ranging from mobile to high-performance headsets, but the developer must think of how to adjust these settings appropriately depending on the use case. Creating a mobile build from Unity did not prove difficult—although it *was* tricky to develop on a Windows machine and then deploy to an iOS phone :)

## Project 2: Modern Apartment

> The apartment feels like home but you can't remember who you are. Desperately, you scour the corners of the beautiful studio, inspecting your book collection, computer, and kitchen items for a clue of your past. But the place is kept devastatingly sterile, the most revealing details no more personal than your selection in fruit, and you just can't remember anything. The sounds of the city wash in and out of the room, a whole world going on without you. From time to time you notice that the globe on your counter begins to spin. Could it contain the key to solving the mystery of you?

This project teaches the fundamentals of using Unity to build beautiful and performant VR scenes. The project demonstrates complex game objects positioned within a modern apartment space at realistic scales and relative locations. The apartment is well-lit by different types of Unity lights, includes a waypoint system that allows users to move around the space, and includes animations to make the scene more engaging. Although the project strives to create a beautiful scene, it also requires that performance remain high enough to run well on mobile devices.

### Game Video

Click the screenshot to view a video of the game in action.

<a href="https://youtu.be/327mMdN7cOQ" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/apartment-1.png" alt="Final Game"></a>

### Project Emphasis: 3D Objects, Animations, Lighting, and Performance
This project emphasizes how to create and animate objects in Unity, as well as how to light them well, all while optimizing performance.

* Game Objects
* Meshes
* Transforms
* Materials
* Textures
* Shaders
* Animations
* Animation Controllers
* State Machines
* Camera Deep Dive: layers, culling mask, lens separation distance, sensors, SDKs
* Unity lights (area, point, spotlight, directional)
* Real-time v. Baked Lighting
* Waypoint teleportation system

### Breakdown of Final Piece
The finished project has the following features:

#### Dozens of Models

The models in this project render sofas, rugs, a TV, a bookshelf with individual books, a clock, a computer desk, a kitchen table and chairs, a fridge, a counter, a fruit bowl, a globe, cabinets, a door, walls, a ceiling, and a floor.

![Bookshelf](https://jrobalino.github.io/udacity-vr/img/apartment-2.png)

![Computer](https://jrobalino.github.io/udacity-vr/img/apartment-3.png)

![TV](https://jrobalino.github.io/udacity-vr/img/apartment-4.png)

#### Real-Time and Baked Lighting

The apartment gets its ambience from baked area lights of different colors, a baked spotlight, a real-time directional light simulating the sun, and custom skybox.

![Living Room](https://jrobalino.github.io/udacity-vr/img/apartment-5.png)

![Kitchen](https://jrobalino.github.io/udacity-vr/img/apartment-7.png)

![Fruit](https://jrobalino.github.io/udacity-vr/img/apartment-6.png)

#### Animation and Waypoint System

As the player clicks the Cardboard button, they are teleported to one of four waypoints in the apartment. Every other time the user teleports, the globe starts or stops spinning about its axis. Ambient city sounds play in the background to give the apartment a more dynamic feel.

![Globe](https://jrobalino.github.io/udacity-vr/img/apartment-8.png)

### Conclusion

Unity is a great tool for designing VR experiences. The importance of clear text, comfortable UI interactions, and predictable script behavior should always be kept in mind. The build settings in Unity enable developers to design experiences for a variety of hardware platforms, ranging from mobile to high-performance headsets, but the developer must think of how to adjust these settings appropriately depending on the use case. Creating a mobile build from Unity did not prove difficult—although it *was* tricky to develop on a Windows machine and then deploy to an iOS phone :)

## Project 4: Puzzler

> The wizard's dungeon has been abandoned for centuries, but dark magic still lingers within its stony confines. Rumors tell of shivering travelers seeking shelter in the dungeon, only to become forever trapped by the wizard's puzzle. How will you fare, pilgrim? Will you solve the ancient puzzle, or slowly turn to dust like all that came before you?

Puzzler is a mobile VR game that tests a player's visual memory skills. The game takes place within a mysterious dungeon, where orbs light up in a random pattern. To exit the dungeon, the player must reproduce the correct sequence in which the orbs light up.

### Game Video

Click the screenshot to view a video of the game in action.

<a href="https://youtu.be/a4xqkIVxSNs" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/video-link.png" alt="Final Game"></a>

### Project Emphasis: Design Methodology
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

### Process
> __*Statement of Purpose:*__ Puzzler is a mobile VR application that challenges new VR users to solve a familiar puzzle in a new way.

#### Persona
![Agent Cooper](https://jrobalino.github.io/udacity-vr/img/cooper.jpg)

**Cooper**, Special Agent

> You know, this is - excuse me - a damn fine cup of coffee!

Cooper spends most of his time solving paranormal murder mysteries. He has little to no VR experience but is enthusiastic about trying new things, so long as he doesn't end up in another dimension. Some of his indulgences include good cherry pie, cups of black coffee, and speaking into a tape recorder to a woman named Diane.

#### Sketches
The following sketch represents the initial environment I envisioned for the game. From the start, I wanted the dungeon to be surrounded by menacing mountains, to be snowed in and feel abandoned, and to have a skylight to highlight the orbs.

![Dungeon Sketch](https://jrobalino.github.io/udacity-vr/img/dungeon-sketch.jpg)

 The following sketches represent early ideas for the Start and Restart UI elements of the game. In the end, I chose the wooden sign posts because they felt like part of the environment as opposed to separate game elements, which user testing confirmed would have taken players out of the experience, relatively speaking.

![UI Sketch](https://jrobalino.github.io/udacity-vr/img/ui-sketch.jpg)

### User Testing
The main goals of user testing were to ensure:

* The scale of the dungeon gave the player the sense of normal human height.
* The environment was perceived as mysterious or spooky.
* The environment did not lessen the immersion of players in any significant way.
* The motion system did not induce simulator sickness.
* The player understood how to play the game.
* The player understood how to restart the game.

#### Users

| Name | Occupation | VR Experience |
| :---: | :---: | :---: |
| Francisco | Finance Manager | Regular gamer, some VR experience |
| Stuart | Welder | Non-gamer, little VR experience |
| Trini | TV Production Engineer | Mobile gamer, no VR experience |
| Rusty | Systems Engineer | Casual gamer, no VR experience (and prone to simulator sickness)|

Thanks again to Francisco, Stuart, Trini, and Rusty!

### Results

| Issue | Quote | Change |
| :---: | :---: | :---: |
| Scale | "I feel shorter than normal." | Move camera up |
| Mood | "It's pretty bright." | Lower ambient lighting |
| Mood | "I'm high up in the mountains. I should probably put on sunblock." | Change skybox tint settings to simulate dusk |
| Simulator Sickness | [startled] "Where is this taking me? I'm going places now." | Lower speed of translation |
| Simulator Sickness | "It's making me sick." | Add trees to cover periphery as player moves forward |
| User Comfort | "I'm going to bonk myself!" | Increase height of doorway |
| Player Satisfaction | "Did I win?" | Add win audio and scoreboard |
| Player Satisfaction | "Is that it?" | Give players the ability to  make the game longer or more difficult |
| Player Satisfaction | "I could play this all day!" | Success! |

### Progression of the Dungeon Lighting

To demonstrate the value of user testing, the following images illustrate the progression of the dungeon lighting from initial conception to final product, with the goal of creating a creepy environment:

![Dungeon - open, bright, snowy](https://jrobalino.github.io/udacity-vr/img/dungeon1.png)

The initial dungeon featured a lot of open air and no lights. This gave it an abandoned air, but players did not find it foreboding.

![Dungeon - darker, less open](https://jrobalino.github.io/udacity-vr/img/dungeon2.png)

By closing the roof in and lowering the ambient light, the dungeon began to feel more menacing to players.

![Dungeon - lit by orange torches](https://jrobalino.github.io/udacity-vr/img/dungeon3.png)

Adding torches yielded mixed results. Some players found them mysterious, but others found the mood of the scene was "bright and cheery".

![Dungeon - lit by green torches](https://jrobalino.github.io/udacity-vr/img/dungeon4.png)

Making the torch light green achieved a "spooky" result for all players.

![Dungeon - darker skybox](https://jrobalino.github.io/udacity-vr/img/dungeon5.png)

The final mood achieved its desired effect. Adjusting the skybox tint to be darker and bluer made the environment feel like "dusk", with "low visibility", and "a sense of cold". 

### Breakdown of Final Piece
Owing to an iterative design process and in response to user feedback, the final game features the following components:

#### Snowy, Wind-Scourged Environment

![Environment](https://jrobalino.github.io/udacity-vr/img/snowy.png)

The environment is cold and menacing by way of:

- A ground plane that looks like snow
- Howling wind serving as ambient noise
- Bare, spindly trees
- Green flames
- A mountain skybox tinted to a darker shade of blue
- Creepy music within the dungeon

#### UI System Built into the Environment
![UI](https://jrobalino.github.io/udacity-vr/img/signs.png)

The UI system of wooden sign posts is believable within the environment, preserving a greater sense of immersion.

#### Linear Motion System

*Click the screenshot to play video:*

<a href="https://youtu.be/kdHdD7CGaAE" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/motion.png" alt="Motion System"></a>

The video linked in the screenshot above demonstrates the linear motion system in the game, which was user-tested with four people (including a player sensitive to simulator sickness) until a comfortable speed was achieved.

- The initial translation time was 3 seconds, which was extended to 7 seconds after testing.
- The initial motion path was not lined by trees. To increase the comfort of a particularly sensitive player, I lined up trees along the path to anchor objects in the player's periphery.

> **Note:** When the player chooses to play again, the game teleports them back to the start. This mechanism proved comfortable for players and returned them to the fun quickly and efficiently.

#### Game Mechanics Bolstered by Audio and Video

*Click the screenshot to play video:*

<a href="https://youtu.be/W2Mzx9Qdl5M" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/feedback.png" alt="Feedback System"></a>

The video linked in the screenshot above demonstrates the following feedback mechanisms:

- The event system disables when the sequence is being demonstrated to the player
- Orbs light up and emit particles when the player gazes at them
- Correct selections play a reassuring audio clip
- Incorrect selections play a shocking audio clip and disable the event system
- A successfully completed sequence plays a celebratory audio clip

#### Scoring System

![Scoring](https://jrobalino.github.io/udacity-vr/img/scoring.png)

The game keeps track of how many attempts it takes the player to complete the sequence, and congratulates them if they win on their first attempt.

#### Adjustable Game Settings

![Settings](https://jrobalino.github.io/udacity-vr/img/settings.png)

The game features adjustable settings for increased replayability:

**Puzzle Speed**

This setting controls the delay between orb flashes when the pattern is displayed to the player.

| *Easy* | 2 seconds |
| *Normal* | 1 second |
| *Hard* | 0.5 seconds |
| *Insane* | 0.25 seconds |

**Puzzle Length**

This setting controls how many orbs light up in the sequence. Players can increase this number indefinitely, but the minimum puzzle length is 3.

### Conclusion

Figuring out how to design a comfortable, intuitive, and rewarding game that allows players to experience what you had initially envisioned is an iterative process. Along the way, some of your assumptions prove correct, but others require adjustments. You stumble upon unexpected design decisions by way of user testing, or even through mistakes. Documenting your process keeps you organized along the way, and in the end it's a pleasure to review all the progress you've made and have something to show to anyone curious in your work.

#### Next Steps

If I was to improve the game, I'd start by focusing on the following elements:

- Additional rooms (stacked vertically into a tall tower so the player can progress to the top)
- A voice-over from the evil wizard, taunting players as they move through the dungeon
- Limited failed attempts, challenging players to get to the end of the game within a finite amount of mistakes