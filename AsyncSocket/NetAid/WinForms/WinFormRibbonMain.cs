//-----------------------------------------------------------------------
// <copyright file="WinFormMain.cs" company="Contoso Corporation">
//     Copyright (c) Contoso Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace GY.NetAid.WinForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    ///
    /// </summary>
    public partial class WinFormRibbonMain : Form
    {
        public WinFormRibbonMain()
        {
            this.InitializeComponent();
            this.InitializeRibbonTabContainer();
            //this.serverModePanel1.sendPanel1.SendButton.Click += new EventHandler(SendButton_Click);
        }

        void SendButton_Click(object sender, EventArgs e)
        {
            //this.serverModePanel1.sendPanel1.AutoSendTimesTextBox.Text = "3";
        }

        #region RibbonLogic
        private const int RIBBON_COLLAPSE_HEIGHT = 22;

        private const int RIBBON_EXPAND_HEIGHT = 100;

        private const int FORM_BORDER_HEIGHT = 60;

        private bool _isRibbonTabExpand;

        private bool _isRibbonTabShow;

        private void InitializeRibbonTabContainer()
        {
            this._isRibbonTabExpand = true;
            this._isRibbonTabShow = true;
            this.CollapseRibbonTabContainer(!this._isRibbonTabExpand);
            this.RibbonTabContainer.LostFocus += this.HideRibbon;
            this.ribbonPage1.ItemClicked += this.HideRibbon;
            this.ribbonPage2.ItemClicked += this.HideRibbon;
            this.ribbonPage3.ItemClicked += this.HideRibbon;
        }

        private void RibbonTabContainer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.CollapseRibbonTabContainer(this._isRibbonTabExpand);
        }

        private void CollapseRibbonTabContainer(bool whetherCollapse)
        {
            if (whetherCollapse)
            {
                this.RibbonTabContainer.Height = RIBBON_COLLAPSE_HEIGHT;
                this.RibbonPanel.Location = new System.Drawing.Point(0, RIBBON_COLLAPSE_HEIGHT);
                this.RibbonPanel.Height = this.Height - RIBBON_COLLAPSE_HEIGHT - FORM_BORDER_HEIGHT;
                this._isRibbonTabExpand = false;
                this._isRibbonTabShow = false;
            }
            else
            {
                this.RibbonTabContainer.Height = RIBBON_EXPAND_HEIGHT;
                this.RibbonPanel.Location = new System.Drawing.Point(0, RIBBON_EXPAND_HEIGHT);
                this.RibbonPanel.Height = this.Height - RIBBON_EXPAND_HEIGHT - FORM_BORDER_HEIGHT;
                this._isRibbonTabExpand = true;
                this._isRibbonTabShow = true;
            }
        }

        private void RibbonTabContainer_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this._isRibbonTabExpand)
            {
                if (!this._isRibbonTabShow)
                {
                    this.RibbonTabContainer.Height = RIBBON_EXPAND_HEIGHT;
                    this.RibbonTabContainer.BringToFront();
                    this._isRibbonTabShow = true;
                }
                else
                {
                    this.RibbonTabContainer.Height = RIBBON_COLLAPSE_HEIGHT;
                    this._isRibbonTabShow = false;
                }
            }
        }

        private void RibbonTabContainer_Selected(object sender, TabControlEventArgs e)
        {
            this._isRibbonTabShow = false;
        }

        private void RibbonTabContainer_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!this._isRibbonTabExpand)
            {
                this.RibbonTabContainer.Height = RIBBON_EXPAND_HEIGHT;
                this.RibbonTabContainer.BringToFront();
            }
        }

        private void HideRibbon(object sender, EventArgs e)
        {
            if (!this._isRibbonTabExpand)
            {
                if (this._isRibbonTabShow)
                {
                    this.RibbonTabContainer.Height = RIBBON_COLLAPSE_HEIGHT;
                    this._isRibbonTabShow = false;
                }
            }
        } 
        #endregion

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            new WinFormAboutBox().ShowDialog();
        }
    }
}
