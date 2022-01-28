//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QFramework.Example
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public class SettingPanelData : QFramework.UIPanelData
    {
        #region Singleton

        private static SettingPanelData _instance = null;
        public static SettingPanelData Instance()
        {
            if (_instance==null)
            {
                _instance = new SettingPanelData();
            }
            return _instance;
        }
        
        

        #endregion

        public int ResolutionMode = 10;
    }
    
    public partial class SettingPanel : QFramework.UIPanel
    {
        private Button BtnExit;
        private int tmpResolutionMode = 10;
        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as SettingPanelData ?? new SettingPanelData();
            // please add init code here
            BtnExit = transform.Find("BtnExit").GetComponent<Button>();

            BtnResolutionLeft.onClick.AddListener(() =>
            {
                tmpResolutionMode =
                    Mathf.Clamp(tmpResolutionMode-1,9,10);
                switch (tmpResolutionMode)
                {
                    case 10:
                        TxtResolution.text = "1920*1080";
                        break;
                    case 9:
                        TxtResolution.text = "1366*768";
                        break;
                }
            });
            
            BtnResolutionRight.onClick.AddListener(() =>
            {
                tmpResolutionMode =
                    Mathf.Clamp(tmpResolutionMode+1,9,10);
                switch (tmpResolutionMode)
                {
                    case 10:
                        TxtResolution.text = "1920*1080";
                        break;
                    case 9:
                        TxtResolution.text = "1366*768";
                        break;
                }
            });
            
            BtnOK.onClick.AddListener(() =>
            {
                SettingPanelData.Instance().ResolutionMode = tmpResolutionMode;
                switch (SettingPanelData.Instance().ResolutionMode)
                {
                    case 10:
                        Screen.SetResolution(1920,1080,false);
                        break;
                    case 9:
                        Screen.SetResolution(1366,768,false);
                        break;
                }
                
                CloseSelf();
            });
            
            BtnClose.onClick.AddListener(() =>
            {
                CloseSelf();
            });
            
            BtnExit.onClick.AddListener(()=>
            {
                Debug.Log("退出游戏");
                Application.Quit();
            });
            
        }
        
        protected override void OnOpen(QFramework.IUIData uiData)
        {
            tmpResolutionMode = SettingPanelData.Instance().ResolutionMode;
            switch (SettingPanelData.Instance().ResolutionMode)
            {
                case 10:
                    TxtResolution.text = "1920*1080";
                    break;
                case 9:
                    TxtResolution.text = "1366*768";
                    break;
            }
        }
        
        protected override void OnShow()
        {
        }
        
        protected override void OnHide()
        {
        }
        
        protected override void OnClose()
        {
        }
    }
}
