using System.Text.Json;

namespace oop_final
{
    internal static class Program
    {
        [STAThread]
        public static void GhiFile<T>(string filePath, T data)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);

                MessageBox.Show("Data saved successfully to JSON.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DocFile(string filePath)
        {
            try
            {
                // Read JSON data from file
                string jsonString = File.ReadAllText(filePath);

                // Deserialize JSON to an anonymous object type
                var data = JsonSerializer.Deserialize<Dictionary<string, List<Student>>>(jsonString);

                MessageBox.Show("Data loaded successfully from JSON.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}