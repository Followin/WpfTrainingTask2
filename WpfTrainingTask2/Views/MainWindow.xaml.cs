using System.Windows;
using Microsoft.Win32;
using WpfTrainingTask2.Models;
using WpfTrainingTask2.ViewModels;

namespace WpfTrainingTask2.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			DataContext = new PersonViewModel(new Person
			{
				Email = "FirstName_LastName@example.com",
				FirstName = "First name",
				LastName = "LastName",
				PhotoPath = @"http://www.planwallpaper.com/static/images/cool-wallpaper-1.jpg"
			});
		}

		private void ChangePicture(object sender, RoutedEventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				DefaultExt = ".png",
				Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
			};

			var result = openFileDialog.ShowDialog(this);

			if (result == true)
			{
				(DataContext as PersonViewModel).PhotoPath = openFileDialog.FileName;
			}
		}
	}
}