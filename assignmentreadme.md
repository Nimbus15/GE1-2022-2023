Time Machine Simulator(Like the one from Terminator Genisys)

Name: Alex Bang 
Student Number: C19409486

Class Group: TU856/4

# Description of the project
This is a simulation of a time machine. The time machine works drawning in charged particles to set the player back in time using a charged time travel bubble. 
The time machine arms (portal) hits off each other to create sparks. The platform will raise the player into the time machine. Player will be sent back in time. 

# Instructions for use
Before stepping onto the platform listen to the music to set the mood which is 3:37 minutes, skip to the best part at 2:00 minutes (This is optional).
 
Just step into the platform in the middle of the time machine and watch it work.
Wait 50 seconds for the travel bubble to complete.(This is in order to see the sparks I made)


# How it works
The user will step into the platform,
The user's movement will be disabled,
Created scripts which will run in a sequence to recreate the action


# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| ActionController.cs (Singleton Object) | Self written |
| CameraController.cs| Self written |
| Lifetime.cs | Self written |
| MySpawner.cs | Modified from Spawner |
| ParticleAccelated.cs| Modified from Quaternions|
| Platform.cs| Self written |
| PortalMovement.cs | Self written |
|SphereController.cs| Self written |
|Portal| Self Created Using Blender|
|Work Camp Music| From https://www.youtube.com/watch?v=YNWqQhWN3O8| 

# References
* https://www.youtube.com/watch?v=YNWqQhWN3O8

# What I am most proud of in the assignment
I'm proud of my design of the time machine
I'm proud of my special effects I made
I'm proud of the way I code
I tried creating my own special effects without using the Unity Particle System



# What I learned
I love being able to experiment with vectors and quaternions in this project. I was able to improve
my understanding of quaternions.

##(What I would do if I return to this project)
Replace the special effects with the Unity Particle System
Use the Unity Animator system to better animate the time travel action
Use the Unity Statemachine and to manage the time machine power modes e.g. MachineState.HalfPower, MachineState.Quaterpowered
Use perlin noise to generate random terrains
Use a better time machine chamber asset
Use better camera movement
Use unity lighting system in order to improve the mood




# Proposal submitted earlier can go here:
Cood ideas
1. Space traveller project
I will be use Probuilder to build a spaceships, planets and asteroids. I will also use other objects. 
This is because in the 1970s there was enthusiasm for space travel. I will be using a main camera as the main viewpoint. 
I will use spawner to create instances of the objects. I will use Quaternions to generate a vector that will point to 
the camera. I will use the camera setting background to create outer space. I will create effects to make it look like 
the camera is moving. I may use special effects to simulate impact.

2. Terminator time machine project.
I will be use objects created using probuilder to create the look of the time machine. I will need move some of these objects 
using vector maths e.g. Quaternions making them traverse around a center point to 
simulate a time machine from terminator the movie. I will choose this idea and expand on it.

3. Space battle simulator
I will be using similar strategies as the space traveller project. However there will be a lot more spawning of object e.g. lasers
to simulate lasers hitting the user.






## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |

