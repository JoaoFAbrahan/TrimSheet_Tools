using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TrimSheet_Tools.Model;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    internal class TrimSheet_RebuildingShapeSystem
    {
        // Global variables
        private List<StripData> _targetStripDataList;
        private TrimSettings _targetForm;
        private DockPanelModel _targetDockingPanelSystem;
        private Vector2D _viewerPanelSize = new Vector2D(616f, 480f); // Set value based into ViwerPanel size (X = Undocked size, Y = Docked size)


        /// <summary>
        /// Update Viewport System
        /// </summary>
        /// <param name="stripDataListRef">StripDataList reference</param>
        /// <param name="trimSettingsRef">Form reference</param>
        /// <param name="dockingPanelRef">Docking System reference</param>
        public TrimSheet_RebuildingShapeSystem(ref List<StripData> stripDataListRef, TrimSettings trimSettingsRef, in DockPanelModel dockingPanelRef)
        {
            // Initialize References
            this._targetStripDataList = stripDataListRef;
            this._targetForm = trimSettingsRef;
            this._targetDockingPanelSystem = dockingPanelRef;
        }


        // Methods
        /// <summary>
        /// Viewport Update
        /// </summary>
        public void Rebuild()
        {
            // Get Parameters
            double scaleFactor = _targetDockingPanelSystem.isDocked ? _viewerPanelSize.X / (float)_targetForm._genResolution : _viewerPanelSize.Y / (float)_targetForm._genResolution;
            double currentOffset = 0f;

            // Clear viewport
            _targetForm.uvTrimView_Panel.Controls.Clear();

            // Add Shapes
            for (int i = 0; i < _targetStripDataList.Count; i++)
            {
                var stripData = _targetStripDataList[i];
                var shape = stripData.StripShape;

                // Set strip dimentions
                int width = (int)(stripData.StripSize.X * (_targetForm._genVerticalMode ? _targetForm._genResolution * scaleFactor : _targetForm.uvTrimView_Panel.Width));
                int height = (int)(stripData.StripSize.Y * (_targetForm._genVerticalMode ? _targetForm.uvTrimView_Panel.Height : _targetForm._genResolution * scaleFactor));
                int left = _targetForm._genVerticalMode ? (int)(currentOffset * _targetForm.uvTrimView_Panel.Width) : 0;
                int top = _targetForm._genVerticalMode ? 0 : (int)(currentOffset * _targetForm.uvTrimView_Panel.Height);

                shape.Width = width;
                shape.Height = height;
                shape.Left = left;
                shape.Top = top;

                _targetForm.uvTrimView_Panel.Controls.Add(shape);

                // Add Label
                VerticalLabel nameLabel = new VerticalLabel
                {
                    Name = $"labelShapeName{i}",
                    Text = stripData.StripName,
                    ForeColor = Color.Black,
                    BackColor = stripData.StripColor,
                    BackgroundImage = _targetForm.texelDensityGridCheker_CheckBox.Checked ? stripData.StripShape.BackgroundImage : null,
                    BackgroundImageLayout = ImageLayout.Tile,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    Width = width,
                    Height = height,
                    Top = top,
                    Left = left,
                    DrawVertically = _targetForm._genVerticalMode
                };

                _targetForm.uvTrimView_Panel.Controls.Add(nameLabel);
                nameLabel.BringToFront();

                // Offset update
                currentOffset += _targetForm._genVerticalMode ? stripData.StripSize.X : stripData.StripSize.Y;
            }

            _targetForm.uvTrimView_Panel.Invalidate();
            _targetForm.uvTrimView_Panel.Refresh();
        }
    }
}
