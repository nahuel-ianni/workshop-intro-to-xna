# Workshop - Introduction to the XNA Framework
*This workshop took place on September 4th, 2014, during a private event.*

In this repository, you will find five projects used to introduce new students to the [XNA Framework](https://en.wikipedia.org/wiki/Microsoft_XNA) and game development in general.  
The projects were used to provide an introduction to:

1. Empty project  
   - The *Content* project  
   - Explain the main methods the Game class have and how they work  
   - Interaction with the game window: changing the title, background color, size and other properties

2. Loading textures  
   - Introduction of the *Draw* method - Change the game background with a static image  
   - Introduction of the *Update* method - Replace the mouse pointer with a custom image

3. Showing enemies  
   - Incorporating game logic - Make enemies spawn randomly on screen, attack and disappear afterwards

4. Collisions  
   - Destroy enemies - Capture *mouse click* events and check for the proper conditions to destroy enemies before they despawn

5. Adding text and sound  
   - Show game score - Load fonts and use them to show the score on screen  
   - Sound effects - Play a sound whenever the player destroys an enemy

## Getting started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
On top of Visual Studio, you need to install the [Microsoft XNA Framework Redistributable 4.0](https://www.microsoft.com/en-us/download/details.aspx?id=20914).

As of February 1st, 2013, Microsoft confirmed the discontinuation of the XNA development toolset, with no future versions or updates planned.  

While there are ways of [installing and running XNA on newer versions of Visual Studio](http://flatredball.com/visual-studio-2019-xna-setup/), [MonoGame](http://www.monogame.net/) is the preferred and recommended framework for those wishing to continue development on this platform. This workshop is fully compatible with the MonoGame implementation of XNA.