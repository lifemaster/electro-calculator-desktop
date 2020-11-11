using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroCalculatorDesktop
{
    public partial class ElectroCalculatorForm : Form
    {
        static readonly decimal lessThan100kwtTariff = 0.90M;
        static readonly decimal moreThan100kwtTariff = 1.68M;

        public ElectroCalculatorForm()
        {
            InitializeComponent();
        }

        private void PrevValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calculateButton.PerformClick();
        }

        private void CurrentValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calculateButton.PerformClick();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string prevValue = prevValueTextBox.Text;
            string currentValue = currentValueTextBox.Text;

            int[] values = this.ValidateUserInput(prevValue, currentValue);

            if (values == null)
            {
                return;
            }

            int prevValueInt = values[0];
            int currentValueInt = values[1];

            string resultMessage = this.GetCalculationResult(prevValueInt, currentValueInt);

            this.ShowCalculateResultMessageBox(resultMessage);
        }

        private int[] ValidateUserInput(string prevValue, string currentValue)
        {
            if (!Int32.TryParse(prevValue, out int prevValueInt))
            {
                this.ShowErrorMessageBox("Предыдущее показание счетчика должно быть целым числом и меньше, чем 2147483647");
                return null;
            }

            if (!Int32.TryParse(currentValue, out int currentValueInt))
            {
                this.ShowErrorMessageBox("Текущее показание счетчика должно быть целым числом и меньше, чем 2147483647");
                return null;
            }

            if (prevValueInt <= 0)
            {
                this.ShowErrorMessageBox("Предыдущее показание счетчика должно быть больше нуля");
                return null;
            }

            if (currentValueInt <= 0)
            {
                this.ShowErrorMessageBox("Текущее показание счетчика должно быть больше нуля");
                return null;
            }

            if (prevValueInt > currentValueInt)
            {
                this.ShowErrorMessageBox("Предыдущее показание не может быть больше, чем текущее");
                return null;
            }

            if (prevValueInt == currentValueInt)
            {
                this.ShowCalculateResultMessageBox("Вы не пользовались электричеством, поэтому ничего не должны платить");
                return null;
            }

            return new int[] { prevValueInt, currentValueInt };
        }

        private void ShowErrorMessageBox(string textError)
        {
            MessageBox.Show(textError, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowCalculateResultMessageBox(string textError)
        {
            MessageBox.Show(textError, "Результат расчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetCalculationResult(int prevIntValue, int currentIntValue)
        {
            int totalCount = currentIntValue - prevIntValue;
            string result = $"Вы израсходовали {totalCount} кВт·ч:\n\n";

            if (totalCount <= 100)
            {
                result += $"{totalCount} кВт·ч · {lessThan100kwtTariff} грн/кВт·ч = {totalCount * lessThan100kwtTariff} грн";
                result += "\n\n";
                result += $"Итого к оплате: {totalCount * lessThan100kwtTariff} грн";
            }
            else
            {
                result += $"100 кВт·ч · {lessThan100kwtTariff} грн/кВт·ч = {lessThan100kwtTariff * 100} грн";
                result += "\n";
                result += $"{totalCount - 100} кВт·ч · {moreThan100kwtTariff} грн/кВт·ч = {(totalCount - 100) * moreThan100kwtTariff} грн";
                result += "\n\n";
                result += $"Итого к оплате: {lessThan100kwtTariff * 100 + (totalCount - 100) * moreThan100kwtTariff} грн";
            }

            return result;
        }
    }
}
