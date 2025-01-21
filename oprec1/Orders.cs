using System.Text.Json;
using System.Text.Json.Serialization;

namespace oprec1
{
    public class Orders
    {
        [JsonPropertyName("orders")]
        public List<Order> Data { get; set; } = new List<Order>();
        private string Path = "../../../order_data.json";

        public Orders()
        {
            try
            {
                readJSON();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                writeJSON();
            }
        }

        public void readJSON()
        {
            var data = JsonSerializer.Deserialize<Orders>(Path);
            Console.WriteLine(data);
            Data = data.Data;
        }

        public void writeJSON() 
        {
            JsonSerializerOptions option = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            JsonSerializer.Serialize(Data, option);
            File.WriteAllText(Path, Data.ToString());
        }
    }
}
