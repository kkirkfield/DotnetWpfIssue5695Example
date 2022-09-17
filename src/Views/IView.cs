namespace DotnetWpfIssue5695Example.Views;

public interface IView
{
    void CreateAndBindViewModel(IServiceProvider serviceProvider);
}
