# Magic Leap 3D Model Viewer


### Instructions

1. Open the project in Unity 2020.3+.
2. Open the 3DModelViewer.unity scene under Assets > _3DModelViewer > Scenes.
3. For each model you want to view, drag a new ModelTemplate prefab into the hierarchy as child of the \[MODELS\] GameObject. The prefab is located in Assets > _3DModelViewer > Models.
4. Import your model and drag it into the hierarchy as a child of your ModelTemplate GameObject. 
    - If the scale is way off in the scene compared to the default sphere collider of the ModelTemplate, adjust the scale of the model child, not the scale of the ModelTemplate. 
    - Same goes for rotations if the model is rotated incorrectly when brought in. 
    - Make sure your materials/textures are assigned to the model as well.
5. The default Magic Leap setup should be done, however, you'll need to change the certificate location to your local developer .cert file by going to Edit > Project Settings > Player > Lumin Settings > Publishing Settings > ML Certificate.
6. Connect your Magic Leap and Click "Build and Run" under File > Build Settings. It will automatically play on the headset when finished.

The control info is displayed in-app to the left of your initial head position, but here are the controls as well:
```
Home = Recenter Content
Trigger = Grab
Touchpad Tap Left/Right = Scale
Touchpad Tap Up/Down = Move In/Out
Touchpad Radial = Rotate
Touchpad Forcepress = Reset Model
Reach out to extend pointer.
```


### Example Models From TurboSquid

[Blooper](https://www.turbosquid.com/3d-models/3d-bloopers-super-1316383)
<br/>

[Octopus](https://www.turbosquid.com/3d-models/free-octopus-3d-model/934712)