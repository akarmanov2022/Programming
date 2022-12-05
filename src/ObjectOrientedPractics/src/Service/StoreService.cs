using System;
using System.IO;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service;

/// <summary>
/// Сервис для работы с магазином.
/// </summary>
public static class StoreService
{
    /// <summary>
    /// Загрузить магазин из файла.
    /// </summary>
    /// <returns>Магазин.</returns>
    public static Store LoadStore()
    {
        return LoadFromAppData();
    }

    /// <summary>
    /// Сохранить магазин в файл.
    /// </summary>
    /// <param name="store">Магазин.</param>
    public static void SaveStore(Store store)
    {
        SaveToAppData(store);
    }
        
    private static Store LoadFromAppData()
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var directory = Path.Combine(appDataPath, "ObjectOrientedPractics");
            var filePath = Path.Combine(directory, "save.json");
            return Serializer<Store>.FromJson(filePath) ?? new Store();
        }
        catch (Exception exception)
        {
            throw new Exception("Error while loading store", exception);
        }
    }

    private static void SaveToAppData(Store store)
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var directory = Path.Combine(appDataPath, "ObjectOrientedPractics");
            var filePath = Path.Combine(directory, "save.json");
            Serializer<Store>.ToJson(store, filePath);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK);
        }
    }
}