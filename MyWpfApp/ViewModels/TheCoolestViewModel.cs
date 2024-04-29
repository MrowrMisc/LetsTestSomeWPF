using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyWpfApp;

public class TheCoolestViewModel : INotifyPropertyChanged
{
    private string? _myTextProperty;

    public string? MyTextProperty
    {
        get { return _myTextProperty; }
        set
        {
            _myTextProperty = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
