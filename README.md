# fdl-mcve
Firebase Dynamic Links Case 10161897: iOS Error says deep link does not contain valid params

Screenshots of your Dynamic Link config in the console (if link is created via console):
![image](https://user-images.githubusercontent.com/1088474/148890253-f528e067-f627-45b6-ae0b-32d3a1ac5b22.png)


Confirmation if the issue persists after updating to the latest SDK available:
- Yes, I confirm that the issue persists even with the latest SDK available, v8.7.0

'Minimal' repro that we can run locally (i.e. MCVE) to reproduce the issue:
- https://github.com/davidmfinol/fdl-mcve

Steps to replicate the issue using the MCVE:
1. Open the Unity Project `Card-Game-Simulator` with Unity 2020.3.25f1 iOS
2. Build and run to an iOS device
3. Click the short link on the iOS device: [https://cgs.link/zu_tiles_hime](https://cgs.link/zu_tiles_hime)

Complete stack trace and logs from iOS self-diagnostic tool:
- The iOS self-diagnostic tool requires Swift or Objective-C, but I am using the Unity C# SDK

Video reproducing the issue (so I could have a clearer view of the exact behavior you're encountering):
- TBD

Video reproducing the issue using our quickstart app (for verification):
- N / A

Confirmation if there are no longer any errors found upon checking the affected link's debug page:
- Yes, I confirm there are no errors on the link's debug page: https://cgs.link/zu_tiles_hime?d=1
