using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Roads.TW {
    public static class Converter {
        public static async Task FromCsvToJson(string inputFilePath, string outputFilePath) {
            if (!inputFilePath.EndsWith(".csv")) {
                throw new ArgumentException("Input file extension must be .csv");
            }
            if (!outputFilePath.EndsWith(".json")) {
                throw new ArgumentException("Output file extension must be .json");
            }

            var address = await ConvertFromCsv(inputFilePath);
            var jsonStr = JsonConvert.SerializeObject(address);
            await File.WriteAllTextAsync(outputFilePath, jsonStr);
        }
        private static async Task<AddressHierarchy> ConvertFromCsv(string path) {
            var roads = await File.ReadAllLinesAsync(path);

            roads = roads[2..];

            var address = new AddressHierarchy();
            foreach (var r in roads) {
                var tokens = r.Split(",");
                var keyCity = tokens[0];
                var keyDistrict = tokens[1];
                var road = tokens[2];

                address.AddCity(keyCity).AddDistrict(keyDistrict).AddRoad(road);
            }
            return address;
        }
    }
}
