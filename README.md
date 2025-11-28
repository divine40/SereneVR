SereneVR: An Immersive Virtual Environment for Stress Reduction

SereneVR is a Virtual Reality application designed to provide users with immediate, accessible "virtual safe spaces" to escape stressful real-world environments. Built for the Meta Quest platform using Unity, it leverages immersive visuals, spatial audio, and interactive therapeutic tools to promote mental well-being.

 Key Features

5 Distinct Biomes:

Serene Beach: Features a rhythmic "Breathing Orb" for guided 4-7-8 breathing exercises.

Quiet Forest: A dense nature scene with gaze-based wildlife interactions.

Zen Garden: A structured environment for mindfulness and contemplation.

Mountain Peak: Offers a high-altitude perspective with a Day/Night cycle toggle.

Immersive Audio: 3D spatial soundscapes (waves, wind chimes, rain) that react to player position.

VR Locomotion: Teleportation-based movement to ensure comfort and prevent motion sickness.

Diegetic UI: World-space menus and interaction portals that maintain immersion.

Technology Stack

Engine: Unity 2022.3 LTS (Universal Render Pipeline - URP)

Platform: Android (Meta Quest 2 / 3)

Framework: XR Interaction Toolkit (Action-based Input)

Language: C#

 How to Run and Test

Prerequisites

Unity Hub and Unity Editor (2022.3 or later).

Android Build Support module installed.

A VR Headset (Meta Quest 2 or 3) and a USB-C cable.

Installation

Clone this repository:

git clone (https://github.com/divine40/SereneVR.git)


Open Unity Hub and click Add. Select the SereneVR folder.

Open the project. (Wait for Unity to import assets/packages).

Building to Headset

Connect your Meta Quest to your PC via USB.

Put on the headset and allow USB Debugging inside the headset.

In Unity, go to File > Build Settings.

Ensure Platform is set to Android. (Click "Switch Platform" if needed).

Under Run Device, select your headset (e.g., "Oculus Quest 2").

Click Build and Run.

 Controls

Left Controller Joystick: Aim Teleport Ray / Move.

Right Controller Joystick: Snap Turn.

Trigger (Index Finger): UI Selection / Teleport Confirmation.

Grip (Middle Finger): Grab Objects (Zen Garden Stones).

Head Movement: Look around to interact with Gaze-based events.

 Project Structure

Assets/_Scenes: Contains the 5 main environments and the Hub.

Assets/_Scripts: Custom C# logic for Breathing, Gaze, and UI management.

Assets/_Prefabs: Reusable components like the "Return Portal" and Player Rig.

 Author

Chimdalu Divinefavour Akunyiba of African Leadership University.
