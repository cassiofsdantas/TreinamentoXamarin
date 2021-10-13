using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace TreinamentoXamarin.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : FormsApplicationPage
	{
		public MainWindow()
		{
			InitializeComponent();
			Forms.Init();
			LoadApplication(new TreinamentoXamarin.App());
		}
	}
}
