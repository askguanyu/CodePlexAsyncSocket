//-----------------------------------------------------------------------
// <copyright file="ListViewExtensions.cs" company="Contoso Corporation">
//     Copyright (c) Contoso Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace GY.NetAid.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    ///
    /// </summary>
    public static class ListViewExtensions
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="listView"></param>
        public static void AutoResizeColumns(this ListView listView)
        {
            listView.BeginUpdate();

            try
            {
                foreach (ColumnHeader column in listView.Columns)
                {
                    column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

                    int columnContentWidth = column.Width;

                    column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

                    int headerWidth = column.Width;

                    column.Width = Math.Max(columnContentWidth, headerWidth);
                }
            }
            finally
            {
                listView.EndUpdate();
            }
        }
    }
}
