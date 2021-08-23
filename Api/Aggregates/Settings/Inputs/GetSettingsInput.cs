using System.Linq;

using Geex.Common.Abstraction.Gql.Inputs;
using Geex.Common.Settings.Abstraction;

using MediatR;

namespace Geex.Common.Settings.Api.Aggregates.Settings.Inputs
{
    public class GetSettingsInput : QueryInput<ISetting>
    {
        public SettingScopeEnumeration Scope { get; set; }
    }
}