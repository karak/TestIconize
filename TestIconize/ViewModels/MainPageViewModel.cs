using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestIconize.ViewModels
{
  public class MainPageViewModel : BindableBase
  {
    /*
     * fas-play -> fas-pause | (icon) -> fas-(icon)
     * fas-play -> pause | (icon) -> (icon)
     * play -> pause | play -> pause
     */
    private const string PlayIconInitial = "fas-play";
    private readonly string PauseIconToReplace = isOS ? "pause" : "fas-pause";
    private readonly string PlayIconToReplace = isOS ? "play" : "fas-play";
    private string _icon;
    
    public MainPageViewModel()
    {
      _icon = PlayIconInitial;

      ToggleIcon = new Command(() =>
      {
        Icon = Icon == PauseIconToReplace ? PlayIconToReplace : PauseIconToReplace;
      });
    }
    
    public ICommand ToggleIcon { get; }

    public string Icon
    {
      get => _icon;
      set => SetProperty(ref _icon, value);
    }

    private static bool isOS => Device.RuntimePlatform == Device.iOS;
  }
}
