---

layout: default
title: Udacity VR Nanodegree - Javier Robalino

---

# Udacity VR Nanodegree - Javier Robalino
This page documents the projects completed for the core section of my Udacity VR Nanodegree program.

## Table of Contents

<table><col width="30%"><col width="70%"><tr><td><a href="#project-1-introduction"><img src="https://jrobalino.github.io/udacity-vr/img/intro_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-1-introduction"><b>Project 1: Introduction</b></a>—A mobile VR experience that places the user in a virtual world and presents them with choices that alter their surroundings via C# scripts. The emphasis of this Udacity project is to introduce the basic components of a virtual reality application and to teach students how to successfully deploy a Unity project to a mobile device for viewing in a Cardboard headset.</td></tr></table>

<table><col width="30%"><col width="70%"><tr><td><a href="#project-2-modern-apartment"><img src="https://jrobalino.github.io/udacity-vr/img/apartment_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-2-modern-apartment"><b>Project 2: Modern Apartment</b></a>—A mobile VR experience that places users within a homy, modern apartment in a happening city. The emphasis of this Udacity project is on creating high-performing virtual environments, with well-placed objects, well-chosen materials and textures, proper lighting for the build device, and the right amount of animation and ambient sound to bring the space to life.</td></tr></table>

<table><col width="30%"><col width="70%"><tr><td><a href="#project-3-maze"><img src="https://jrobalino.github.io/udacity-vr/img/maze_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-3-maze"><b>Project 3: Maze</b></a>—A mobile VR game that pits players within a vast maze. To escape, players must navigate the maze without getting lost, find a key, and then escape through the exit door. The emphasis of this Udacity project is to use C# scripts to control navigation, audio, animations, game objects, physics, UI interfaces, and game mechanics.</td></tr></table>

<table><col width="30%"><col width="70%"><tr><td><a href="#project-4-puzzler"><img src="https://jrobalino.github.io/udacity-vr/img/puzzler_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-4-puzzler"><b>Project 4: Puzzler</b></a>—A mobile VR game that challenges the player to memorize a random sequence of orb flashes. The emphasis of this Udacity project is on VR design methodology: user personas, ergonomics, field of view, text choices, simulator sickness, motion paradigms, prototyping, scale, mood, user testing, iterative design, and documentation.</td></tr></table>

<table><col width="30%"><col width="70%"><tr><td><a href="#project-5-education"><img src="https://jrobalino.github.io/udacity-vr/img/education_thumbnail.jpg" width="250px"></a></td><td> <a href="#project-5-education"><b>Project 5: Education</b></a>—A mobile VR experience that teaches users about the impact of VR within the education sector. The emphasis of this Udacity project is to research an industry of the student's choice and demonstrate the results of the research in a virtual environment.</td></tr></table>

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

[Return to Top](#table-of-contents)

## Project 2: Modern Apartment

> The apartment feels like home but you can't remember who you are. Desperately, you scour the corners of the beautiful studio, inspecting your book collection, computer, and kitchen items for a clue to your past. But the place is kept devastatingly sterile, the most revealing details no more personal than your selection in fruit, and you just can't remember anything. The sounds of the city wash in and out of the room, a whole world going on without you. From time to time you notice that the globe on your counter begins to spin. Could it contain the key to solving the mystery of you?

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

The apartment gets its ambience from baked area lights of different colors, a baked spotlight, a real-time directional light simulating the sun, and a custom skybox.

![Living Room](https://jrobalino.github.io/udacity-vr/img/apartment-5.png)

![Kitchen](https://jrobalino.github.io/udacity-vr/img/apartment-7.png)

![Fruit](https://jrobalino.github.io/udacity-vr/img/apartment-6.png)

#### Animation and Waypoint System

As the player clicks the Cardboard button, they are teleported to one of four waypoints in the apartment. Every other time the user teleports, the globe starts or stops spinning about its axis. Ambient city sounds play in the background to give the apartment a more dynamic feel.

![Globe](https://jrobalino.github.io/udacity-vr/img/apartment-8.png)

#### High Mobile VR Performance

To optimize the experience for mobile devices, the project uses baked lighting (with the exception of the one directional light) and shaders optimized for mobile.

The quality settings in the project were set to:

| Pixel light count | 0 |
| Texture Quality | Full Res |
| Anti Aliasing | 2x Multi Sampling |
| Soft Particles | Off |
| Realtime Rendering Probes | Off |
| Billboard Face Camera Position | Off |
| Shadows | Off |
| Blend Weights | 1 bone |

The lighting  settings in the project were set to:

| Precomputed Realtime GI | Off |
| Directional Mode | Non-Directional |
| Bake Resoultuion | 80 texels per unit |

### Conclusion

Obtaining 3D models that fit the application is critical to a virtual reality project. While models can have complex meshes, compelling textures, and high-quality shaders, it is important to limit the performance requirements when developing for VR. Doing so helps guarantee high frame rates and a pleasurable user experience on the intended device. In addition to well-placed lights of different colors and intensities, animations and audio can help bring a virtual environment to life.

#### Next Steps

Turn this into a game where you have to discover clues about your forgotten identity!

[Return to Top](#table-of-contents)

## Project 3: Maze

> "Would you like to wake up from this dream?"<br>
> "Yes. I'm terrified."<br>
> "There's nothing to be afraid of, if you answer my questions correctly. Understand?"<br>
> "Yes."<br>
> "Good. First, have you ever questioned the nature of your reality?"<br>
> "No."<br>
> "Tell us what you think of your world."<br>
> "Some people choose to see the ugliness in this world. The disarray. I choose to see the beauty...to believe there is an order to our days, a purpose."

This project dives into scripting and the advanced mechanics that programming languages offer VR applications. The game takes place within an all-too-familiar Western world where the player can live without limits as they navigate through a maze. The player finds a door at the end of the maze but they can only unlock it if they find a key hidden elsewhere in the maze. In addition to the key, the player can collect up to seven coins scattered throughout the maze, and their final score (or Apperception) is based upon how many coins they find.

### Game Video

Click the screenshot to view a video of the game in action.

<a href="https://youtu.be/FJb57bbcZtI" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/maze-video-link.png" alt="Final Game"></a>

### Project Emphasis: Advanced VR Scripting
This project emphasizes the power that scripts add to any VR application or game. It also dives deeper into fundamental Unity components such as quaternions, prefabs, timing functions, animations, UI elements, physics settings and colliders, and audio sources.

* Variables
* Arrays
* Conditionals
* Loops
* Methods
* Quaternions
* Fixed v Delta time
* Prefabs
* Advanced UI
* Scene changes via script
* Event System
* LERP / SLERP
* Colliders
* Raycasting
* Audio Sources
* Waypoints
* Teleportation speed
* Dynamic shaders
* Flocking algorithms
* API Documentation

### Breakdown of Final Piece
The finished project has the following features:

#### Waypoint Navigation System

*Click the screenshot to play video.*

<a href="https://youtu.be/5ucw6XkTYPo" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/maze-navigation.png" alt="Maze Navigation"></a>

The game uses a waypoint navigation system that allows players to traverse the maze by hovering their gaze over specially-positioned cubes. The reticle grows to indicate that players can press the Cardboard button to interact with the cube. When they do, the game teleports them to the new location and plays an audible ding.

#### Collectable Coins

*Click the screenshot to play video.*

<a href="https://youtu.be/-T-l8nRBB_w" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/maze-coin.png" alt="Collectable Coins"></a>

Players can explore the maze to find coins hidden in corners of the maze that may not be part of the main path. This adds some amount of replayability to the game, as their final score is based on the number of coins they find. When a coin is selected using the Cardboard button, a chime is played and the coin disappears in a flurry of lights.

#### Key that Unlocks Door

The door leading out of the maze is locked when the game begins. If players try to open it, an audio source plays suggesting they attempt something different.

*Click the screenshot to play video.*

<a href="https://youtu.be/5P6SWP9364g" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/maze-locked-door.png" alt="Locked Door"></a>

To unlock the door, the player must find the key buried within the heart of the maze. The key hovers left and right above the ground to make it trickier for players to collect it. If a player clicks on the key successfully, the key disappears in a large flurry of light, signalling greater importance relative to the coins.

*Click the screenshot to play video.*

<a href="https://youtu.be/nai2Fihdixw" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/maze-key.png" alt="Maze Key"></a>

With key in hand, the door rises up smoothly when players interact with it. When it is open, players can pass into a temple area, where among other things, they are instructed about consciousness.

*Click the screenshot to play video.*

<a href="https://youtu.be/HRBA99P8j90" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/maze-unlocked-door.png" alt="Unlocked Door"></a>

#### Scoring System

*Click the screenshot to play video.*

<a href="https://youtu.be/nBijhk1BMSw" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/maze-score.png" alt="Maze Score"></a>

There are seven coins scattered throughout the maze. The game keeps track of how many coins the player has collected by the time they reach the temple. Based on the fraction of coins collected, the player receives an Apperception score. If they would like to raise their score, they can choose to play again, which resets the game variables to their initial state and returns the player to the starting point of the maze.

### Conclusion

Knowing how to program is an essential part of virtual reality development. By harnessing a programming language such as C#, a developer can add more complex and less labor-intensive interactions, achieve finer grain control over the experiences they create, and leverage the functionality of third-party toolsets. Alongside understanding popular game engines, knowing how to program for the web and for popular end-user platforms is the backbone to virtual reality development.  

#### Next Steps

If I was to improve the game, I'd start by focusing on the following elements:

- Getting HBO's blessing for the homage :)
- Randomizing where the key and coins are placed
- Allowing the player to increase or decrease the amount of coins in the game
- Programmatically generating a different maze at run time

[Return to Top](#table-of-contents)

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

[Return to Top](#table-of-contents)

## Project 5: Education

> "The function of education is to teach one to think intensively and to think critically. Intelligence plus character - that is the goal of true education." --Martin Luther King, Jr.

This project presents my research into how virtual reality will affect the education industry. I chose to research education because I believe that virtual reality (as well as augmented and mixed reality) can have a huge impact on the greater good. I'm passionate about this technology in applications beyond gaming, in areas such as education, psychology, training, and diplomacy. The results of my research are presented in a mobile VR classroom setting, where the user can choose among five different lessons detailing VR in education. Each lesson provides audio and visual material for the user to explore and transports them to a distraction-free scene. After they complete the lessons, users can take a quiz to test what they learned. 

### Game Video

Click the screenshot to view a video of the game in action.

<a href="https://youtu.be/nEBJS31u2Yw" target="_blank"><img src="https://jrobalino.github.io/udacity-vr/img/education-video-link.png" alt="Final Game"></a>

### Project Emphasis: The Current and Future State of VR
This project emphasizes different VR technologies as they exist today, and what the future may hold for VR and its impact on industries at large.

* High Immersion VR Platforms (HTC Vive, Oculus Rift)
* High End AR Platforms (Microsoft HoloLens)
* Mid Range VR Platforms (PlayStation VR)
* Mobile VR/AR Platforms (Gear VR, Carboard, Daydream, Project Tango)
* FOV Advancements
* Lightfield and other tracking technologies
* Foveated rendering
* Haptics
* Resolution improvements
* Ergonomic improvements
* VR in education (self-selected research area)

### Breakdown of Final Piece
The finished project has the following features:

#### Five Lessons on Virtual Reality in Education

![Lessons](https://jrobalino.github.io/udacity-vr/img/education-lessons.png)

There are five lessons that users can choose:

- Budget for VR
- Teacher Surveys
- Effectiveness
- Current Examples
- Challenges

When users hover over a book, particle effects start emitting from the center, indicating you can use the Cardboard button to enter the lesson. Each lessons transports the user to a distraction-free zone with audio and visual material.

<img src="https://jrobalino.github.io/udacity-vr/img/education-budget.png" width="900px">

Using UI buttons, users can play the narration for each section, or choose to return to the classroom at any time.

#### Supporting Materials from Third-Party Sources

Throughout the learning experience, users are presented with materials from research papers, surveys, educational press releases, and TED Talks.

<img src="https://jrobalino.github.io/udacity-vr/img/education-surveys.png" width="900px">

<img src="https://jrobalino.github.io/udacity-vr/img/education-quote.png" width="900px">

<img src="https://jrobalino.github.io/udacity-vr/img/education-examples.png" width="900px">

<img src="https://jrobalino.github.io/udacity-vr/img/education-examples-2.png" width="900px">

#### Quiz

When they are done learning, users can test their knowledge with a quiz. If they get a question wrong, the game plays audio that tells them as much, and lets them try again. If they get a question correct, the game congratulates them and marks the question as completed.

![Quiz](https://jrobalino.github.io/udacity-vr/img/education-quiz.png)

### Conclusion

Virtual reality has an exciting future ahead. However, there are many challenges that still need to be addressed before mainstream adoption, particularly in a field like education. These challenges range from cost per unit, addressing simulator sickness, improving hygiene, increasing hardware performance, and navigating financial and political constraints. Despite these challenges, the VR industry is experiencing an exciting moment in history—a moment full of experimentation, collaboration, and hopeful expectations for a better future.

#### Next Steps

If I was to improve the game, I'd start by focusing on the following elements:

- Playing videos within the lesson rooms (Unity does not support this for mobile builds, but there are 3rd-party plugins that do the job, or you can roll your own)
- Gamify the learning experience in order to achieve a "meta" effect when the effectiveness of VR in education
- Add more lessons and more challenge questions

[Return to Top](#table-of-contents)