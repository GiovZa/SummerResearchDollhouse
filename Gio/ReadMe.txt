Documentation was structured so that someone new to C# can understand it, as future parties involved might not be too experienced with code. Everything was made in Unity's engine and C# scripting.

All code and assets in Gio folder were made by Giovanni Joel Zavalza, except Crosshair Prefab but I don't know where it belongs so I'm leaving it there
Most images and sprites were created using https://www.craiyon.com/, formerly known as DALL-E mini. Rest were photos taken by me.

If you hear me mention code mode, that just means objects are only interactable through Vanderhyde's Mal code

If there are any inquiries and/or comments about code, you can contact me through 
phone: 630-330-3393 email: zavalzagiovanni@gmail.com LinkedIn: https://www.linkedin.com/in/giovanni-zavalza/ or GitHub: GiovZa

[
Video tutorial on creating new gameobjects and then me explaining my code and where it is in the scene: https://youtu.be/DMf_HcDyNco
To create a new object, you must add the following components/child objects:

Box Collider: Is Trigger = off
Rigidbody: Use Gravity = true, Is Kinematic = false, Interpolate = none, Collision detection = Continuous Speculative

Add Crosshair prefab
Add a transform and put it to where you want object grabbed, I'll call this Pivot.transform

Change layer to GrabbableLayer

To create a new object, you must also add the following scripts:

Distancegrabbable.cs: Allow Offhand Grab = true, Grab Points = 1; element 0 = box Collider, Set Snap Offset to Pivot.transform
CenterOfMass.cs: Awake = true, set positions to bottom center of object to have it land upright
Item.cs: In Slot = flase, Current Slot = none
layerChange.cs

And then add Dr. Vanderhyde's Mal scripts:

Entity.cs
CreateProgramReference.cs
GalleryItem.cs: Set Gallery Item Name to name/prefab you put in World's SaveLoad.cs
]


Code outside of Gio folder has been modified by Gio, most notably DistanceGrabber.cs lines 171-199, 
OVRPlayerController.cs lines 208-216, and OVRGrabbable line 36 to create a spawnpoint


If any issues with the following, it is probably an error stemming from my code:

Center of mass / weighted objects to make entities land upright
Snap offset / in Distancegrabber.cs, objects can be grabbed from a transform attached to object
Gallery / UI that can spawn any object
Trash button / in SlotTrash.cs, destroys any object colliding with button so long as it has item script
Adding new object to world so that it can be coded and grabbed
Swapping between coding and grabbing "modes" (Just layer changes)


To do:

"code" = Vanderhyde's 2D interface
don't remove object if it is in code, SIZE OF OBJECTS NOT CHANGEABLE, no pictures for gameObjects when put in code, buttons can still lead to scrolling, layer changes when move code is dragged

Controller(s) Map Layout:
A: press on raycast beam (mouse click/drag but for VR)
B: Move canvas towards player, make it solid
X: Switch between grab mode and code mode
Y: Gallery toggle

Left stick: Move
Left stick + Left top trigger: Move fast
Right stick: Rotate 45 degrees either direction

Right bottom trigger: Grab with right hand
Left bottom trigger: Grab with left hand

Buttons available: Menu buttons, stick clicks?, top triggers (exception for top left trigger: left stick is being used)

Post-Conference Updates (08/08/22):

Since layer change is still bugged, we changed inputs so that X leads to grabbable layer and top left trigger leads to code mode 

I have merged the branches of Edwin's and mine to see if our code works in the same workspace

Improvements on avatar imports and asset creation within Dollhouse is a potential route. So is terrain generation and tutorial world. Finally, helping to make it so Dollhouse is ready to be taught 
in Vanderhyde's CS1 classes to improve CS logic for beginner students 
