using AplikacjaKino.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace AplikacjaKino
{
    public partial class WyborMiejsc : Form
    {
        public Miejsca miejsca;
        private int liczbaBiletow;

        private int cellSize = 40;
        private int spacing = 5;

        private Button buttonConfirm = new Button();
        private Label labelEkran = new Label();

        private Dictionary<Point, bool> clickedCells = new Dictionary<Point, bool>();
        public List<string> selectedMiejsca = new List<string>();
        

        public WyborMiejsc()
        {
            InitializeComponent();
        }

        public WyborMiejsc(Miejsca miejsca, int liczbaBiletow)
        {
            this.miejsca = miejsca;
            this.liczbaBiletow = liczbaBiletow;

            Width = miejsca.kolumny * (cellSize + spacing) + spacing + 40;
            Height = miejsca.rzedy * (cellSize + spacing) + spacing + 100;

            Paint += new PaintEventHandler(DrawGrid);
            MouseClick += new MouseEventHandler(OnGridClick);

            labelEkran.Text = "Ekran";
            labelEkran.Font = new Font("Arial", 12);
            labelEkran.AutoSize = true;
            labelEkran.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(labelEkran);

            buttonConfirm.Text = "Potwierdź";
            buttonConfirm.Width = 100;
            buttonConfirm.Height = 30;
            buttonConfirm.Click += new EventHandler(OnConfirmClick);
            Controls.Add(buttonConfirm);

            PositionScreenLabel();
            PositionConfirmButton();

            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PositionScreenLabel();
            PositionConfirmButton();
        }

        private void PositionScreenLabel()
        {
            int totalGridWidth = miejsca.kolumny * (cellSize + spacing) - spacing;
            int startX = (ClientSize.Width - totalGridWidth) / 2;

            labelEkran.Left = startX + (totalGridWidth - labelEkran.Width) / 2;
            labelEkran.Top = 10;
        }

        private void PositionConfirmButton()
        {
            int totalGridHeight = miejsca.rzedy * (cellSize + spacing) - spacing;
            int startY = (ClientSize.Height - totalGridHeight) / 2;

            buttonConfirm.Left = (ClientSize.Width - buttonConfirm.Width) / 2;
            buttonConfirm.Top = startY + totalGridHeight + 20;
        }

        private void DrawGrid(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int totalGridWidth = miejsca.kolumny * (cellSize + spacing) - spacing;
            int totalGridHeight = miejsca.rzedy * (cellSize + spacing) - spacing;
            int startX = (ClientSize.Width - totalGridWidth) / 2;
            int startY = (ClientSize.Height - totalGridHeight) / 2;

            PositionConfirmButton();

            for (int row = 0; row < miejsca.rzedy; row++)
            {
                for (int col = 0; col < miejsca.kolumny; col++)
                {
                    int index = row * miejsca.kolumny + col;
                    Brush brush;

                    bool isOccupied = miejsca.miejsca[index];

                    if (clickedCells.ContainsKey(new Point(col, row)))
                    {
                        brush = Brushes.Blue;
                    }
                    else
                    {
                        if (isOccupied)
                        {
                            brush = Brushes.Red;
                        }
                        else
                        {
                            brush = Brushes.Green;
                        }
                    }

                    int x = startX + col * (cellSize + spacing);
                    int y = startY + row * (cellSize + spacing);

                    g.FillRectangle(brush, x, y, cellSize, cellSize);
                    g.DrawRectangle(Pens.Black, x, y, cellSize, cellSize);
                }
            }
        }

        private void OnGridClick(object sender, MouseEventArgs e)
        {
            int totalGridWidth = miejsca.kolumny * (cellSize + spacing) - spacing;
            int totalGridHeight = miejsca.rzedy * (cellSize + spacing) - spacing;
            int startX = (this.ClientSize.Width - totalGridWidth) / 2;
            int startY = (this.ClientSize.Height - totalGridHeight) / 2;

            int col = (e.X - startX) / (cellSize + spacing);
            int row = (e.Y - startY) / (cellSize + spacing);

            if (col >= 0 && col < miejsca.kolumny && row >= 0 && row < miejsca.rzedy)
            {
                int index = row * miejsca.kolumny + col;

                if (miejsca.miejsca[index] == true)
                {
                    MessageBox.Show("Miejsce zajęte!");
                    return;
                }

                Point clickedCell = new Point(col, row);

                if (clickedCells.ContainsKey(clickedCell))
                {
                    clickedCells.Remove(clickedCell);
                    selectedMiejsca.Remove(miejsca.getMiejsce(row + 1, col + 1));
                }
                else
                {
                    if (clickedCells.Count < liczbaBiletow)
                    {
                        clickedCells[clickedCell] = true;
                        selectedMiejsca.Add(miejsca.getMiejsce(row + 1, col + 1));
                    }
                    else
                    {
                        MessageBox.Show("Wybrano już wszystkie miejsca!");
                        return;
                    }
                }

                Invalidate();
            }
        }


        private void OnConfirmClick(object sender, EventArgs e)
        {
            if (selectedMiejsca.Count < liczbaBiletow)
            {
                MessageBox.Show("Nie wybrano jeszcze wszystkich miejsc!");
            }
            else
            {
                foreach (var seat in selectedMiejsca)
                {
                    char rowChar = seat[0];
                    int row = rowChar - 'A';
                    int column = int.Parse(seat.Substring(1));
                    
                    if (row >= 0 && row < miejsca.rzedy && column >= 1 && column <= miejsca.kolumny)
                    {
                        int index = row * miejsca.kolumny + (column - 1);
                        miejsca.miejsca[index] = true;
                    }
                }

                DialogResult = DialogResult.OK;
            }
        }
    }
}
