﻿using Attest.Fake.Builders;
using Attest.Testing.SpecFlow;
using LogoFX.Client.Testing.Contracts;

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
