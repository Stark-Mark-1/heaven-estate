using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using TMPro;
public class showUserData : MonoBehaviour
{
    //firebase variables
    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;
    public FirebaseUser user;

    [Header("User Data")]
    public TMP_Text email;

    private void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
        user = auth.CurrentUser;

        if(user != null)
        {
            email.text = user.Email;
        }
    }


}
