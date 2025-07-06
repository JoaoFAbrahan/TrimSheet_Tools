// Load Form System
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrimSheet_Tools.Controller
{
    internal class WinMain_LoadForms
    {
        // Global variables
        private Panel _targetContainerPanel;
        private List<Form> _formsList = new List<Form>();
        

        public WinMain_LoadForms(Panel panelRef)
        {
            this._targetContainerPanel = panelRef;
        }


        /// <summary>
        /// Add a new Form to list
        /// </summary>
        /// <param name="formRef">New Form to be added</param>
        public void AddFormList(Form formRef)
        {
            // Checks if the Form has been initialized 
            if (formRef is null)
                throw new ArgumentNullException(nameof(formRef), "Form not instantiated!");
            else
            {
                // Add a Form to list
                formRef.TopLevel = false;
                formRef.Dock = DockStyle.Fill;
                _formsList.Add(formRef);
            }            
        }

        /// <summary>
        /// Load Form based on index
        /// </summary>
        /// <param name="index">Index of the form that should be displayed</param>
        public void LoadWindow(int index)
        {
            // Load Form based on index to a referenced containerPanel
            _targetContainerPanel.Controls.Clear();
            _targetContainerPanel.Controls.Add(_formsList[index]);
            _formsList[index].Show();
        }
    }
}
