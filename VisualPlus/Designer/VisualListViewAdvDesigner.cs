﻿#region Namespace

using System.Collections;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

using VisualPlus.ActionList;

#endregion

namespace VisualPlus.Designer
{
    internal class VisualListViewAdvDesigner : ControlDesigner
    {
        #region Variables

        private DesignerActionListCollection _actionListCollection;

        #endregion

        #region Properties

        /// <summary>Gets the design-time action lists supported by the component associated with the designer.</summary>
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (_actionListCollection == null)
                {
                    _actionListCollection = new DesignerActionListCollection
                            {
                               new VisualListViewAdvActionList(Component) 
                            };
                }

                return _actionListCollection;
            }
        }

        #endregion

        #region Overrides

        protected override void PreFilterProperties(IDictionary properties)
        {
            properties.Remove("ImeMode");
            properties.Remove("Padding");
            properties.Remove("FlatAppearance");
            properties.Remove("FlatStyle");

            properties.Remove("AutoEllipsis");
            properties.Remove("UseCompatibleTextRendering");

            properties.Remove("Image");
            properties.Remove("ImageAlign");
            properties.Remove("ImageIndex");
            properties.Remove("ImageKey");
            properties.Remove("ImageList");
            properties.Remove("TextImageRelation");

            // properties.Remove("BackColor");
            properties.Remove("BackgroundImage");
            properties.Remove("BackgroundImageLayout");
            properties.Remove("UseVisualStyleBackColor");

            // properties.Remove("Font");
            // properties.Remove("ForeColor");
            properties.Remove("RightToLeft");
            properties.Remove("View");

            base.PreFilterProperties(properties);
        }

        #endregion
    }
}