using Avalonia.Controls;
using Avalonia.Interactivity; /*ERROR 1.- para usar RoutedEventArgs*/

namespace E20_Formulario;

public partial class MainWindow : Window
{
    private int envios = 0;

    public MainWindow()
    {
        InitializeComponent();
        EnviarBoton.Click += Enviar_Click; /*ERROR 2 .- mayúsculas */
        LimpiarBoton.Click += Limpiar_Click;/*ERROR 3 .- ; para ejecutar la línea y sobran los ()*/
    }

    private void Enviar_Click(object? sender, RoutedEventArgs e)
    {
        envios++;
        Resultado.Text = "Envíos: " + envios; /*ERROR 5 .- Concatenamos el INT para que pase a STRING*/
        Resultado.Text += " · " + NombreBox.Text; /*ERROR 6 .- la propiedad se llama NombreBox*/
    }

    private void Limpiar_Click(object? sender, RoutedEventArgs e)
    {
        NombreBox.Text = "";
        Resultado.Text = "";
    }
}
