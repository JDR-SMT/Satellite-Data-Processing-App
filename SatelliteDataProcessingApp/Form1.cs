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
		// 4.1	Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic 
		// namespace. The data must be of type “double”; you are not permitted to use any additional classes, 
		// nodes, pointers or data structures (array, list, etc) in the implementation of this application. 
		// The two LinkedLists of type double are to be declared as global within the “public partial class”.
		LinkedList<double> SensorA = new LinkedList<double>();
		LinkedList<double> SensorB = new LinkedList<double>();

		// 4.2	Copy the Galileo.DLL file into the root directory of your solution folder and add the appropriate 
		// reference in the solution explorer. Create a method called “LoadData” which will populate both 
		// LinkedLists. Declare an instance of the Galileo library in the method and create the appropriate loop 
		// construct to populate the two LinkedList; the data from Sensor A will populate the first LinkedList, 
		// while the data from Sensor B will populate the second LinkedList. The LinkedList size will be hardcoded
		// inside the method and must be equal to 400. The input parameters are empty, and the return type is void.
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

		// 4.3	Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a ListView.
		// Add column titles “Sensor A” and “Sensor B” to the ListView. The input parameters are empty, and the return type is void.
		private void ShowAllSensorData()
		{
			ListViewOutput.Items.Clear();

			for (int i = 0; i < NumberOfNodes(SensorA); i++)
			{
				ListViewOutput.Items.Add(SensorA.ElementAt(i).ToString()).SubItems.Add(SensorB.ElementAt(i).ToString());
			}
		}

		// 4.4	Create a button and associated click method that will call the LoadData and  
		// ShowAllSensorData methods. The input parameters are empty, and the return type is void.
		private void ButtonLoad_Click(object sender, EventArgs e)
		{
			Clear();
			LoadData();
			ShowAllSensorData();
		}
		#endregion

		#region Utility
		// 4.5	Create a method called “NumberOfNodes” that will return an integer which is the number of 
		// nodes(elements) in a LinkedList. The method signature will have an input parameter of type 
		// LinkedList, and the calling code argument is the linkedlist name.
		private int NumberOfNodes(LinkedList<double> list)
		{
			return list.Count;
		}

		// 4.6	Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the 
		// appropriate ListBox. The method signature will have two input parameters; a LinkedList, and the 
		// ListBox name.  The calling code argument is the linkedlist name and the listbox name.
		private void DisplayListBoxData(LinkedList<double> list, ListBox listBox)
		{
			listBox.Items.Clear();

			foreach (double data in list)
			{
				listBox.Items.Add(data);
			}
		}

		// 4.14	Add textboxes for the search value; one for each sensor, ensure only numeric integer values can be entered.
		private void TextBoxSearchA_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void Highlight(LinkedList<double> list, ListBox listBox, int index)
		{
			listBox.ClearSelected();

			if (index == -1)
			{
				return;
			}
			else if (index == 0)
			{
				for (int i = index; i <= index + 2; i++)
				{
					listBox.SelectedIndex = i;
				}
			}
			else if (index == NumberOfNodes(list) - 1)
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

		private void Clear()
		{
			ListBoxA.Items.Clear();
			ListBoxB.Items.Clear();
			TextBoxSearchA.Clear();
			TextBoxSearchB.Clear();
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
		// 4.7	Create a method called “SelectionSort” which has a single input parameter of type  
		// LinkedList, while the calling code argument is the linkedlist name. The method code must 
		// follow the pseudo code supplied below in the Appendix. The return type is Boolean.
		private bool SelectionSort(LinkedList<double> list)
		{
			bool sort;

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

				sort = true;
			}
			catch (Exception ex)
			{
				sort = false;
				MessageBox.Show($"Error {ex.Message}");
			}

			return sort;
		}

		// 4.8	Create a method called “InsertionSort” which has a single parameter of type
		// LinkedList, while the calling code argument is the linkedlist name. The method code
		// must follow the pseudo code supplied below in the Appendix. The return type is Boolean.
		private bool InsertionSort(LinkedList<double> list)
		{
			bool sort;

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

				sort = true;
			}
			catch (Exception ex)
			{
				sort = false;
				MessageBox.Show($"Error {ex.Message}");
			}

			return sort;
		}

		// 4.9	Create a method called “BinarySearchIterative” which has the following four parameters:
		// LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the
		// linkedlist element from a successful search or the nearest neighbour value. The calling code
		// argument is the linkedlist name, search value, minimum list size and the number of nodes in
		// the list. The method code must follow the pseudo code supplied below in the Appendix.
		private int BinarySearchIterative(LinkedList<double> list, int key, int min, int max)
		{
			int index;

			try
			{
				while (min <= max) // min <= max - 1 does not return the last list item
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

				index = min;
			}
			catch (Exception ex)
			{
				index = -1;
				MessageBox.Show($"Error {ex.Message}");
			}

			return index;
		}

		// 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters:
		// LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the
		// linkedlist element from a successful search or the nearest neighbour value. The calling code
		// argument is the linkedlist name, search value, minimum list size and the number of nodes in
		// the list. The method code must follow the pseudo code supplied below in the Appendix.
		private int BinarySearchRecursive(LinkedList<double> list, int key, int min, int max)
		{
			int index;

			try
			{
				if (min <= max) // min <= max - 1 does not return the last list item
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

				index = min;
			}
			catch (Exception ex)
			{
				index = -1;
				MessageBox.Show($"Error {ex.Message}");
			}

			return index;
		}
		#endregion

		#region UI Button
		// 4.11	Create button click methods that will search the LinkedList for an
		// integer value entered into a textbox on the form. The four methods are:
		//		1.	Method for Sensor A and Binary Search Iterative
		//		2.	Method for Sensor A and Binary Search Recursive
		//		3.	Method for Sensor B and Binary Search Iterative
		//		4.	Method for Sensor B and Binary Search Recursive
		// The search code must check to ensure the data is sorted, then start a stopwatch before calling
		// the search method. Once the search is complete the stopwatch will stop, and the number
		// of ticks will be displayed in a read only textbox. Finally, the code/method will call the 
		// “DisplayListboxData” method and highlight the search target number and two values on each side.
		private void ButtonIterativeSearchA_Click(object sender, EventArgs e)
		{
			try
			{
				int key = int.Parse(TextBoxSearchA.Text);

				var stopwatch = new Stopwatch();
				stopwatch.Start();
				int index = BinarySearchIterative(SensorA, key, 0, NumberOfNodes(SensorA));
				stopwatch.Stop();

				Highlight(SensorA, ListBoxA, index);
				TextBoxIterativeTimeA.Text = $"{stopwatch.ElapsedTicks} Ticks";
				// does not call DisplayListBoxData as this is called when sorting
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
			}
		}

		private void ButtonRecursiveSearchA_Click(object sender, EventArgs e)
		{
			try
			{
				int key = int.Parse(TextBoxSearchA.Text);

				var stopwatch = new Stopwatch();
				stopwatch.Start();
				int index = BinarySearchRecursive(SensorA, key, 0, NumberOfNodes(SensorA));
				stopwatch.Stop();

				Highlight(SensorA, ListBoxA, index);
				TextBoxRecursiveTimeA.Text = $"{stopwatch.ElapsedTicks} Ticks";
				// does not call DisplayListBoxData as this is called when sorting
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
			}
		}

		private void ButtonIterativeSearchB_Click(object sender, EventArgs e)
		{
			try
			{
				int key = int.Parse(TextBoxSearchB.Text);

				var stopwatch = new Stopwatch();
				stopwatch.Start();
				int index = BinarySearchIterative(SensorB, key, 0, NumberOfNodes(SensorB));
				stopwatch.Stop();

				Highlight(SensorB, ListBoxB, index);
				TextBoxIterativeTimeB.Text = $"{stopwatch.ElapsedTicks} Ticks";
				// does not call DisplayListBoxData as this is called when sorting
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
			}
		}

		private void ButtonRecursiveSearchB_Click(object sender, EventArgs e)
		{
			try
			{
				int key = int.Parse(TextBoxSearchB.Text);

				var stopwatch = new Stopwatch();
				stopwatch.Start();
				int index = BinarySearchRecursive(SensorB, key, 0, NumberOfNodes(SensorB));
				stopwatch.Stop();

				Highlight(SensorB, ListBoxB, index);
				TextBoxRecursiveTimeB.Text = $"{stopwatch.ElapsedTicks} Ticks";
				// does not call DisplayListBoxData as this is called when sorting
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}");
			}
		}

		// 4.12	Create button click methods that will sort the LinkedList using
		// the Selection and Insertion methods. The four methods are:
		//		1.	Method for Sensor A and Selection Sort
		//		2.	Method for Sensor A and Insertion Sort
		//		3.	Method for Sensor B and Selection Sort
		//		4.	Method for Sensor B and Insertion Sort
		// The button method must start a stopwatch before calling the sort method.
		// Once the sort is complete the stopwatch will stop, and the number of
		// milliseconds will be displayed in a read only textbox.Finally, the code/method
		// will call the “ShowAllSensorData” method and “DisplayListboxData” for the appropriate sensor.

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

		private void ButtonSelectionSortB_Click(object sender, EventArgs e)
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SelectionSort(SensorB);
			stopwatch.Stop();

			ShowAllSensorData();
			DisplayListBoxData(SensorB, ListBoxB);
			TextBoxSelectionTimeB.Text = $"{stopwatch.ElapsedMilliseconds} Milliseconds";
		}

		private void ButtonInsertionSortB_Click(object sender, EventArgs e)
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			InsertionSort(SensorB);
			stopwatch.Stop();

			ShowAllSensorData();
			DisplayListBoxData(SensorB, ListBoxB);
			TextBoxInsertionTimeB.Text = $"{stopwatch.ElapsedMilliseconds} Milliseconds";
		}
		#endregion
	}
}
