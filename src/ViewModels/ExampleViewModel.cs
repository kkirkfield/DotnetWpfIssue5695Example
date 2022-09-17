namespace DotnetWpfIssue5695Example.ViewModels;

public partial class ExampleViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _exampleString;
}
