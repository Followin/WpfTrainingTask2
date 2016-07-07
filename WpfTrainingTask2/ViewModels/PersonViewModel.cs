using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfTrainingTask2.Annotations;
using WpfTrainingTask2.Models;

namespace WpfTrainingTask2.ViewModels
{
	public class PersonViewModel : INotifyPropertyChanged
	{
		private Person person;

		public PersonViewModel(Person person)
		{
			this.person = person;
		}

		public string FirstName
		{
			get { return person.FirstName; }
			set
			{
				person.FirstName = value;
				OnPropertyChanged();
			}
		}

		public string LastName
		{
			get { return person.LastName; }
			set
			{
				person.LastName = value;
				OnPropertyChanged();
			}
		}

		public string PhotoPath
		{
			get { return person.PhotoPath; }
			set
			{
				person.PhotoPath = value;
				OnPropertyChanged();
			}
		}

		public string Email
		{
			get { return person.Email; }
			set
			{
				person.Email = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}