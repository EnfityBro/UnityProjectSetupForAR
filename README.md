# A fully prepared AR project template for starting AR game development on Unity

## How to use this template

**Option 1: Through a template on GitHub**
1. Create a repository with the selection of this template. 
2. In the Unity project, in the Build Settings, switch the platform to Android. 

**Option 2: Cloning**
1. Clone the repository and create your own project based on its files. 
2. In the Unity project, in the Build Settings, switch the platform to Android. 

## Instructions for self-adding AR and configuring a player in a Unity project
1. Create Unity project, select Universal 3D (URP) 
2. Import AR Foundation 
3. Import Google ARCore XR Plugin 
4. Import OpenXR Plugin 
5. Import XR Interaction Toolkit</br> 
  5.1. In Samples window import Starter Assets</br> 
  5.2. In Samples window import AR Starter Assets 
6. File -> Build Profiles (Build Settings) -> Android -> Switch Platform 
7. Edit -> Project Settings -> XR Plug-in Management</br> 
  7.1. -> the Android tab -> Google ARCore</br> 
  7.2. -> the PC tab -> XR Simulation</br> 
  7.3. -> Project Validation -> check if there are any errors/warnings, if there are, click fix all 
8. Edit -> Project Settings -> Player -> the Android tab -> Other Settings</br> 
  8.1. -> Graphics APIs -> remove Vulkan</br> 
  8.2. -> Minimum API Level -> Android 7.0 'Nougat' (API level 24)</br> 
  8.3. -> Active Input Handing -> Input System Package (New) - It is recommended, but you can leave Both 
9. Edit -> Project Settings -> Graphics -> Default Render Pipeline -> Mobile (it's called Mobile_RPAsset by default) 
10. Edit -> Project Settings -> Quality -> Levels -> Mobile 
11. In the Assets -> Settings folder select Mobile_Renderer -> Add Renderer Feature -> AR Background Renderer Feature 
12. In the hierarchy -> RMB -> XR</br> 
  12.1. -> AR Session</br> 
  12.2. -> XR Origin (Mobile AR) 
13. In the hierarchy, select XR Origin (Mobile AR)</br> 
  13.1. -> AR Plane Manager -> Plane Prefab -> AR Feathered Plane (if not selected, then this prefab can be found along the way: Assets -> Samples -> XR Interaction Toolkit -> your_version -> AR Starter Assets -> Prefabs -> AR Feathered Plane)</br> 
  13.2. -> Detection Mode -> Horizontal (now only horizontal objects will be tracked)</br> 
  13.3. -> Add component -> AR Anchor Manager 

## Contact me
- [Telegram Channel](https://t.me/enfity_games) 
- [Donation](https://dalink.to/enfity) 
- [YouTube](https://www.youtube.com/@enfity) 
- [Itch.io](https://enfity.itch.io/) 
- enfity.games@gmail.com 
- [GitHub](https://github.com/EnfityBro) 
