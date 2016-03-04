using System;
using DanCanKanBan.Services.Interfaces;

namespace DanCanKanBan.Services.Session
{
    public class WebUserSession : IUserSession
    {
        public UserSettings Settings
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HasSettings()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }
    }
}
