using DanCanKanBan.Services.Configuration;

namespace DanCanKanBan.Services.Interfaces
{
    public interface IConfigurationSettings
    {
        ApplicationSettings Settings { get; set; }
        bool HasSettings();
        void Load();
    }
}
