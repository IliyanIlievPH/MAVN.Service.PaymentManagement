﻿using System;
using JetBrains.Annotations;

namespace MAVN.Service.PaymentManagement.Client.Models.Responses
{
    /// <summary>
    /// Payment generation response model.
    /// </summary>
    [PublicAPI]
    public class PaymentGenerationResponse
    {
        /// <summary>Error code</summary>
        public PaymentGenerationErrorCode ErrorCode { get; set; }

        /// <summary>Payment page url</summary>
        public string PaymentPageUrl { get; set; }

        /// <summary>Payment request id</summary>
        public Guid PaymentRequestId { get; set; }
    }
}
