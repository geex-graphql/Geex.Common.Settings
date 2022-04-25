using System;
using System.Diagnostics.CodeAnalysis;
using Geex.Common.Authorization;

namespace Geex.Common.Settings.Api
{
    public class SettingsPermission : AppPermission<SettingsPermission>
    {
        public SettingsPermission([NotNull] string value) : base($"{typeof(SettingsPermission).DomainName()}_{value}")
        {
        }
        public static SettingsPermission Query { get; } = new SettingsPermission("query_settings");
        public static SettingsPermission Edit { get; } = new SettingsPermission("mutation_editSetting");
    }
}
