using DanCanKanBan.Services.Session;

namespace DanCanKanBan.Services.Interfaces
{
    public interface IUserSession
    {
        UserSettings Settings { get; set; }
        bool HasSettings();
        void Load();
    }
}
