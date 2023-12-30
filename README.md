# 3D Animation - P2: CITM Fighters
## Guidelines

Download the attached 3D models and select a character to animate. Other characters can be used if desired (as long as they are free to use), 
but you must ensure that they can be exported correctly to Unity.

### Objective:

We will create a simple game with two animated characters in a martial arts combat. It can be played in local versus two players. It must be possible to play with a PC controller. 
The application will be built in Unity. The game must include sound effects and two characters engaging in combat. The inclusion of visual effects will be positively valued.

A 3D stage can be added as a game level, but the area through which the characters move must be flat. An example scenario will be provided that can be used, 
or can be downloaded from the internet (as long as it is free). The focus of the work should not be on the environment, but on the animations.

### Animations:

The following animations will be performed for the selected character:

* Idle
* Walk Front
* Walk Backwards
* Dodge High Attack
* Evade Low Attack (jump in place)
* Attack Quick (short range)
* Attack Slow (long range)
* Low Quick Attack (short range)
* Low Slow Attack (long range)
* Die
* Win

### Constraints:

All animations must be hand-animated (keyframe animation), the use of motion capture or retargeting of animations is not allowed.

The game will be programmed with Root Motion, so animations can move from the origin point if necessary.

In the game we will not be able to jump to the sides or change sides with the opponent. The boundaries of the stage will determine the total area that players can move through. The camera will be with a side view (Street Fighter type) and without scrolling.

The main objective of the game is to hit the opponent. Whoever hits first wins the round. We can play infinite rounds.

## My Implementation: Azri vs. Evil Azri

### Azri has to beat her own evil version!

![Battle](https://github.com/francesctr4/CITM-Fighters/assets/99948892/0dfeb706-2c2a-4f6a-825a-857e575b7412)

### To win, you must hit the opponent before it hits you. Each round won gives 100 points to the corresponding player.

#### Player 1 Controls (Evil Azri) [Keyboard]

    A,D -> Move
    Space -> Attack Quick
    S + Space -> Low Quick Attack
    Enter -> Dodge High Attack
    S + Enter -> Evade Low Attack
    Right Control -> Attack Slow
    S + Right Control -> Low Slow Attack

#### Player 2 Controls (Azri) [PS4 Controller]

    Left Joystick (Left & Right) -> Move
    Square -> Attack Quick
    Left Joystick (Down) + Square -> Low Quick Attack
    Triangle -> Dodge High Attack
    Left Joystick (Down) + Triangle -> Evade Low Attack
    Cross -> Attack Slow
    Left Joystick (Down) + Cross -> Low Slow Attack
    
## Disclaimer (Known Bugs)

The Unity template of the project has several problems regarding the position of the players and, as a result, 
you will notice that the walking animations are not being displayed correctly sometimes.
