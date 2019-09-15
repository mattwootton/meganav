﻿using System;

namespace Our.Umbraco.Meganav.Models
{
    public interface IMeganavItemType
    {
        Guid Id { get; }

        string Name { get; }

        string Alias { get; }

        string Icon { get; }

        string View { get; }

        Guid? SettingsType { get; }
    }
}