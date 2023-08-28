using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CoordinationSpheresProject.Polyhedrons;
using CoordinationSpheresProject.ViewModels;

namespace CoordinationSpheresProject
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MainViewModel _viewmodel;
		public MainWindow()
		{
			
			this.InitializeComponent();
			_viewmodel=new MainViewModel();
			this.DataContext=_viewmodel;

			// Insert code required on object creation below this point.
		}		
		
	}
}