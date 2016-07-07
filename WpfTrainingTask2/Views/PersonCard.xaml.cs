using System.Windows;
using System.Windows.Controls;
using WpfTrainingTask2.Models;
using WpfTrainingTask2.ViewModels;

namespace WpfTrainingTask2.Views
{
	/// <summary>
	/// Interaction logic for PersonCard.xaml
	/// </summary>
	public partial class PersonCard : UserControl
	{
		public PersonCard()
		{
			InitializeComponent();
		}

		public PersonViewModel Person
		{
			get { return GetValue(PersonProperty) as PersonViewModel; }
			set { SetValue(PersonProperty, value); }
		}

		public static DependencyProperty PersonProperty = DependencyProperty.Register(
			nameof(Person),
			typeof(PersonViewModel),
			typeof(PersonCard));
	}
}