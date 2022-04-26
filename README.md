# Roll the Ball VR
Android game application built for Google Cardboard using Unity 3D and the [Google VR SDK](https://developers.google.com/vr/develop/unity/get-started-android). Developed for the [Virtual, Augmented, Mixed Reality](https://www.cs.uoi.gr/course/virtual-augmented-mixed-reality/?lang=en) class [@cse.uoi.gr](https://www.cs.uoi.gr/). Apk is available under releases or under Roll the Ball VR\build directory. Alternatively, the project can be imported into Unity using the unitypackage file under Roll the Ball VR\build directory.
<br>
<br>


## Project Import Notes:
- On unitypackage file import, scenes must be manually added on build settings (File -> Build Settings) so that scene switches are functional. Level 0 should be on position 0, level 1 should be on position 1, etc. (Look @vr_images/Screenshot_5.png)
- Android SDK Tools had to be manually specified (Edit -> Preferences -> External Tools). Android Studio Android SDK Tools were used for apk compilation. (Look @vr_images/Screenshot_7.png)
<br>

## Gameplay Tips:
(Some are also displayed in-game)
- Aim and tap to push the ball into the hole
- Aim towrads the floor to move forward
- You can also push obstacle by aiming towards them and tapping
- If an obstacle falls into a hole the level is reloaded (lose)
- If the camera (player) falls into a hole the level is reloaded (lose)
- If the soccer ball falls into a wrong hole the level is reloaded (lose)
- If the soccer ball falls into the correct hole the next level is loaded (win)
- Application can be close with the X button 
<br>

## Sounds have been added for the following events:
- On camera (player) move forward
- On soccer ball push (kick)
- On obstacle push (kick)
- On soccer ball wall collision (hit)
- On soccer ball obstacle collision (hit)
- On obstacle wall collision (hit)
- On obstacle ball collision (hit)
- On soccer ball enters correct hole (win)
- On soccer ball enter wrong hole (lose)
- On camera (player) enter any hole (lose)
- On obstacle enter any hole (lose)
<br>

## Not implemented:
- Sensitivity adjustments with the volume buttons
<br>

## Demo Video:
- https://youtu.be/rQIIMlVzGkU
- Note that audio is not captured when the application is running on the phone. However, audio is properly played just as when the game is running within the Unity Editor. An actual Android phone was used for testing (as opposed to an emulator) using [scrcpy](https://github.com/Genymobile/scrcpy) to display and control the phone's screen on desktop PC.
<br>

## Team:
- Antoniou Christodoulos
- Tsiouri Angeliki
<br>
