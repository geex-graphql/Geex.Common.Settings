using Geex.Common.Settings.Abstraction;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geex.Common.Abstraction.MultiTenant;

namespace Geex.Common.Settings.Api.Aggregates.Settings
{
    public interface ISetting
    {
        SettingScopeEnumeration Scope { get; }
        string ScopedKey { get; }
        string Value { get; }
        SettingDefinition Name { get; }
        string Id { get; }
    }
}
