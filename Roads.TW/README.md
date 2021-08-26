# Roads.TW

Convert [全國路名資料](https://data.gov.tw/dataset/35321) CSV file into hierarchical JSON file. 

## Objective

The CSV file provided from data source are in flattened denormalized form.

This tool convert the CSV file into hierarchical JSON file.

### Before
```
city,site_id,road
縣市名稱,行政區域名稱,路名
金門縣,金門縣金城鎮,中環路
金門縣,金門縣金城鎮,中興市場
```

### After
```
{
  "Cities": [
    {
      "Name": "金門縣",
      "Districts": [
        {
          "Name": "金城鎮",
          "Roads": [
            "中環路",
            "中興市場"
          ]
        }
      ]
    }
  ]
}
```

## Usage
```C#
./Roads.TW <input_csv_file> <output_json_file>
```

## Example
```C#
./Roads.TW input.csv output.json
```
