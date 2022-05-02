using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Geex.Common.Abstraction.MultiTenant;
using Geex.Common.Abstraction.Storage;
using Geex.Common.Settings.Abstraction;
using Geex.Common.Settings.Api.Aggregates.Settings;

namespace Geex.Common.Settings.Core;

[DebuggerDisplay("{Name}")]
public class Setting : Entity, ISetting
{
    public Setting(SettingDefinition name, string value, SettingScopeEnumeration scope, string? scopedKey = default)
    {
        Name = name;
        Value = value;
        Scope = scope;
        ScopedKey = scopedKey;
    }

    public SettingDefinition Name { get; private set; }
    public SettingScopeEnumeration Scope { get; private set; }
    public string? ScopedKey { get; private set; }
    public string? Value { get; private set; }

    public void SetValue(string? value)
    {
        Value = value;
    }
    public override async Task<ValidationResult> Validate(IServiceProvider sp, CancellationToken cancellation = default)
    {
        return ValidationResult.Success;
    }
}