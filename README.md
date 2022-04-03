# Source code for CS50’s Introduction to Game Development
https://cs50.harvard.edu/games/2018/projects/10/portal/

# Objectives
Create your own level in a new scene using ProBuilder and ProGrids!
Ensure that the level has an FPSController to navigate with in the scene.
Ensure that there is an object or region with a trigger at the very end that will trigger the end of the level (some zone with an invisible BoxCollider will work).
When the level ends, display “You Won!” on the screen with a Text object.

# Specification
Create your own level in a new scene using ProBuilder and ProGrids! The distro should already have ProBuilder and ProGrids imported and ready for use, but just in case they aren’t, you can easily find them by searching in the Asset Store (where they are now free, thanks to Unity having acquired them!). There are many resources for learning how to use ProGrids effectively, but two resources in particular that are worth checking out are here and here, which should more than prepare you for creating a simple level.
Ensure that the level has an FPSController to navigate with in the scene. This part’s probably the easiest; just import an FPSController from the Standard Assets! It should already be imported into the project in the distro, where you can find the prefabs under Assets > Standard Assets > Characters > FirstPersonCharacter > Prefabs!
Ensure that there is an object or region with a trigger at the very end that will trigger the end of the level (some zone with an invisible BoxCollider will work). This one should be easy as well, just relying on the creation of an empty GameObject and giving it a BoxCollider component, which you can then resize via its resize button in the component inspector!
When the level ends, display “You Won!” on the screen with a Text object. Recall that OnTriggerEnter is the function you’ll need to write in a script you also associate with the BoxCollider trigger, and ensure that the BoxCollider is set to a trigger in the inspector as well! Then simply program the appropriate logic to toggle on the display of a Text object that you also include in your scene (for an example on how to do this, just see the Helicopter Game 3D project, specifically the GameOverText script)!

# Video of Source and Demo
https://youtu.be/XXX

