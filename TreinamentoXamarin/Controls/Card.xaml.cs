using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TreinamentoXamarin.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Card : ContentView
	{
		public static readonly BindableProperty CardBackgroundColorProperty =
			 BindableProperty.Create(nameof(CardBackgroundColor), typeof(Color), typeof(Card), Color.FromHex("#526177"));

		public Color CardBackgroundColor 
		{
			get => (Color)GetValue(CardBackgroundColorProperty);
			set => SetValue(CardBackgroundColorProperty, value);
		}

		public static readonly BindableProperty ActionCommandProperty =
			 BindableProperty.Create(nameof(ActionCommand), typeof(ICommand), typeof(Card));

		public ICommand ActionCommand
		{
			get => (ICommand)GetValue(ActionCommandProperty);
			set => SetValue(ActionCommandProperty, value);
		}

		public static readonly BindableProperty ActionCommandParameterProperty =
			 BindableProperty.Create(nameof(ActionCommandParameter), typeof(object), typeof(Card));

		public object ActionCommandParameter
		{
			get => GetValue(ActionCommandParameterProperty);
			set => SetValue(ActionCommandParameterProperty, value);
		}

		public View BuscaConteudo 
		{
			get => buscaConteudo.Content;
			set => buscaConteudo.Content = value;
		}

		public View ComponentesConteudo
		{
			get => componentesConteudo.Content;
			set => componentesConteudo.Content = value;
		}

		public Card()
		{
			InitializeComponent();
		}
	}
}