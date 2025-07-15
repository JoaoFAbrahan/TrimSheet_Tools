using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TrimSheet_Tools.Model;
using TrimSheet_Tools.View;

namespace TrimSheet_Tools.Controller
{
    internal class TrimSheet_DataGridEditSystem
    {
        // Global variables
        private List<StripData> _targetStripDataList;
        private TrimSheet_RebuildingShapeSystem _rebuildShapeSystem;
        private TrimSettings _targetForm;


        /// <summary>
        /// Trim Sheet DataGridView Edit System
        /// </summary>
        /// <param name="_stripDataListRef">StripDataList reference</param>
        /// <param name="rebuildingSystemRef">RebuildSystem reference</param>
        /// <param name="trimSettingsRef">Form reference</param>
        public TrimSheet_DataGridEditSystem(ref List<StripData> _stripDataListRef, ref TrimSheet_RebuildingShapeSystem rebuildingSystemRef, TrimSettings trimSettingsRef)
        {
            // Initialize References
            this._targetStripDataList = _stripDataListRef;
            this._rebuildShapeSystem = rebuildingSystemRef;
            this._targetForm = trimSettingsRef;
        }


        //Methods
        private void UpdateFixedDimensionValues(int resolution, float texelDensity)
        {
            string fixedColumn = _targetForm._genVerticalMode ? "ShapeSizeY" : "ShapeSizeX";
            double totalSize = TrimSheet_Utilities.ConvertUnits_ViewportToCentimeters(1f, resolution, texelDensity);

            for (int i = 0; i < _targetStripDataList.Count; i++)
            {
                _targetForm.stripsInfo_DataGridView.Rows[i].Cells[fixedColumn].Value =
                    totalSize.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// DataGridView EditSystem
        /// </summary>
        /// <param name="e"></param>
        public void DataGridStripEditing(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _targetStripDataList.Count) 
                return;

            try
            {
                // Get parameters
                int index = e.RowIndex;
                StripData currentStrip = _targetStripDataList[index];
                double minSizeFraction = TrimSheet_Utilities.ConvertUnits_CentimetersToViewport(1f, _targetForm._genResolution, _targetForm._genTexelDensity);

                // Verifica se está tentando editar uma coluna que requer split
                bool isEditingConditionalDimension = (!_targetForm._genVerticalMode && e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSizeX"].Index) || (_targetForm._genVerticalMode && e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSizeY"].Index);

                // Validação para dimensões que requerem split
                if (isEditingConditionalDimension && !currentStrip.CheckSplit())
                {
                    MessageBox.Show("Esta dimensão só pode ser editada quando a shape está dividida",
                                    "Edição não permitida", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);

                    // Reverte para o valor total (1 em fração)
                    double totalSize = TrimSheet_Utilities.ConvertUnits_ViewportToCentimeters(1f, _targetForm._genResolution, _targetForm._genTexelDensity);

                    _targetForm.stripsInfo_DataGridView.Rows[index].Cells[_targetForm._genVerticalMode ? "ShapeSizeY" : "ShapeSizeX"].Value = totalSize.ToString("0.##");
                    return;
                }

                // Processa edição do SizeY no modo normal ou SizeX no modo vertical
                if ((!_targetForm._genVerticalMode && e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSizeY"].Index) || (_targetForm._genVerticalMode && e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeSizeX"].Index))
                {
                    // Obtém o novo valor em cm
                    if (!double.TryParse(_targetForm.stripsInfo_DataGridView.Rows[index].Cells[_targetForm._genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double newCmValue))
                    {
                        MessageBox.Show("Valor inválido",
                                        "Erro",
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Error);
                        
                        return;
                    }

                    // Garante o mínimo de 1cm
                    newCmValue = Math.Max(1f, newCmValue);
                    double newSize = TrimSheet_Utilities.ConvertUnits_CentimetersToViewport(newCmValue, _targetForm._genResolution, _targetForm._genTexelDensity);

                    // Calcula o tamanho total já usado pelas shapes anteriores
                    double usedSize = 0f;
                    for (int i = 0; i < index; i++)
                        usedSize += _targetForm._genVerticalMode ? _targetStripDataList[i].StripSize.X : _targetStripDataList[i].StripSize.Y;

                    // Calcula o espaço restante para as shapes seguintes
                    double remainingSize = 1f - usedSize - newSize;
                    int remainingShapes = _targetStripDataList.Count - index - 1;

                    // Verifica se é possível distribuir o espaço mantendo o mínimo
                    if (remainingShapes > 0 && remainingSize < minSizeFraction * remainingShapes)
                    {
                        // Calcula o valor máximo permitido
                        double maxAllowedCm = TrimSheet_Utilities.ConvertUnits_ViewportToCentimeters(1f - usedSize - (minSizeFraction * remainingShapes), _targetForm._genResolution, _targetForm._genTexelDensity);

                        // Limita ao valor máximo permitido
                        newCmValue = Math.Min(newCmValue, maxAllowedCm);
                        newSize = TrimSheet_Utilities.ConvertUnits_CentimetersToViewport(newCmValue, _targetForm._genResolution, _targetForm._genTexelDensity);

                        // Atualiza o valor na grid
                        _targetForm.stripsInfo_DataGridView.Rows[index].Cells[_targetForm._genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value = newCmValue.ToString("0.##", CultureInfo.InvariantCulture);

                        MessageBox.Show($"O valor máximo permitido é {maxAllowedCm.ToString("0.##")} cm",
                                        "Valor inválido", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Warning);

                        return;
                    }

                    // Obtém o tamanho atual
                    double currentSize = _targetForm._genVerticalMode ? currentStrip.StripSize.X : currentStrip.StripSize.Y;
                    double delta = newSize - currentSize;

                    // Se for a última shape, ajusta a penúltima
                    if (index == _targetStripDataList.Count - 1 && index > 0)
                    {
                        StripData prevStrip = _targetStripDataList[index - 1];
                        double prevSize = _targetForm._genVerticalMode ? prevStrip.StripSize.X : prevStrip.StripSize.Y;
                        double newPrevSize = prevSize - delta;

                        // Verifica se a penúltima shape ficaria com menos do que o mínimo
                        if (newPrevSize < minSizeFraction)
                        {
                            double maxAllowedCm = TrimSheet_Utilities.ConvertUnits_ViewportToCentimeters(currentSize + (prevSize - minSizeFraction), _targetForm._genResolution, _targetForm._genTexelDensity);

                            newCmValue = Math.Min(newCmValue, maxAllowedCm);
                            newSize = TrimSheet_Utilities.ConvertUnits_CentimetersToViewport(newCmValue, _targetForm._genResolution, _targetForm._genTexelDensity);

                            _targetForm.stripsInfo_DataGridView.Rows[index].Cells[_targetForm._genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value = newCmValue.ToString("0.##", CultureInfo.InvariantCulture);

                            MessageBox.Show($"O valor máximo permitido é {maxAllowedCm.ToString("0.##")} cm",
                                            "Valor inválido", 
                                            MessageBoxButtons.OK, 
                                            MessageBoxIcon.Warning);

                            return;
                        }

                        // Aplica os ajustes
                        if (_targetForm._genVerticalMode)
                        {
                            prevStrip.StripSize = new Vector2D(newPrevSize, 1f);
                            currentStrip.StripSize = new Vector2D(newSize, 1f);
                        }
                        else
                        {
                            prevStrip.StripSize = new Vector2D(1f, newPrevSize);
                            currentStrip.StripSize = new Vector2D(1f, newSize);
                        }

                        // Atualiza a grid para a penúltima shape
                        _targetForm.stripsInfo_DataGridView.Rows[index - 1].Cells[_targetForm._genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value =TrimSheet_Utilities.ConvertUnits_ViewportToCentimeters(newPrevSize, _targetForm._genResolution, _targetForm._genTexelDensity).ToString("0.##", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        // Redistribui entre as shapes seguintes
                        double remainingSizeAfterChange = 1f - usedSize - newSize;
                        int remainingShapesAfterChange = _targetStripDataList.Count - index - 1;

                        if (remainingShapesAfterChange > 0)
                        {
                            double equalSize = remainingSizeAfterChange / remainingShapesAfterChange;

                            // Aplica o novo tamanho
                            if (_targetForm._genVerticalMode)
                                currentStrip.StripSize = new Vector2D(newSize, 1f);
                            else
                                currentStrip.StripSize = new Vector2D(1f, newSize);

                            // Redistribui para as shapes seguintes
                            for (int i = index + 1; i < _targetStripDataList.Count; i++)
                            {
                                if (_targetForm._genVerticalMode)
                                    _targetStripDataList[i].StripSize = new Vector2D(equalSize, 1f);
                                else
                                    _targetStripDataList[i].StripSize = new Vector2D(1f, equalSize);

                                // Atualiza a grid
                                _targetForm.stripsInfo_DataGridView.Rows[i].Cells[_targetForm._genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value = TrimSheet_Utilities.ConvertUnits_ViewportToCentimeters(equalSize, _targetForm._genResolution, _targetForm._genTexelDensity).ToString("0.##", CultureInfo.InvariantCulture);
                            }
                        }
                    }

                    // Atualiza o valor na grid
                    _targetForm.stripsInfo_DataGridView.Rows[index].Cells[_targetForm._genVerticalMode ? "ShapeSizeX" : "ShapeSizeY"].Value = newCmValue.ToString("0.##", CultureInfo.InvariantCulture);
                }
                // Edição do nome
                else if (e.ColumnIndex == _targetForm.stripsInfo_DataGridView.Columns["ShapeName"].Index)
                {
                    string newName = _targetForm.stripsInfo_DataGridView.Rows[index].Cells["ShapeName"].Value?.ToString();
                    if (!string.IsNullOrEmpty(newName))
                    {
                        currentStrip.StripName = newName;

                        var label = _targetForm.uvTrimView_Panel.Controls.Find($"labelShapeName{index}", false).FirstOrDefault() as Label;
                        if (label != null)
                            label.Text = newName;
                    }
                }

                // Atualiza a dimensão fixa
                UpdateFixedDimensionValues(_targetForm._genResolution, _targetForm._genTexelDensity);

                // Reconstroi a visualização
                _rebuildShapeSystem.Rebuild();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar shape: {ex.Message}", 
                                "Erro", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }
    }
}
