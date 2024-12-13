using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StripToGrid
{
    public partial class frmBase : Form
    {
        public Bitmap InputImage;
        public Bitmap OutputImage;
        public List<int[]> SpritesStartEndPoints = new List<int[]>();

        public frmBase()
        {
            InitializeComponent();
        }




        // --- ERROR CHECK FUNCTIONS ---
        public string ComputeErrorMessage(bool[] conditions, string[] messages)
        {
            string message = "";

            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i])
                {
                    try
                    {
                        message += messages[i] + "\n";
                    }
                    catch (IndexOutOfRangeException)
                    {
                        message += $"ERROR for condition {i}" + "\n";
                    }
                }
            }
            return message;
        }

        public bool CanCreateGridCheck()
        {
            bool[] errorConditions = {
                picBaseImage.Image == null
            };

            string[] errorMessages = {
                "- No Input Image Loaded"
            };

            string errorMessage = ComputeErrorMessage(errorConditions, errorMessages);

            if (String.IsNullOrEmpty(errorMessage)) return true;
            else
            {
                MessageBox.Show(errorMessage);
                return false;
            }
        }




        // --- IMAGE LOAD/SAVE FUNCTIONS ---
        public void SelectImage()
        {
            if (ofdImageSelect.ShowDialog() == DialogResult.OK)
            {
                InputImage = new Bitmap(ofdImageSelect.FileName);
                picBaseImage.Image = InputImage;
                GetSpritesStartEndPoints();
            }
        }

        public void SaveImage()
        {
            if (sfdOutputImage.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(sfdOutputImage.FileName))
            {
                OutputImage.Save(sfdOutputImage.FileName);
            }
        }




        // --- GRID COMPUTING FUNCTIONS ---
        public void GetSpritesStartEndPoints()
        {
            SpritesStartEndPoints.Clear();

            int cellStartX = 0;
            bool cellStartFound = false;

            for (int x = 0; x < InputImage.Width; x++)
            {
                bool isColumnEmpty = true;

                for (int y = 0; y < InputImage.Height; y++)
                {
                    if (InputImage.GetPixel(x, y).A != 0)
                    {
                        isColumnEmpty = false;

                        if (!cellStartFound)
                        {
                            cellStartX = x;
                            cellStartFound = true;
                        }
                        break;
                    }
                }

                if (isColumnEmpty && cellStartFound)
                {
                    SpritesStartEndPoints.Add(new int[] { cellStartX, x - 1 });
                    cellStartFound = false;
                }
            }

            //get last cell if InputImage ends without an empty column
            if (cellStartFound)
            {
                SpritesStartEndPoints.Add(new int[] { cellStartX, InputImage.Width - 1 });
            }
        }

        public void CreateGrid()
        {
            // Input Grid Values
            int columnCount = (int)numColumns.Value;
            int cellSize = (int)numCellSize.Value;

            // Output Grid Values
            int gridWidth = columnCount * cellSize;
            int gridHeight = (int)Math.Ceiling(SpritesStartEndPoints.Count / (decimal)columnCount) * cellSize;
            OutputImage = new Bitmap(gridWidth, gridHeight);

            int offsetY = Math.Max(0, cellSize - InputImage.Height); // Needed if grid size is smaller than InputImage height, or else sample position on y axis would be negative
            int sampleSizeY = Math.Min(cellSize, InputImage.Height); // sample the least amount of pixels on the Y axis when using a smaller grid size

            for (int cellIndex = 0; cellIndex < SpritesStartEndPoints.Count; cellIndex++)
            {               
                int startX = SpritesStartEndPoints[cellIndex][0];
                int endX = SpritesStartEndPoints[cellIndex][1];

                int sampleSizeX = Math.Min(endX - startX, cellSize); // sample the least amount of pixels on the X axis when using a smaller grid size

                for (int x = 0; x < sampleSizeX; x++)
                {
                    for (int y = 0; y < sampleSizeY; y++)
                    {
                        Color sampledPixel = InputImage.GetPixel(x + startX, y);

                        int drawX = x + ((cellIndex % columnCount) * cellSize);
                        int drawY = y + ((cellIndex / columnCount) * cellSize) + offsetY;
                        OutputImage.SetPixel(drawX, drawY, sampledPixel);
                    }
                }
            }

            picGridOutput.Image = OutputImage;
        }

        


        // --- FORM CONTROLS EVENTS ---
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            SelectImage();
        }

        private void btnCreateGrid_Click(object sender, EventArgs e)
        {
            if (CanCreateGridCheck())
            {
                CreateGrid();
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveImage();
        }
    }
}
