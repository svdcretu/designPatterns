namespace MementoLibrary.Implementation
{
    /// <summary>
    /// Originator Class
    /// </summary>
    public class CurrencySettings
    {
        private VersioningSettings _version;

        public string Description { get; private set; }

        public string PrimaryCurrency { get; private set; }

        public string SecondaryCurrency { get; private set; }

        public string AlternativeCurrency { get; private set; }

        public string Version => _version.Version;

        public CurrencySettings(VersioningSettings version)
        {
            _version = version;
            Description = "Currency Settings";
            PrimaryCurrency = "USD";
            SecondaryCurrency = "EUR";
            AlternativeCurrency = "RON";
        }

        public string GetSettingsData()
        {
            return $"{Description} - version {Version}: PrimaryCurrency = {PrimaryCurrency}; AlternativeCurrency = {AlternativeCurrency}; SecondaryCurrency = {SecondaryCurrency};";
        }

        public void SetNewCurrencies(string primaryCurrency, string secondaryCurrency, string alternativeCurrency)
        {
            PrimaryCurrency = primaryCurrency;
            AlternativeCurrency = alternativeCurrency;
            SecondaryCurrency = secondaryCurrency;

            _version.IncrementVersion();
        }

        public void Restore(CurrencyMemento memento)
        {
            Description = memento.Description;
            PrimaryCurrency = memento.PrimaryCurrency;
            AlternativeCurrency = memento.AlternativeCurrency;
            SecondaryCurrency = memento.SecondaryCurrency;
            _version.RestoreMemento(memento.VersioningSettings);
        }

        public CurrencyMemento SaveMemento()
        {
            return new CurrencyMemento(_version.SaveMemento(), Description, PrimaryCurrency, SecondaryCurrency, AlternativeCurrency);
        }

    }

    /// <summary>
    /// Memento class
    /// </summary>
    public class CurrencyMemento
    {
        public string Description { get; }

        public string VersioningSettings { get; }

        public string PrimaryCurrency { get; }

        public string SecondaryCurrency { get;}

        public string AlternativeCurrency { get;}

        public CurrencyMemento(string version, string description, string primaryCurrency, string secondaryCurrency, string alternativeCurrency)
        {
            VersioningSettings = version;
            Description = description;
            PrimaryCurrency = primaryCurrency;
            SecondaryCurrency = secondaryCurrency;
            AlternativeCurrency = alternativeCurrency;
        }
    }
}