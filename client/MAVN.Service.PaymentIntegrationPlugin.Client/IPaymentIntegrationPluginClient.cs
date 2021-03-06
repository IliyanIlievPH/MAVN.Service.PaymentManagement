﻿using JetBrains.Annotations;

namespace MAVN.Service.PaymentIntegrationPlugin.Client
{
    /// <summary>
    /// PaymentManagement client interface.
    /// </summary>
    [PublicAPI]
    public interface IPaymentIntegrationPluginClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - IPaymentManagementApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        IPaymentIntegrationPluginApi Api { get; }
    }
}
