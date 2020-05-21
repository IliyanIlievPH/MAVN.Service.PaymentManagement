﻿using System;
using JetBrains.Annotations;

namespace MAVN.Service.PaymentManagement.Client.Models.Requests
{
    /// <summary>
    /// Payment integrations supported currencies request model
    /// </summary>
    [PublicAPI]
    public class PaymentIntegrationsSupportedCurrenciesRequest
    {
        /// <summary>Partner id</summary>
        /// <remarks>Can be null.</remarks>
        public Guid? PartnerId { get; set; }
    }
}
