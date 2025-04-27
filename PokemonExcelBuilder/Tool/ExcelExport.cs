using System.Reflection;
using OfficeOpenXml;

namespace PokemonExcelBuilder;

public static class ExcelExport
{
    class TypeExcel
    {
        [DescProperty("种类")] public string Kind { get; set; }
        [DescProperty("对象类型")] public string ObjectType { get; set; }
        [DescProperty("标识名")] public string IdName { get; set; }
        [DescProperty("字段名")] public string PropertyName { get; set; }
        [DescProperty("字段类型")] public string PropertyType { get; set; }
        [DescProperty("数组切割")] public string ArraySplit { get; set; }
        [DescProperty("值")] public int Value { get; set; }
        [DescProperty("索引")] public bool IsIndex { get; set; }
        [DescProperty("标记")] public string Tag { get; set; }
    }

    public static void ExportToExcel<T>(List<T> data, string filePath, string excelType)
    {
        var typeTable = new List<TypeExcel>();
        var properties = typeof(T).GetProperties()
            .Where(p => p.GetCustomAttribute<DescPropertyAttribute>() != null)
            .ToArray();
        foreach (var property in properties)
        {
            var attr = property.GetCustomAttribute<DescPropertyAttribute>()!;

            typeTable.Add(new TypeExcel
            {
                Kind = "表头",
                ObjectType = excelType,
                IdName = attr.Name,
                PropertyName = property.Name,
                PropertyType = attr.Type ?? GetPropertyType(property),
                ArraySplit = attr.IsList
                    ? ","
                    : string.Empty,
                IsIndex = attr.IsIndex
            });
        }

        InternalExportToExcel(data, filePath);

        var typeTablePath = Path.Combine(Path.GetDirectoryName(filePath)!, Path.GetFileNameWithoutExtension(filePath) + "_Type.xlsx");
        InternalExportToExcel(typeTable, typeTablePath);

        static string GetPropertyType(PropertyInfo property)
        {
            var t = property.PropertyType;
            if (t == typeof(int))
                return "int32";
            if (t == typeof(string))
                return "string";
            if (t == typeof(float))
                return "float";
            if (t == typeof(bool))
                return "Boolean";
            throw new NotImplementedException();
        }
    }

    private static void InternalExportToExcel<T>(List<T> data, string filePath)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // 允许在非商业环境中使用
        if (data.Count == 0) return;

        using var package = new ExcelPackage();

        var sheet = package.Workbook.Worksheets.Add(Path.GetFileName(filePath));

        var type = typeof(T);
        var properties = type.GetProperties()
            .Where(p => p.GetCustomAttribute<DescPropertyAttribute>() != null)
            .ToArray();

        // 写入表头
        for (int i = 0; i < properties.Length; i++)
        {
            var attr = properties[i].GetCustomAttribute<DescPropertyAttribute>()!;
            sheet.Cells[1, i + 1].Value = attr.Name;
        }

        // 写入数据
        for (int row = 0; row < data.Count; row++)
        {
            for (int col = 0; col < properties.Length; col++)
            {
                var attr = properties[col].GetCustomAttribute<DescPropertyAttribute>()!;

                var value = properties[col].GetValue(data[row]);

                if (value is bool boolValue)
                {
                    value = boolValue ? "是" : "";
                }
                else if (value is int intValue)
                {
                    if (intValue == 0 && attr.EmptyIfZero)
                    {
                        value = null;
                    }
                }

                sheet.Cells[row + 2, col + 1].Value = value;
            }
        }

        // 自动调整列宽
        sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

        // 保存文件
        FileInfo file = new FileInfo(filePath);
        package.SaveAs(file);
    }
}