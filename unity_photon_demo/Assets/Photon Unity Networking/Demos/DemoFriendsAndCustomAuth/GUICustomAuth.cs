using UnityEngine;
using System.Collections;

public class GUICustomAuth : MonoBehaviour
{
    public Rect GuiRect;
    public int gui_depth = 1;
    
	private string authName = "FC5704B9075819E6";
	private string authToken = "FC5704B9075819E6-0-0-FD3A-8D234A0A829B16F-BD9357D250AA308B.9507086BBC2031A7";
    private string authDebugMessage = string.Empty;


    void Start()
    {
        GuiRect = new Rect(Screen.width / 4, 80, Screen.width / 2, Screen.height - 100);
    }


    public void OnJoinedLobby()
    {
        // for ease of use, this script simply deactivates itself on successful connect
        this.enabled = false;
    }


    /// <summary>
    /// This method is called when Custom Authentication is setup for your app but fails for any reasons.
    /// </summary>
    /// <remarks>
    /// Unless you setup a custom authentication service for your app (in the Dashboard), this won't be called.
    /// If authentication is successful, this method is not called but OnJoinedLobby, OnConnectedToMaster and the 
    /// others will be called.
    /// </remarks>
    /// <param name="debugMessage"></param>
    public void OnCustomAuthenticationFailed(string debugMessage)
    {
        this.authDebugMessage = debugMessage;
        SetStateAuthFailed();
    }


    enum GuiState { AuthOrNot, AuthInput, AuthHelp, AuthFailed  }
    private GuiState guiState;
    public GameObject RootOf3dButtons;

    public void SetStateAuthInput()
    {
        RootOf3dButtons.SetActive(false);
        guiState = GuiState.AuthInput;
    }

    public void SetStateAuthHelp()
    {
        RootOf3dButtons.SetActive(false);
        guiState = GuiState.AuthHelp;
    }

    public void SetStateAuthOrNot()
    {
        RootOf3dButtons.SetActive(true);
        guiState = GuiState.AuthOrNot; 
    }

    public void SetStateAuthFailed()
    {
        RootOf3dButtons.SetActive(false);
        guiState = GuiState.AuthFailed; 
    }

    public void ConnectWithNickname()
    {
        RootOf3dButtons.SetActive(false);

        PhotonNetwork.AuthValues = null; // null by default but maybe set in a previous session.
        PhotonNetwork.ConnectUsingSettings("1.0");

        // PhotonNetwork.playerName gets set in GUIFriendFinding
        // a UserID is not used in this case (no AuthValues set)
    }

    void OnGUI()
    {
    	GUI.depth = this.gui_depth;
        if (PhotonNetwork.connected)
        {
           // GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
            return;
        }


        GUILayout.BeginArea(GuiRect);
        switch (guiState)
        {
            case GuiState.AuthFailed:
//                GUILayout.Label("Authentication Failed");
//
//                GUILayout.Space(10);
//
//                GUILayout.Label("Error message:\n'" + this.authDebugMessage + "'");
//
//                GUILayout.Space(10);
//
//                GUILayout.Label("For this demo set the Authentication URL in the Dashboard to:\nhttp://photon.webscript.io/auth-demo-equals");
//                GUILayout.Label("That authentication-service has no user-database. It confirms any user if 'name equals password'.");
//                GUILayout.Label("The error message comes from that service and can be customized.");
//
//                GUILayout.Space(10);
//
//                GUILayout.BeginHorizontal();
//                if (GUILayout.Button("Back"))
//                {
//                    SetStateAuthInput();
//                }
//                if (GUILayout.Button("Help"))
//                {
//                    SetStateAuthHelp();
//                }
//                GUILayout.EndHorizontal();
                break;

            case GuiState.AuthHelp:

//                GUILayout.Label("By default, any player can connect to Photon.\n'Custom Authentication' can be enabled to reject players without valid user-account.");
//
//                GUILayout.Label("The actual authentication must be done by a web-service which you host and customize. Example sourcecode for these services is available on the docs page.");
//                
//                GUILayout.Label("For this demo set the Authentication URL in the Dashboard to:\nhttp://photon.webscript.io/auth-demo-equals");
//                GUILayout.Label("That authentication-service has no user-database. It confirms any user if 'name equals password'.");
//
//                GUILayout.Space(10);
//                if (GUILayout.Button("Configure Authentication (Dashboard)"))
//                {
//                    Application.OpenURL("https://www.exitgames.com/dashboard");
//                }
//                if (GUILayout.Button("Authentication Docs"))
//                {
//                    Application.OpenURL("http://doc.exitgames.com/en/pun/current/tutorials/pun-and-facebook-custom-authentication");
//                }
//
//
//                GUILayout.Space(10);
//                if (GUILayout.Button("Back to input"))
//                {
//                    SetStateAuthInput();
//                }
                break;

            case GuiState.AuthInput:
                
//                GUILayout.Label("Authenticate yourself");
//
//                GUILayout.BeginHorizontal();
//                this.authName = GUILayout.TextField(this.authName, GUILayout.Width(Screen.width/4 - 5));
//                GUILayout.FlexibleSpace();
//                this.authToken = GUILayout.TextField(this.authToken, GUILayout.Width(Screen.width/4 - 5));
//                GUILayout.EndHorizontal();
//
//
//                if (GUILayout.Button("Authenticate"))
//                {
//                    PhotonNetwork.AuthValues = new AuthenticationValues();
//                    PhotonNetwork.AuthValues.SetAuthParameters(this.authName, this.authToken);
//                    PhotonNetwork.ConnectUsingSettings("1.0");
//                }
//
//                GUILayout.Space(10);
//
//                if (GUILayout.Button("Help", GUILayout.Width(100)))
//                {
//                    SetStateAuthHelp();
//                }

                break;
        }

        GUILayout.EndArea();
    }
}