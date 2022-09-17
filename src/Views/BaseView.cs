using Microsoft.Extensions.DependencyInjection;

namespace DotnetWpfIssue5695Example.Views;

public abstract class BaseView<T> : UserControl, IView
    where T : notnull
{
    public virtual void CreateAndBindViewModel(IServiceProvider serviceProvider) =>
        DataContext = serviceProvider.GetRequiredService<T>();
}
