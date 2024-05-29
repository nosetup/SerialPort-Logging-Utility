using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace MyUtilities
{
    internal class MyDgv
    {
        #region Local Variables
        public static string TraceClass;
        #endregion

        #region Constructor
        public MyDgv()
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
        }
        #endregion

        #region Local Methods
        /// <summary>
        /// DataGridView Save text file</summary>
        public void SaveDgvToTxtFile(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (var sw = new StreamWriter(filePath))
                {
                    // Write data
                    for (var i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (var j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            var cellValue = dataGridView.Rows[i].Cells[j].Value;

                            // Check if the cell contains a long string
                            if (j == dataGridView.Columns.Count - 1 && cellValue != null && cellValue.ToString().Contains('\n'))
                            {
                                sw.Write($"{cellValue}");
                            }
                            else if (cellValue != null)
                            {
                                sw.Write($"{cellValue}\t"); // Use tab as delimiter
                            }
                        }
                        sw.WriteLine(); // Move to the next line after writing a row
                    }
                }

                MessageBox.Show("Data saved to file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary> 
        /// DataGridView Open text file</summary>
        public void OpenTxtFileToDgvDialog(DataGridView dataGridView)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog.FileName;
                    // logic to open and process the file content goes here
                    // Display the file content in the DataGridView
                    DisplayFileInDataGridView(dataGridView, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// DataGridView Display text file to window</summary>
        public void DisplayFileInDataGridView(DataGridView dataGridView, string filePath)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath);

                dataGridView.Rows.Clear(); // Clear existing rows

                // Populate the DataGridView with the lines from the file
                foreach (var line in lines)
                {
                    // Split the line into columns based on a delimiter (e.g., tab or comma)
                    var columns = line.Split('\t'); // using \t tabs

                    // Add a new row to the DataGridView and set the cell values
                    dataGridView.Rows.Add(columns);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DataGridView Delete selected row</summary>
        public void DeleteSelectedRows(DataGridView dataGridView)
        {
            // Check if any cell is selected
            if (dataGridView.SelectedCells.Count > 0)
            {
                // Create a HashSet to store unique row indices
                var uniqueRowIndices = new HashSet<int>();

                // Iterate through all selected cells and store unique row indices
                foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                {
                    uniqueRowIndices.Add(cell.RowIndex);
                }

                // Remove the entire rows at the specified indices
                foreach (var rowIndex in uniqueRowIndices.OrderByDescending(i => i))
                {
                    dataGridView.Rows.RemoveAt(rowIndex);
                }
            }
        }

        /// <summary>
        /// DataGridView AutoScroll</summary>
        public void ScrollToLastRecord(DataGridView dataGridView)
        {
            // Scroll to the last displayed row
            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.RowCount - 1;
        }

        /// <summary>
        /// DataGridView Used to set font color after adding a row/record</summary>
        public void SetFontColorForLastRow(DataGridView dataGridView, Color color)
        {
            // Check if there's at least one row
            if (dataGridView.Rows.Count > 0)
            {
                // Set the font color for the cells in the last row
                var lastRow = dataGridView.Rows[dataGridView.Rows.Count - 1];
                foreach (DataGridViewCell cell in lastRow.Cells)
                {
                    cell.Style.ForeColor = color;
                }
            }
        }

        /// <summary>
        /// DataGridView Search a item on a column, hide all non revelant rows</summary>
        public void SearchAndShowResults(DataGridView dataGridView, int columnIndex, string searchTerm)
        {
            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Get the cell in the specified column
                var cell = row.Cells[columnIndex];

                // Check if the cell value contains the search term (case-insensitive)
                if (cell.Value != null && cell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Set the row Visible property to true to show the result
                    row.Visible = true;
                }
                else
                {
                    // If the cell value doesn't contain the search term, hide the row
                    row.Visible = false;
                }
            }
        }

        /// <summary>
        /// DataGridView Set all rows to Visible</summary>
        public void UnhideAllRows(DataGridView dataGridView)
        {
            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Set the Visible property to true to unhide the row
                row.Visible = true;
            }
        }

        /// <summary>
        /// Verify cell is an integer, Return True if integer</summary>
        public bool VerifyIntInCell(DataGridViewCell cell)
        {
            if (cell != null)
            {
                var cellValue = cell.Value?.ToString();
                if (int.TryParse(cellValue, out _)) // Valid Integer
                {
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verify cell is an integer otherwise set to nums. "min value"</summary>
        public int VerifyReplaceIntInCell(DataGridViewCell cell, int nums)
        {
            if (cell != null)
            {
                var cellValue = cell.Value?.ToString();
                if (int.TryParse(cellValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var intValue))
                    //if (int.TryParse(cellValue, out var intValue)) // Valid Integer
                {
                    if (intValue >= nums) // Handle the case where delay is "0", we set to min value ="1"
                    {
                        return intValue;
                    }
                }
                else
                {
                    Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : ERROR Fail to Parse");
                }
            }
            else
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : ERROR Cell is null");
            }
            return nums;
        }

        /// <summary>
        /// Verify cell is an integer, Return True if integer</summary>
        public bool VerifyHexStringInCell(DataGridViewCell cell) 
        {
            if (cell != null)
            {
                var cellValue = cell.Value?.ToString();
                cellValue = ByteArrayToHexString(HexStringToByteArray(cellValue));
                if (cellValue == null) return false;
                else return true;
            }
            return false;
        }

        /// <summary>
        /// Verify cell is an hexstring otherwise set to hexstring</summary>
        public string VerifyReplaceHexStringInCell(DataGridViewCell cell, string hexstring)
        {
            if (cell != null)
            {
                var cellValue = cell.Value?.ToString();
                cellValue = ByteArrayToHexString(HexStringToByteArray(cellValue));
                if ( cellValue == null) return hexstring;
                else return cellValue;
            }
            return hexstring;
        }


        /// <summary> Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>
        /// <param name="s"> The string containing the hex digits (with or without spaces). </param>
        /// <returns> Returns an array of bytes. </returns>
        public byte[] HexStringToByteArray(string s)
        {
            if (s == null) return null;
            try
            {
#if DEBUG
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : String : {s}");
#endif
                s = s.TrimEnd(); // Trim trailing spaces from the input string
                s = s.Replace(" ", ""); // Remove spaces from the modified string
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : Unexpected Exception ex : {ex.Message}");
            }

            // If the input string is empty or has an odd length, return null
            if (s.Length == 0 || s.Length % 2 != 0)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : 'input string is empty or has an odd length' : var='{s}'");
                return null;
            }
            var buffer = new byte[s.Length / 2];
            for (var i = 0; i < s.Length; i += 2)
            {
                var hexByte = s.Substring(i, 2);
                if (!byte.TryParse(hexByte, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result))
                {
                    // Unable to parse the substring as a byte
                    Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : 'Unable to parse the substring as a byte' : var='{s}'");
                    return null;
                }
                buffer[i / 2] = result;
            }
            return buffer;
        }

        /// <summary> Converts an array of bytes into a formatted string of hex digits (ex: E4 CA B2)</summary>
        /// <param name="data"> The array of bytes to be translated into a string of hex digits. </param>
        /// <returns> Returns a well formatted string of hex digits with spacing. </returns>
        public string ByteArrayToHexString(byte[] data)
        {
            if (data == null)
            {
                Trace.WriteLine($"{TraceClass} : {MethodBase.GetCurrentMethod().Name} : ' Input byte array cannot be null'");
                return null;
            }

            var sb = new StringBuilder(data.Length * 3);
            foreach (var b in data)
            {
                sb.Append(b.ToString("X2").PadRight(3)); // Pad each byte with spaces to ensure each occupies 3 characters
            }
            return sb.ToString().ToUpper().TrimEnd(); // Convert to uppercase and trim trailing spaces
        }

#endregion
    }
}
