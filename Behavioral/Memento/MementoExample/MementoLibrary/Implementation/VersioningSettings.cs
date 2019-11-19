// ------------------------------------------------------------------------------
//     <copyright file="VersioningSettings.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

namespace MementoLibrary.Implementation
{
    /// <summary>
    /// Originator
    /// </summary>
    public class VersioningSettings
    {
        private int _buildNumber;

        private int _majorVersion;

        private int _minorVersion;

        public string Version => $"{_majorVersion}.{_minorVersion}.{_buildNumber}";

        public void IncrementVersion()
        {
            if (_buildNumber < 9)
            {
                _buildNumber++;
                return;
            }

            if (_minorVersion < 9)
            {
                _minorVersion++;
                _buildNumber = 0;
                return;
            }

            _majorVersion++;
            _minorVersion = 0;
            _buildNumber = 0;
            
        }

        public VersioningSettings(string version)
        {
            UpdateVersion(version);
        }

        public void UpdateVersion(string version)
        {
            string[] array = version.Split('.');
            _majorVersion = int.Parse(array[0]);
            _minorVersion = int.Parse(array[1]);
            _buildNumber = int.Parse(array[2]);
        }

        public string SaveMemento()
        {
            return Version;
        }

        public void RestoreMemento(string memento)
        {
            UpdateVersion(memento);
        }
    }
}