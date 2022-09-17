namespace DotnetWpfIssue5695Example;

public partial class MainWindow : Window
{
    public MainWindow(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _exampleView.CreateAndBindViewModel(serviceProvider);
    }
}
