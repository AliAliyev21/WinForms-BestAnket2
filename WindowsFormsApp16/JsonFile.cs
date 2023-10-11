using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public class JsonFile
    {
        //public static void SaveUserToJson(User user, string jsonFileName)
        //{
        //    if (user == null)
        //    {
        //        MessageBox.Show("Please select a user from the list to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(jsonFileName))
        //    {
        //        MessageBox.Show("Please enter a valid JSON file name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName + ".json");
        //        File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(user));
        //        MessageBox.Show("User data saved to JSON file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while saving JSON file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
