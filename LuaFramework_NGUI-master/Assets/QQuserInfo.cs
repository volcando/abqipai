using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QQuserInfo  {
    /// <summary>
    /// 用户ID
    /// </summary>
    public string userID = "";

    /// <summary>
    /// 用户名
    /// </summary>
    public string userName = "";

    /// <summary>
    /// 用户头像
    /// </summary>
    public string userIcon = "";

    /// <summary>
    /// 用户记号
    /// </summary>
    public string token = "";

    public QQuserInfo()
    {

    }

    public QQuserInfo(string uID, string uName, string uIcon, string uToken)
    {
        this.userID = uID;
        this.userName = uName;
        this.userIcon = uIcon;
        this.token = uToken;
    }

}
