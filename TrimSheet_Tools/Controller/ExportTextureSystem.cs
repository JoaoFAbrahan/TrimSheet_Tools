using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrimSheet_Tools.Controller
{
    internal class ExportTextureSystem
    {
        public string ExportTexture(Image textureImage)
        {
            if (textureImage == null)
            {
                MessageBox.Show("A imagem da textura está nula e não pode ser exportada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Salvar Textura Como...";
                dialog.Filter = "Imagem PNG (*.png)|*.png";
                dialog.DefaultExt = "png";
                dialog.AddExtension = true;
                dialog.FileName = $"TrimTexture_{DateTime.Now:yyyyMMdd_HHmmss}";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    try
                    {
                        textureImage.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show($"Textura exportada com sucesso para:\n{dialog.FileName}", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return dialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exportar a textura:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return string.Empty;
                    }
                }
            }

            return string.Empty;
        }
    }
}
