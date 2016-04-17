using Attest.Testing.Core;
using LogoFX.Client.Testing.Shared;
using Solid.Bootstrapping;
using Solid.Practices.IoC;

namespace LogoFX.Client.Testing.Integration.SpecFlow
{
    /// <summary>
    /// Base class for client integration tests.
    /// </summary>
    /// <typeparam name="TContainerAdapter">The type of the ioc container adapter.</typeparam>
    /// <typeparam name="TRootObject">The type of the root object.</typeparam>
    /// <typeparam name="TBootstrapper">The type of the bootstrapper.</typeparam>
    public abstract class IntegrationTestsBase<TContainerAdapter, TRootObject, TBootstrapper> : 
        Attest.Testing.SpecFlow.IntegrationTestsBase<TContainerAdapter, TRootObject, TBootstrapper>
        where TContainerAdapter : IIocContainer
        where TRootObject : class
        where TBootstrapper : IInitializable, IHaveContainerAdapter<TContainerAdapter>, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTestsBase{TContainer, TRootObject, TBootstrapper}"/> class.
        /// </summary>
        /// <param name="resolutionStyle">The resolution style.</param>
        protected IntegrationTestsBase(InitializationParametersResolutionStyle resolutionStyle = InitializationParametersResolutionStyle.PerRequest)
            :base(resolutionStyle)
        {
        }

        /// <summary>
        /// Provides additional opportunity to modify the test setup logic.
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
    /// <typeparam name="TContainer">The type of the ioc container.</typeparam>
    /// <typeparam name="TContainerAdapter">The type of the ioc container adapter.</typeparam>
    /// <typeparam name="TRootObject">The type of the root object.</typeparam>
    /// <typeparam name="TBootstrapper">The type of the bootstrapper.</typeparam>
    /// <seealso cref="Attest.Testing.SpecFlow.IntegrationTestsBase{TContainer, TRootObject, TBootstrapper}" />
    public abstract class IntegrationTestsBase<TContainer, TContainerAdapter, TRootObject, TBootstrapper> :
        Attest.Testing.SpecFlow.IntegrationTestsBase<TContainer, TContainerAdapter, TRootObject, TBootstrapper>       
        where TContainerAdapter : class, IIocContainer, IIocContainerAdapter<TContainer>
        where TRootObject : class
        where TBootstrapper : IInitializable, IHaveContainer<TContainer>, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTestsBase{TContainer, TRootObject, TBootstrapper}"/> class.
        /// </summary>
        /// <param name="resolutionStyle">The resolution style.</param>
        protected IntegrationTestsBase(InitializationParametersResolutionStyle resolutionStyle = InitializationParametersResolutionStyle.PerRequest)
            : base(resolutionStyle)
        {
        }

        /// <summary>
        /// Provides additional opportunity to modify the test setup logic.
        /// </summary>
        protected override void SetupOverride()
        {
            base.SetupOverride();
            TestHelper.Setup();
        }
    }
}
