﻿using System;

namespace VervePlace
{
    public interface IAuthorizationService
    {
        void Authorize(string login, string password, Action<string> onSuccessCallback = null, Action<string> onErrorCallback = null);
        void Register(string login, string password, string confirmPassword, Action<string> onSuccessCallback = null, Action<string> onErrorCallback = null);
    }
}