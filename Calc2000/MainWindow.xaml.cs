using System.Windows;
using ME_LabView;
using System.Windows.Controls;
using System;

namespace Calc2000
{
  /// <summary>
  /// Interaktionslogik für MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    Mathematics Calculator = new Mathematics();

    private string TypeSetting;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void ButtonPlus_Click(object sender, RoutedEventArgs e)
    {
      switch (TypeSetting)
      {
        case "radioButtonU8":
          byte ResultU8 = Calculator.Add(Convert.ToByte(TextBoxValue1.Text), Convert.ToByte(TextBoxValue2.Text));
          this.TextBlockResult.Text = ResultU8.ToString();
          break;
        case "radioButtonU16":
          ushort ResultU16 = Calculator.Add(Convert.ToUInt16(TextBoxValue1.Text), Convert.ToUInt16(TextBoxValue2.Text));
          this.TextBlockResult.Text = ResultU16.ToString();
          break;
        case "radioButtonU32":
          uint ResultU32 = Calculator.Add(Convert.ToUInt32(TextBoxValue1.Text), Convert.ToUInt32(TextBoxValue2.Text));
          this.TextBlockResult.Text = ResultU32.ToString();
          break;
        case "radioButtonU64":
          ulong ResultU64 = Calculator.Add(Convert.ToUInt64(TextBoxValue1.Text), Convert.ToUInt64(TextBoxValue2.Text));
          this.TextBlockResult.Text = ResultU64.ToString();
          break;
        case "radioButtonFloat":
          float ResultFloat = Calculator.Add(Convert.ToSingle(TextBoxValue1.Text), Convert.ToSingle(TextBoxValue2.Text));
          this.TextBlockResult.Text = ResultFloat.ToString();
          break;
        case "radioButtonDouble":
          double ResultDouble = Calculator.Add(Convert.ToDouble(TextBoxValue1.Text), Convert.ToDouble(TextBoxValue2.Text));
          this.TextBlockResult.Text = ResultDouble.ToString();
          break;
        default:
          break;
      }
    }

    private void ButtonMinus_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ButtonMul_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ButtonDiv_Click(object sender, RoutedEventArgs e)
    {

    }

    private void radioButton_Checked(object sender, RoutedEventArgs e)
    {
      RadioButton btn = sender as RadioButton;
      this.TypeSetting = btn.Name;
    }
  }
}
