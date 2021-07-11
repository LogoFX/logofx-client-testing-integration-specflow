using Attest.Fake.Registration;
using Attest.Testing.FakeData;
using Solid.Patterns.Builder;
using Solid.Practices.IoC;

namespace LogoFX.Client.Testing.Integration.SpecFlow
{
    /// <summary>
    /// Represents builder registration service for SpecFlow-based integration tests.
    /// </summary>
    /// <seealso cref="IBuilderRegistrationService" />
    public class BuilderRegistrationService : IBuilderRegistrationService
    {
        private readonly IDependencyRegistrator _dependencyRegistrator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderRegistrationService"/> class.
        /// </summary>
        /// <param name="dependencyRegistrator"></param>
        public BuilderRegistrationService(IDependencyRegistrator dependencyRegistrator)
        {
            _dependencyRegistrator = dependencyRegistrator;
        }

        void IBuilderRegistrationService.RegisterBuilder<TService>(IBuilder<TService> builder)
        {
            RegistrationHelper.RegisterBuilderProduct(_dependencyRegistrator, builder);
        }
    }   
}
