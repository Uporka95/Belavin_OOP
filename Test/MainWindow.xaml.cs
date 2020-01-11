using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using Microsoft.Win32;

namespace Test
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		MainWindowStates windowStates; 
		Library lib = new Library("Библиотека ПНИПУ");
		public MainWindow()
		{
			InitializeComponent();
			windowStates = new MainWindowStates(this);
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			lbReaders.ItemsSource = lib.readers;
			LibGrid.ItemsSource = lib;
			lvJournal.ItemsSource = lib.journal;
		}

		private void LibGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
		{
			e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor).DisplayName;
			if (e.PropertyType == typeof(System.DateTime))
				(e.Column as DataGridTextColumn).Binding.StringFormat = "dd/MM/yyyy";
		}

		private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
		
		private void ComboBox_Loaded(object sender, RoutedEventArgs e)
		{
			cbCategoryChooser.ItemsSource = PrintEdition.HierarhyDictionary.Values;
			cbKeyChooser.SelectedIndex = 0;
			cbCategoryChooser.SelectedIndex = 0;
			tbSearching.TextChanged += TextBox_TextChanged;
		}

		private void FilterBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Type selected_type = PrintEdition.GetTypename(cbCategoryChooser.SelectedItem.ToString());
			lib.SelectCategory(selected_type);
			cbKeyChooser.ItemsSource = RuntimeTools.GetPropertiesDispNames(selected_type);
			cbKeyChooser.SelectedIndex = 0;
			LibGrid.ItemsSource = lib.CurrentSelection;
		}	

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			Type selected_type = PrintEdition.GetTypename((string)cbCategoryChooser.SelectedValue);
			Type t = lib.CurrentSelection.GetType().GetGenericArguments()[0];
			string CurPropName = RuntimeTools.GetPropertyName(t, (string)cbKeyChooser.SelectedValue);
			var query = from item in lib.CurrentSelection
								  where (t.GetProperty(CurPropName).GetValue(item).ToString()).Contains(tbSearching.Text)
								  select item;

			LibGrid.ItemsSource = (IEnumerable)RuntimeTools.CastToList(query, selected_type);

		}

		public void FilterSelection(string text)
		{

		}

		private void cbKeyChooser_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void bBuyPE_Click(object sender, RoutedEventArgs e)
		{
			lib.Buy(typeof(Textbook), 5);
			lib.Buy(typeof(Newspaper), 5);
			lib.Buy(typeof(Magazine), 5);
			lib.Buy(typeof(Fiction), 5);

			RefrshAll();
		}

		private void RefrshAll()
		{
			Type selected_type = PrintEdition.GetTypename(cbCategoryChooser.SelectedItem.ToString());
			lib.SelectCategory(selected_type);
			LibGrid.ItemsSource = lib.CurrentSelection;
			tbSearching.Clear();
			lvJournal.Items.Refresh();
		}

		private void bJournalClear_Click(object sender, RoutedEventArgs e)
		{
			
			lib.journal.Clear();
			lvJournal.Items.Refresh();
			MessageBox.Show("Журнал очищен", "", MessageBoxButton.OK, MessageBoxImage.Warning);
		}

		private void bSaveJournal_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == true)
				lib.journal.OverwriteTo(saveFileDialog.FileName);

		}

		private void bDiscard_Click(object sender, RoutedEventArgs e)
		{

			if (!lib.Discard(LibGrid.SelectedItems.Cast<PrintEdition>().ToArray()))
			{
				MessageBox.Show("Одна или несколько из выбранных книг находятся у читателей", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
			}
			RefrshAll();
		}

		private void lbReaders_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			dgReadersBooks.ItemsSource = (e.AddedItems[0] as Reader).SharedBooks;
		}

		private void dgReadersBooks_Loaded(object sender, RoutedEventArgs e)
		{
			dgReadersBooks.AutoGeneratingColumn += LibGrid_AutoGeneratingColumn;
		}

		private void bShare_Click(object sender, RoutedEventArgs e)
		{
			if (LibGrid.SelectedItem != null)
				windowStates.StartReaderSelection();
			else MessageBox.Show("Выделите книги из списка", "Помощь",MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void bSelectReader_Click(object sender, RoutedEventArgs e)
		{
			if (lbReaders.SelectedItem != null)
			{
				if (!lib.Share(lbReaders.SelectedItem as Reader, LibGrid.SelectedItems.Cast<PrintEdition>().ToArray()))
					MessageBox.Show("Одна или несколько из выбранных книг находятся у читателей", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
				windowStates.EndReaderSelection();
				RefrshAll();

			}
			else MessageBox.Show("Выберите читателя", "Помощь", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void bTakeBack_Click(object sender, RoutedEventArgs e)
		{
			if (LibGrid.SelectedItem != null)
				if (!lib.TakeBack(LibGrid.SelectedItems.Cast<PrintEdition>().ToArray()))
				{
					MessageBox.Show("Одна или несколько из выбранных книг уже находятся в библиотеке", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
				}
				else
				{
					MessageBox.Show("Книги успешно приняты", "Помощь", MessageBoxButton.OK, MessageBoxImage.Information);
					RefrshAll();
				}
		}
	}

	
}
