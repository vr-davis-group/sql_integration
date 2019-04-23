using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class db_read : MonoBehaviour
{
    string giantString;

    public string[] registeredUsers;
    public string[] usernames = new string[100];
    public string[] passwords = new string[100];

    IEnumerator Start()
    {
        WWW users = new WWW("http://localhost/read.php");
        yield return users; //makes the program wait until we get a response from the webstie
        giantString = users.text;

        registeredUsers = giantString.Split(';');

        for(int i = 0; i < registeredUsers.Length - 1; i++)
        {
            usernames[i] = registeredUsers[i].Substring(registeredUsers[i].IndexOf('U') + 9);
            usernames[i] = usernames[i].Remove(usernames[i].IndexOf('|'));

            passwords[i] = registeredUsers[i].Substring(registeredUsers[i].IndexOf('P') + 9);
        }
    }

 }
