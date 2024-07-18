using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using TMPro;
using UnityEngine.SceneManagement;
using EasyUI.Toast;

public class FirebaseAuthManager : MonoBehaviour
{
    //Firebase variables
    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;
    public FirebaseUser user;

    //Login Variables
    [Space]
    [Header("Login")]
    public TMP_InputField emailLoginField;
    public TMP_InputField passwordLoginField;

    //Registration Variable
    [Space]
    [Header("Registration")]
    public TMP_InputField nameRegisterField;
    public TMP_InputField emailRegisterField;
    public TMP_InputField passwordRegisterField;
    public TMP_InputField confirmPasswordRegisterField;

    private void Start()
    {
        StartCoroutine(CheckAndFixDependenciesAsync());
    }
    private IEnumerator CheckAndFixDependenciesAsync()
    {
        var dependencyTask = FirebaseApp.CheckAndFixDependenciesAsync();
        yield return new WaitUntil(() => dependencyTask.IsCompleted);
        dependencyStatus = dependencyTask.Result;
        if (dependencyStatus == DependencyStatus.Available)
        {
            InitializeFirebase();
            yield return new WaitForEndOfFrame();
            StartCoroutine(CheckForAutoLogin());
        }
        else
        {
            Debug.LogError("Could Not resolve all firebase dependendency" + dependencyStatus);
        }

    }
    void InitializeFirebase()
    {
        auth = FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);
    }
    private IEnumerator CheckForAutoLogin()
    {
        if (user != null)
        {
            var reloadUserTask = user.ReloadAsync();
            yield return new WaitUntil(() => reloadUserTask.IsCompleted);
            AutoLogin();
        }
        else
        {

        }

    }
    private void AutoLogin()
    {
        if (user != null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }
    void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
        if (auth.CurrentUser != user)
        {
            bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null;
            if (!signedIn && user != null)
            {
                Debug.Log("Signed out " + user.UserId);
                SceneManager.LoadScene(1);
            }
            user = auth.CurrentUser;
            if (signedIn)
            {
                Debug.Log("Signed in " + user.UserId);
            }
        }
    }

    public void LogOut()
    {
        if (user != null && auth != null)
        {
            auth.SignOut();
            Debug.Log("Logged Out");
            string update = "Logged Out";
            Toast.Show(update, 1f, Color.grey);
        }
    }

    public void Login()
    {
        StartCoroutine(LoginAsync(emailLoginField.text, passwordLoginField.text));
    }
    private IEnumerator LoginAsync(string email, string password)
    {
        var loginTask = auth.SignInWithEmailAndPasswordAsync(email, password);
        yield return new WaitUntil(() => loginTask.IsCompleted);
        if (loginTask.Exception != null)
        {
            Debug.LogError(loginTask.Exception);
            FirebaseException firebaseException = loginTask.Exception.GetBaseException() as FirebaseException;
            AuthError authError = (AuthError)firebaseException.ErrorCode;
            string failedMessage = "Login Failed! Because ";
            switch (authError)
            {
                case AuthError.InvalidEmail:
                    failedMessage += "Email is Invalid";
                    break;
                case AuthError.WeakPassword:
                    failedMessage += "Wrong Password";
                    break;
                case AuthError.MissingEmail:
                    failedMessage += "Missing Email";
                    break;
                case AuthError.MissingPassword:
                    failedMessage += "Password is Missing";
                    break;
                default:
                    failedMessage += "Login Failed";
                    break;
            }
            Debug.Log(failedMessage);
        }
        else
        {
            user = loginTask.Result.User;
            Debug.LogFormat("{0} You are successfully Logged In", user.DisplayName);
            string name = user.DisplayName;
            Toast.Show("Welcome :" +name);
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }
    public void Register()
    {
        StartCoroutine(RegisterAsync(nameRegisterField.text, emailRegisterField.text, passwordRegisterField.text, confirmPasswordRegisterField.text));
    }
    private IEnumerator RegisterAsync(string name, string email, string password, string confirmPassword)
    {
        if (name == "")
        {
            Debug.LogError("User Name is Empty");
        }
        else if (email == "")
        {
            Debug.LogError("Email is Empty");
        }
        else if (passwordRegisterField.text != confirmPasswordRegisterField.text)
        {
            Debug.LogError("Passwords do not match");
        }
        else
        {
            var registerTask = auth.CreateUserWithEmailAndPasswordAsync(email, password);
            yield return new WaitUntil(() => registerTask.IsCompleted);
            if (registerTask.Exception != null)
            {
                Debug.LogError(registerTask.Exception);
                FirebaseException firebaseException = registerTask.Exception.GetBaseException() as FirebaseException;
                AuthError authError = (AuthError)firebaseException.ErrorCode;

                string failedMessage = "Registration Failed Because";
                switch (authError)
                {
                    case AuthError.InvalidEmail:
                        failedMessage += "Email is Invalid";
                        break;
                    case AuthError.WeakPassword:
                        failedMessage += "Wrong Password";
                        break;
                    case AuthError.MissingEmail:
                        failedMessage += "Missing Email";
                        break;
                    case AuthError.MissingPassword:
                        failedMessage += "Password is Missing";
                        break;
                    default:
                        failedMessage += "Registration Failed";
                        break;
                }
                Debug.Log(failedMessage);
                Toast.Show(failedMessage, 2f, Color.grey);
            }
            else
            {
                user = registerTask.Result.User;
                UserProfile userProfile = new UserProfile { DisplayName = name };
                var updateProfileTask = user.UpdateUserProfileAsync(userProfile);
                yield return new WaitUntil(() => updateProfileTask.IsCompleted);
                if (updateProfileTask.Exception != null)
                {
                    user.DeleteAsync();
                    Debug.LogError(updateProfileTask.Exception);
                    FirebaseException firebaseException = updateProfileTask.Exception.GetBaseException() as FirebaseException;
                    AuthError authError = (AuthError)firebaseException.ErrorCode;
                    string failedMessage = "Profile Update Failed! Because";
                    switch (authError)
                    {
                        case AuthError.InvalidEmail:
                            failedMessage += "Email is Invalid";
                            break;
                        case AuthError.WeakPassword:
                            failedMessage += "Wrong Password";
                            break;
                        case AuthError.MissingEmail:
                            failedMessage += "Missing Email";
                            break;
                        case AuthError.MissingPassword:
                            failedMessage += "Password is Missing";
                            break;
                        default:
                            failedMessage += "Profile Update Failed";
                            break;
                    }
                    Debug.Log(failedMessage);
                }
                else
                {
                    Debug.Log("Registration Sucessful Welcome " + user.DisplayName);
                    name = "Registration Sucessful Welcome " + user.DisplayName;
                    Toast.Show(name, 1f,  Color.grey);
                    UnityEngine.SceneManagement.SceneManager.LoadScene(2);
                }
            }
        }
    }
}