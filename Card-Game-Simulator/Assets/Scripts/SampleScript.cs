using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Extensions;
using Firebase.DynamicLinks;

public class SampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	Debug.Log("Starting...");
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
            {
                var dependencyStatus = task.Result;
                if (dependencyStatus != DependencyStatus.Available)
                {
                    Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
                    return;
                }
		Debug.Log("Setting callback...");
                DynamicLinks.DynamicLinkReceived += OnDynamicLinkReceived;
		Debug.Log("Callback set!");
            });
    }
    private void OnDynamicLinkReceived(object sender, EventArgs args)
    {
        Debug.Log("Dynamic Link Received!");
        var dynamicLinkEventArgs = args as ReceivedDynamicLinkEventArgs;
        GetComponent<Text>().text = dynamicLinkEventArgs?.ReceivedDynamicLink.Url.OriginalString;
    }
}
