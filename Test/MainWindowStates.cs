using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Test
{
	class MainWindowStates
	{
		bool IsNormalState { get; set; } =  true;
		bool IsReaderSelecting { get; set; } = false;

		private MainWindow win_ref;
		public MainWindowStates(MainWindow mainWindow)
		{ 
			win_ref = mainWindow;
		}

		public void StartReaderSelection()
		{
			IsNormalState = false;
			IsReaderSelecting = true;
			foreach (var item in win_ref.tabControl.Items)
			{
				(item as TabItem).IsEnabled = false;
			}
			win_ref.tabReaders.IsSelected = true;
			win_ref.expManagement.IsExpanded = false;
			win_ref.expManagement.IsEnabled = false;
			win_ref.bSelectReader.Visibility = Visibility.Visible;
			MessageBox.Show("Выберите читателя", "Помощь", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		public void EndReaderSelection()
		{
			IsNormalState = true;
			IsReaderSelecting = false;
			foreach (var item in win_ref.tabControl.Items)
			{
				(item as TabItem).IsEnabled = true;
			}
			win_ref.tabPrintEditions.IsSelected = true;
			win_ref.expManagement.IsExpanded = true;
			win_ref.expManagement.IsEnabled = true;
			win_ref.bSelectReader.Visibility = Visibility.Collapsed;
		}

	}
}
