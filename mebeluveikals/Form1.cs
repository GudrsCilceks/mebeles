using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;
using System.IO;


namespace mebeluveikals
{
    public partial class Form1 : Form
    {
        private FurnitureManager furnitureManager;

        public Form1()
        {
            InitializeComponent();

            furnitureManager = new FurnitureManager("Data Source=furniture.db");

            var furniture = furnitureManager.ReadFurniture();
            var furnitureNames = new List<string>();

            foreach (var f in furniture)
            {
                furnitureNames.Add(f.Name);
            }

            selectProductComboBox.DataSource = furnitureNames;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var furniture = furnitureManager.ReadFurnitureByName(selectProductComboBox.Text);

            nameTextBox.Text = furniture.Name;
            descTextBox.Text = furniture.Description;
            priceTextBox.Text = furniture.Price.ToString();
            hTextBox.Text = furniture.Height.ToString();
            wTextBox.Text = furniture.Width.ToString();
            lTextBox.Text = furniture.Length.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts nosaukums.");
                }
                else if (string.IsNullOrEmpty(descTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts apraksts.");
                }
                else if (string.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Nav norādīta cena.");
                }
                else if (string.IsNullOrEmpty(hTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts augstums.");
                }
                else if (string.IsNullOrEmpty(wTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts platums.");
                }
                else if (string.IsNullOrEmpty(lTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts garums.");
                }


                furnitureManager.AddFurniture(nameTextBox.Text, descTextBox.Text,
                    Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(hTextBox.Text),
                    Convert.ToInt32(wTextBox.Text), Convert.ToInt32(lTextBox.Text));

                List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                furnitureList.Add(nameTextBox.Text);

                selectProductComboBox.DataSource = null;
                selectProductComboBox.DataSource = furnitureList;

                MessageBox.Show("Ieraksts tika pievienots datubāzei");
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Notikusi SQL kļūda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            furnitureManager.DeleteFurnitureByName(selectProductComboBox.Text);

            List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
            furnitureList.Remove(selectProductComboBox.Text);

            selectProductComboBox.DataSource = null;
            selectProductComboBox.DataSource = furnitureList;

            MessageBox.Show("Mēbele tika izdzēsta no datubāzes.");
        }

        private void exportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                var furnitureList = furnitureManager.ReadFurniture();

                var filePath = "furniture_export.csv";

                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Name, Description, Price, Height, Width, Length");

                    foreach (var furniture in furnitureList)
                    {
                        writer.WriteLine($"{furniture.Name},{furniture.Description},{furniture.Price},{furniture.Height},{furniture.Width},{furniture.Length}");
                    }
                }

                MessageBox.Show("Dati tika eksportēti CSV faila.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kļūda, kautkas noticis ar CSV failu: {ex.Message}");
            }
        }

        private void importCSV_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                openFileDialog.Title = "Izvēlieties CSV failu";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    var lines = File.ReadAllLines(filePath);

                    if (lines.Length > 1)
                    {
                        foreach (var line in lines.Skip(1))
                        {
                            var values = line.Split(',');

                            if (values.Length == 6)
                            {
                                string name = values[0];
                                string description = values[1];
                                double price = Convert.ToDouble(values[2]);
                                int height = Convert.ToInt32(values[3]);
                                int width = Convert.ToInt32(values[4]);
                                int length = Convert.ToInt32(values[5]);

                                var existingFurniture = furnitureManager.ReadFurnitureByName(name);

                                if (existingFurniture != null)
                                {
                                    furnitureManager.UpdateFurniture(name, description, price, height, width, length);
                                }
                                else
                                {
                                    furnitureManager.AddFurniture(name, description, price, height, width, length);
                                }
                            }
                        }

                        MessageBox.Show("CSV faili tika veiksmīgi importēti.");
                    }
                    else
                    {
                        MessageBox.Show("CSV fails ir tukšs vai tam trūkst datu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notikusi kļūda importējot CSV failu: {ex.Message}");
            }
        }
    }
}
