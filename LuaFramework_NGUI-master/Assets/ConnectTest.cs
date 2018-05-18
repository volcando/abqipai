using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LoginGlobe : MonoBehaviour
{

    void Start()
    {
        //GET请求     
        StartCoroutine(GET("http://xuanyusong.com/"));

    }

    void Update()
    {

    }

    void OnGUI()
    {

    }

    //登录     
    public void LoginPressed()
    {
        //登录请求 POST 把参数写在字典用 通过www类来请求     
        Dictionary<string, string> dic = new Dictionary<string, string>();
        //参数     
        dic.Add("action", "0");
        dic.Add("usrname", "xys");
        dic.Add("psw", "123456");

        StartCoroutine(POST("http://192.168.1.12/login.php", dic));

    }
    //注册     
    public void SingInPressed()
    {
        //注册请求 POST     
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("action", "1");
        dic.Add("usrname", "xys");
        dic.Add("psw", "123456");

        StartCoroutine(POST("http://192.168.1.12/login.php", dic));
    }

    //POST请求     
    IEnumerator POST(string url, Dictionary<string, string> post)
    {
        WWWForm form = new WWWForm();
        foreach (KeyValuePair<string, string> post_arg in post)
        {
            form.AddField(post_arg.Key, post_arg.Value);
        }

        WWW www = new WWW(url, form);
        yield return www;

        if (www.error != null)
        {
            //POST请求失败     
            Debug.Log("error is :" + www.error);

        }
        else
        {
            //POST请求成功     
            Debug.Log("request ok : " + www.text);
        }
    }

    //GET请求     
    IEnumerator GET(string url)
    {

        WWW www = new WWW(url);
        yield return www;

        if (www.error != null)
        {
            //GET请求失败     
            Debug.Log("error is :" + www.error);

        }
        else
        {
            //GET请求成功     
            Debug.Log("request ok : " + www.text);
        }
    }

}