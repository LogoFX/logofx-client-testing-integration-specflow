using Attest.Testing.Core;
using LogoFX.Client.Testing.Shared;
using Solid.Bootstrapping;
using Solid.Core;
using TechTalk.SpecFlow;

namespace LogoFX.Client.Testing.Integration.SpecFlow
{
    /// <summary>
    /// Base class for client integration tests that use SpecFlow as test engine.
    /// </summary>
    /// <typeparam name="TRootObject">The type of the root object.</typeparam>
    /// <typeparam name="TBootstrapper">The type of the bootstrapper.</typeparam>
    public abstract class IntegrationTestsBase<TRootObject, TBootstrapper> :
        Attest.Testing.Integration.SpecFlow.IntegrationTestsBase<TRootObject, TBootstrapper>
        where TRootObject : class
        where TBootstrapper : IInitializable, IHaveRegistrator, IHaveResolver, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTestsBase{TRootObject,TBootstrapper}"/> class.
        /// </summary>
        /// <param name="scenarioContext">The scenario context.</param>
        /// <param name="resolutionStyle">The resolution style.</param>
        protected IntegrationTestsBase(
            ScenarioContext scenarioContext,
            InitializationParametersResolutionStyle resolutionStyle = InitializationParametersResolutionStyle.PerRequest)
            : base(scenarioContext, resolutionStyle)
        {
        }

        /// <inheritdoc />
        protected override void SetupOverride()
        {
            base.SetupOverride();
            TestHelper.Setup();
        }

        /// <summary>
        /// Base class for client integration tests that use SpecFlow as test engine and have 
        /// the explicit root object creation flow.
        /// </summary>
        public class WithExplicitRootObjectCreation : 
            Attest.Testing.Integration.SpecFlow.IntegrationTestsBase<TRootObject,
            TBootstrapper>.WithExplicitRootObjectCreation
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="IntegrationTestsBase{TRootObject,TBootstrapper}.WithExplicitRootObjectCreation"/> class.
            /// </summary>
            /// <param name="scenarioContext">The scenario context.</param>
            public WithExplicitRootObjectCreation(ScenarioContext scenarioContext):
                base(scenarioContext)
            {}

            /// <inheritdoc />            
            protected override void SetupOverride()
            {
                base.SetupOverride();
                TestHelper.Setup();
            }
        }
    }
}