# fdl-mcve
Firebase Dynamic Links Case 10161897: iOS Error says deep link does not contain valid params

## Screenshots of your Dynamic Link config in the console:
![image](https://user-images.githubusercontent.com/1088474/148890253-f528e067-f627-45b6-ae0b-32d3a1ac5b22.png)

## Confirmation if the issue persists after updating to the latest SDK available:
- Yes, I confirm that the issue persists even with the latest SDK available, v8.7.0

## 'Minimal' repro that we can run locally (i.e. MCVE) to reproduce the issue:
- https://github.com/davidmfinol/fdl-mcve

## Steps to replicate the issue using the MCVE:

### BEFORE `FirebaseDynamicLinksCustomDomains`:
1. Open the `Card-Game-Simulator` project
2. Build and run to an iOS device
3. Click the short link on the iOS device: [https://cgs.link/zu_tiles_hime](https://cgs.link/zu_tiles_hime)
4. Notice that there is no "Dynamic Link Received" message in the logs and that the UI Text does not get updated

### AFTER `FirebaseDynamicLinksCustomDomains`:
1. Not reproducible with mcve; only reproducible by taking a build that successfully works with the BEFORE steps, and then doing through the app store.

## Complete stack trace and logs from iOS self-diagnostic tool:
- The iOS self-diagnostic tool requires Swift or Objective-C, but I am using the Unity C# SDK. How can I call the iOS self-diagnostic tool from the Unity C# SDK?

## Video reproducing the issue:

### BEFORE `FirebaseDynamicLinksCustomDomains`, with mcve on Xcode:
- https://user-images.githubusercontent.com/1088474/148912056-c5553b12-09ec-442d-bfdd-d9b9e38d47dd.mp4

### AFTER `FirebaseDynamicLinksCustomDomains`, with full app on XCode (NOTE THAT THIS WORKS): 
- https://user-images.githubusercontent.com/1088474/150435087-37cb2c0a-bf3b-4836-9ca3-7c32b5cc1480.mp4

### AFTER `FirebaseDynamicLinksCustomDomains`, with full app on App Store (NOTE THAT THIS IS THE SAME BUILD AS THE WORKING ONE, JUST ON APP STORE): 
- https://user-images.githubusercontent.com/1088474/150435701-8996a726-78bd-4516-b284-b2f61e822a5e.mp4

## Confirmation if there are no longer any errors found upon checking the affected link's debug page:
- Yes, I confirm there are no errors on the link's debug page: https://cgs.link/zu_tiles_hime?d=1
