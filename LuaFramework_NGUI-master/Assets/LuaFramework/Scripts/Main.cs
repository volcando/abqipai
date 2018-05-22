using UnityEngine;
using System.Collections;

namespace LuaFramework
{
    /// <summary>
    /// 框架主入口
    /// </summary>
    public class Main : MonoBehaviour
    {

        private UISlider slider;
        private UILabel lable;
        private GameObject root;
        private GameObject gui;
        // Use this for initialization
        void Awake()
        {
            AppFacade.Instance.StartUp();
            slider = GameObject.FindGameObjectWithTag("zairu").GetComponent<UISlider>();
            lable = GameObject.FindGameObjectWithTag("lable1").GetComponent<UILabel>();
            root = GameObject.Find("ROOT").gameObject;
            slider.value = 0;
            lable.text = "载入中...0 %";

        }
        int a = 0;
        // Update is called once per frame
        void Update()
        {

            Ziru();
        }
        //场景加载
        void Ziru()
        {

            a++;
            if (a <= 180)
            {

                slider.value = a * 1.0f / 180;
                lable.text = "载入中..." + System.Math.Ceiling(slider.value * 100) + "%";


            }
            else if (a > 210)
            {
                root.SetActive(false);

                return;

            }

        }
      
    }
}