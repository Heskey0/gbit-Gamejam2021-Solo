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
    
    
    // Generate Id:59e4748e-2c64-4c86-8c23-68294a2edc9e
    public partial class SettingPanel
    {
        
        public const string NAME = "SettingPanel";
        
        [SerializeField()]
        public UnityEngine.UI.Button BtnClose;
        
        [SerializeField()]
        public UnityEngine.UI.Button BtnResolutionLeft;
        
        [SerializeField()]
        public UnityEngine.UI.Button BtnResolutionRight;
        
        [SerializeField()]
        public UnityEngine.UI.Text TxtResolution;
        
        [SerializeField()]
        public UnityEngine.UI.Button BtnOK;
        
        private SettingPanelData mPrivateData = null;
        
        public SettingPanelData Data
        {
            get
            {
                return mData;
            }
        }
        
        SettingPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new SettingPanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            BtnClose = null;
            BtnResolutionLeft = null;
            BtnResolutionRight = null;
            TxtResolution = null;
            BtnOK = null;
            mData = null;
        }
    }
}
