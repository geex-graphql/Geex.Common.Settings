using System.Diagnostics.CodeAnalysis;
using Geex.Common.Authorization;

namespace Geex.Common.Settings.Api
{
    public class SettingsPermission : AppPermission<SettingsPermission>
    {
        public SettingsPermission([NotNull] string value) : base(value)
        {
        }
        public static SettingsPermission Query { get; } = new SettingsPermission("query_setting");
        public static SettingsPermission Edit { get; } = new SettingsPermission("mutation_editSetting");
    }
}
