using Attest.Testing.Core;
using LogoFX.Client.Testing.Shared;
using Solid.Practices.IoC;

namespace LogoFX.Client.Testing.Integration.SpecFlow
{
    /// <summary>
    /// Base class for client integration tests.
    /// </summary>
    /// <typeparam name="TContainer"></typeparam>
    /// <typeparam name="TRootViewModel"></typeparam>
    /// <typeparam name="TBootstrapper"></typeparam>
    public abstract class IntegrationTestsBase<TContainer, TRootViewModel, TBootstrapper> : 
        Attest.Testing.SpecFlow.IntegrationTestsBase<TContainer, TRootViewModel, TBootstrapper>
        where TContainer : IIocContainer, new() where TRootViewModel : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTestsBase{TContainer, TRootViewModel, TBootstrapper}"/> class.
        /// </summary>
        /// <param name="resolutionStyle">The resolution style.</param>
        protected IntegrationTestsBase(InitializationParametersResolutionStyle resolutionStyle = InitializationParametersResolutionStyle.PerRequest)
            :base(resolutionStyle)
        {
        }

        /// <summary>
        /// Provides additional opportunity to modify the test setup logic
        /// </summary>
        protected override void SetupOverride()
        {
            base.SetupOverride();
            TestHelper.Setup();
        }        
    }

    /// <summary>
    /// Base class for client integration tests.
    /// </summary>
    /// <typeparam name="TContainer">The type of the container.</typeparam>
    /// <typeparam name="TContainerAdapter">The type of the container adapter.</typeparam>
    /// <typeparam name="TRootViewModel">The type of the root view model.</typeparam>
    /// <typeparam name="TBootstrapper">The type of the bootstrapper.</typeparam>
    /// <seealso cref="Attest.Testing.SpecFlow.IntegrationTestsBase{TContainer, TRootViewModel, TBootstrapper}" />
    public abstract class IntegrationTestsBase<TContainer, TContainerAdapter, TRootViewModel, TBootstrapper> :
        Attest.Testing.SpecFlow.IntegrationTestsBase<TContainer, TContainerAdapter, TRootViewModel, TBootstrapper>
        where TContainer : new()
        where TContainerAdapter : class, IIocContainer, IIocContainerAdapter<TContainer>, new()
        where TRootViewModel : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTestsBase{TContainer, TRootViewModel, TBootstrapper}"/> class.
        /// </summary>
        /// <param name="resolutionStyle">The resolution style.</param>
        protected IntegrationTestsBase(InitializationParametersResolutionStyle resolutionStyle = InitializationParametersResolutionStyle.PerRequest)
            : base(resolutionStyle)
        {
        }

        /// <summary>
        /// Provides additional opportunity to modify the test setup logic
        /// </summary>
        protected override void SetupOverride()
        {
            base.SetupOverride();
            TestHelper.Setup();
        }
    }
}
