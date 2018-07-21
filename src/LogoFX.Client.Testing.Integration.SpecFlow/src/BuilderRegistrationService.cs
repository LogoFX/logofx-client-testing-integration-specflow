using Attest.Testing.Contracts;
using Attest.Testing.SpecFlow;
using Solid.Patterns.Builder;

namespace LogoFX.Client.Testing.Integration.SpecFlow
{
    /// <summary>
    /// Represents builder registration service for SpecFlow-based integration tests.
    /// </summary>
    /// <seealso cref="StepsBase" />
    /// <seealso cref="IBuilderRegistrationService" />
    public class BuilderRegistrationService : StepsBase, IBuilderRegistrationService
    {
        void IBuilderRegistrationService.RegisterBuilder<TService>(IBuilder<TService> builder)
        {
            RegisterBuilder(builder);
        }
    }   
}
