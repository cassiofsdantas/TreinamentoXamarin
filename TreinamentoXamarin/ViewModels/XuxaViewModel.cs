using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using TreinamentoXamarin.Models;
using Xamarin.Forms;

namespace TreinamentoXamarin.ViewModels
{
	public class XuxaViewModel : ExtendedBindableObject
	{
		private IEnumerable ativos = new List<Ativo>() 
		{ 
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"},
			new Ativo() { NomeAtivo = "asdsa", SiglaAtivo = "hdsah dba"}
		};

		public IEnumerable Ativos 
		{ 
			get => ativos; 
			set => SetProperty(ref ativos, value); 
		}

		private IEnumerable ativos2 = new List<Ativo>()
		{
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"},
			new Ativo() { NomeAtivo = "asodisyhagdvsa", SiglaAtivo = "hddsghaa"}
		};

		public IEnumerable Ativos2
		{
			get => ativos2;
			set => SetProperty(ref ativos2, value);
		}

		private bool isEnabled;

		public bool IsEnabled
		{
			get => isEnabled;
			set => SetProperty(ref isEnabled, value);
		}

		public ICommand ChangeIsEnabledCommand { get; set; }

		public XuxaViewModel() 
		{
			ChangeIsEnabledCommand = new Command(() => { IsEnabled = !IsEnabled; });
		}

	}
}
