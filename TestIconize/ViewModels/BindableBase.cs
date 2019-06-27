using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestIconize.ViewModels
{
  public class BindableBase : INotifyPropertyChanged
  {
    protected BindableBase()
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
      if (object.Equals(field, value))
      {
        return false;
      }

      field = value;
      OnPropertyChanged(propertyName);
      return true;
    }
  }
}