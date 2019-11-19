using System;

using MementoLibrary.Implementation;

namespace MementoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var version = new VersioningSettings("1.2.9");
            var versionCareTaker = new VersioningCaretaker();
            Console.WriteLine($"... Version saving state {version.Version}");
            versionCareTaker.VersionMemento = version.SaveMemento();
            version.IncrementVersion();
            Console.WriteLine($"... Version incrementing state {version.Version}");
            version.RestoreMemento(versionCareTaker.VersionMemento);
            Console.WriteLine($"... Version restoring state {version.Version}");

            var currencySettings = new CurrencySettings(version);
            Console.WriteLine($"... Currency saving state {currencySettings.GetSettingsData()}");
            var currencyCareTakes = new CurrencyCaretaker();
            currencyCareTakes.CurrencyMemento = currencySettings.SaveMemento();

            currencySettings.SetNewCurrencies("EUR", "USD", "AUD");
            Console.WriteLine($"... Currency updating settings {currencySettings.GetSettingsData()}");

            currencySettings.Restore(currencyCareTakes.CurrencyMemento);
            Console.WriteLine($"... Currency settings restored: {currencySettings.GetSettingsData()}");

            Console.ReadLine();

        }
    }
}
