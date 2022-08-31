namespace CloudBandwagonDemo.Interfaces
{
    /// <summary>
    /// Device Info and manager.
    /// </summary>
    public interface IDeviceManager
    {
        /// <summary>
        /// OS.
        /// </summary>
        string OperatingSystem { get; }

        /// <summary>
        /// CPU Arch.
        /// </summary>
        string CpuArchitecture { get; }

        /// <summary>
        /// CPU Proc.
        /// </summary>
        string CpuProcessor { get; }

        /// <summary>
        /// Device Name.
        /// </summary>
        string DeviceName { get; }

        /// <summary>
        /// Device Model.
        /// </summary>
        string DeviceModel { get; }

        /// <summary>
        /// Current Language System.
        /// </summary>
        string Language { get; }

        /// <summary>
        /// RAM.
        /// </summary>
        int InstalledRam { get; }

        /// <summary>
        /// Current Using RAM Size.
        /// </summary>
        /// <returns></returns>
        int GetUsingRam();

        /// <summary>
        /// Get Current Archiving RAM Size.
        /// </summary>
        /// <returns>Archiving RAM Size</returns>
        int GetArchivingRam();

        /// <summary>
        /// Get Current Battery.
        /// </summary>
        /// <returns>Current Battery</returns>
        int GetCurrentBattery();

        /// <summary>
        /// Get Capacity Battery.
        /// </summary>
        /// <returns>Capacity Battery</returns>
        int GetCapacityBattery();

        /// <summary>
        /// Is Charging.
        /// </summary>
        /// <returns>If true is charging.</returns>
        bool IsCharging();
    }
}