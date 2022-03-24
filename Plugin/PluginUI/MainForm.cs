using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KompasWrapper;
using Plugin;

namespace PluginUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса построителя
        /// </summary>
        private CardanForkBuilder _cardanForkBuilder;

        /// <summary>
        /// Объект класса с параметрами
        /// </summary>
        private CardanForkParameters _cardanForkParameters =
            new CardanForkParameters();

        /// <summary>
        /// Словарь содержащий пары (Текстбоксы, имя параметра)
        /// </summary>
        private Dictionary<TextBox, ParameterNames> _textBoxesDictionary;

        /// <summary>
        /// Конструктор главной формы с необходимыми инициализациями
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _textBoxesDictionary = new Dictionary<TextBox, ParameterNames>
            {
                {BaseHeightTextBox, ParameterNames.BaseHeight},
                {BaseLengthTextBox, ParameterNames.BaseLength},
                {BaseWidthTextBox, ParameterNames.BaseWidth},
                {BaseHoleDiameterTextBox, ParameterNames.BaseHoleDiameter},
                {WallHoleDiameterTextBox, ParameterNames.WallHoleDiameter},
                {WallThicknessTextBox, ParameterNames.WallThickness},
                {HeightTextBox, ParameterNames.Height}
            };

            foreach (var textBox in _textBoxesDictionary)
            {
                textBox.Key.Text = _cardanForkParameters
                    .GetParameterValueByName(textBox.Value).ToString();
            }
        }

        /// <summary>
        /// Устанавливает стиль для проверенного значения
        /// </summary>
        /// <param name="sender">Текстбокс</param>
        private void TextBox_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                BuildButton.Enabled = true;
                textBox.BackColor = Color.White;
                toolTip.Active = false;
            }
        }

        /// <summary>
        /// Общий метод валидации текстбокса
        /// </summary>
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;

            try
            {
                _textBoxesDictionary.TryGetValue(textBox,
                    out var parameterInTextBoxName);
                _cardanForkParameters.SetParameterByName(parameterInTextBoxName,
                    int.Parse(textBox.Text));
                
                if (textBox == BaseWidthTextBox)
                {
                    BaseLengthTextBox.Text =
                        _cardanForkParameters.BaseLength.ToString();
                    WallHoleDiameterTextBox.Text =
                        _cardanForkParameters.WallHoleDiameter.ToString();
                }
                else if (textBox == BaseLengthTextBox)
                {
                    BaseWidthTextBox.Text =
                        _cardanForkParameters.BaseWidth.ToString();
                }
                else if (textBox == WallHoleDiameterTextBox)
                {
                    BaseWidthTextBox.Text =
                        _cardanForkParameters.BaseWidth.ToString();
                }
            }
            catch (Exception exception)
            {
                BuildButton.Enabled = false;
                textBox.BackColor = Color.LightSalmon;
                toolTip.Active = true;
                toolTip.SetToolTip(textBox, exception.Message);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Построить"
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            var connector = new KompasConnector();
            _cardanForkBuilder =
                new CardanForkBuilder(_cardanForkParameters, connector);

            _cardanForkBuilder.BuildCardanFork();
        }
    }
}
