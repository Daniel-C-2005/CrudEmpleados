namespace MauiCRUD
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            // Crear instancia de frmEmpleado
            frmEmpleado frm_Empleado = new frmEmpleado();

            // Llamar a PushAsync de Navigation
            await Navigation.PushAsync(frm_Empleado);
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}