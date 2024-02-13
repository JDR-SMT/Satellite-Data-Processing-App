using Galileo4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SatelliteDataProcessingApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Global
		LinkedList<double> SensorA = new LinkedList<double>();
		LinkedList<double> SensorB = new LinkedList<double>();

		private void LoadData()
		{
			var read = new ReadData();

			SensorA.Clear();
			SensorB.Clear();

			int max = 400;
			double mu = (double)NumericUpDownMu.Value;
			double sigma = (double)NumericUpDownSigma.Value;

			for (int i = 0; i < max; i++)
			{
				SensorA.AddLast(read.SensorA(mu, sigma));
				SensorB.AddLast(read.SensorB(mu, sigma));
			}
		}

		private void ShowAllSensorData()
		{
			ListViewOutput.Items.Clear();

			for (int i = 0; i < NumberOfNodes(SensorA); i++)
			{
				ListViewOutput.Items.Add(SensorA.ElementAt(i).ToString()).SubItems.Add(SensorB.ElementAt(i).ToString());
			}
		}

		private void ButtonLoad_Click(object sender, EventArgs e)
		{
			Clear();
			LoadData();
			ShowAllSensorData();
		}
		#endregion

		#region Utility
		private int NumberOfNodes(LinkedList<double> list)
		{
			return list.Count;
		}

		private void DisplayListBoxData(LinkedList<double> list, ListBox listBox)
		{
			listBox.Items.Clear();

			foreach (double data in list)
			{
				listBox.Items.Add(data);
			}
		}

		private void TextBoxSearchA_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private bool ValidKey(LinkedList<double> list, int key, TextBox textBox)
		{
			if (!string.IsNullOrWhiteSpace(textBox.Text))
			{
				if (key >= (int)list.Min() && key <= (int)list.Max())
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		private void Highlight(LinkedList<double> list, ListBox listBox, int index)
		{
			try
			{
				listBox.ClearSelected();

				if (index == 0)
				{
					for (int i = index; i <= index + 2; i++)
					{
						listBox.SelectedIndex = i;
					}
				}
				else if (index == 399)
				{
					for (int i = index - 2; i <= index; i++)
					{
						listBox.SelectedIndex = i;
					}
				}
				else
				{
					for (int i = index - 2; i <= index + 2; i++)
					{
						listBox.SelectedIndex = i;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
			}
		}

		private void Clear()
		{
			ListBoxA.Items.Clear();
			ListBoxB.Items.Clear();
			TextBoxSelectionTimeA.Clear();
			TextBoxInsertionTimeA.Clear();
			TextBoxIterativeTimeA.Clear();
			TextBoxRecursiveTimeA.Clear();
			TextBoxSelectionTimeB.Clear();
			TextBoxInsertionTimeB.Clear();
			TextBoxIterativeTimeB.Clear();
			TextBoxRecursiveTimeB.Clear();
		}
		#endregion

		#region Sort & Search
		private bool SelectionSort(LinkedList<double> list)
		{
			try
			{
				int min = 0;
				int max = NumberOfNodes(list);

				for (int i = 0; i < max - 1; i++)
				{
					min = i;

					for (int j = i + 1; j < max; j++)
					{
						if (list.ElementAt(j) < list.ElementAt(min))
						{
							min = j;
						}
					}

					LinkedListNode<double> currentMin = list.Find(list.ElementAt(min));
					LinkedListNode<double> currentI = list.Find(list.ElementAt(i));

					var temp = currentMin.Value;
					currentMin.Value = currentI.Value;
					currentI.Value = temp;
				}

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
				return false;
			}
		}

		private bool InsertionSort(LinkedList<double> list)
		{
			try
			{
				int max = NumberOfNodes(list);

				for (int i = 0; i < max - 1; i++)
				{
					for (int j = i + 1; j > 0; j--)
					{
						if (list.ElementAt(j - 1) > list.ElementAt(j))
						{
							LinkedListNode<double> current = list.Find(list.ElementAt(j));

							var temp = current.Value;
							current.Value = current.Previous.Value;
							current.Previous.Value = temp;
						}
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
				return false;
			}
		}

		private int BinarySearchIterative(LinkedList<double> list, int key, int min, int max)
		{
			try
			{
				while (min <= max)
				{
					int mid = (min + max) / 2;

					if (key == list.ElementAt(mid))
					{
						return ++mid;
					}
					else if (key < list.ElementAt(mid))
					{
						max = mid - 1;
					}
					else
					{
						min = mid + 1;
					}
				}

				return min;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
				return -1;
			}
		}

		private int BinarySearchRecursive(LinkedList<double> list, int key, int min, int max)
		{
			try
			{
				if (min <= max)
				{
					int mid = (min + max) / 2;

					if (key == list.ElementAt(mid))
					{
						return mid;
					}
					else if (key < list.ElementAt(mid))
					{
						return BinarySearchRecursive(list, key, min, mid - 1);
					}
					else
					{
						return BinarySearchRecursive(list, key, mid + 1, max);
					}
				}

				return min;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
				return -1;
			}
		}
		#endregion

		#region UI Button
		private void ButtonSelectionSortA_Click(object sender, EventArgs e)
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SelectionSort(SensorA);
			stopwatch.Stop();
			ShowAllSensorData();
			DisplayListBoxData(SensorA, ListBoxA);
			TextBoxSelectionTimeA.Text = $"{stopwatch.ElapsedMilliseconds} Milliseconds";
		}

		private void ButtonInsertionSortA_Click(object sender, EventArgs e)
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			InsertionSort(SensorA);
			stopwatch.Stop();
			ShowAllSensorData();
			DisplayListBoxData(SensorA, ListBoxA);
			TextBoxInsertionTimeA.Text = $"{stopwatch.ElapsedMilliseconds} Milliseconds";
		}

		private void ButtonIterativeSearchA_Click(object sender, EventArgs e)
		{
			int.TryParse(TextBoxSearchA.Text, out int key);

			var stopwatch = new Stopwatch();
			stopwatch.Start();
			int index = BinarySearchIterative(SensorA, key, 0, NumberOfNodes(SensorA));
			stopwatch.Stop();

			Highlight(SensorA, ListBoxA, index);
			TextBoxIterativeTimeA.Text = $"{stopwatch.ElapsedTicks} Ticks";
		}

		private void ButtonRecursiveSearchA_Click(object sender, EventArgs e)
		{
			int.TryParse(TextBoxSearchA.Text, out int key);

			var stopwatch = new Stopwatch();
			stopwatch.Start();
			int index = BinarySearchRecursive(SensorA, key, 0, NumberOfNodes(SensorA));
			stopwatch.Stop();
			Highlight(SensorA, ListBoxA, index);
			TextBoxRecursiveTimeA.Text = $"{stopwatch.ElapsedTicks} Ticks";
		}
		#endregion
	}
}
