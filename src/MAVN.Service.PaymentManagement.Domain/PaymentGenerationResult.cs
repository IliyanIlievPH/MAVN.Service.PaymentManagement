﻿using System;

namespace MAVN.Service.PaymentManagement.Domain
{
    public class PaymentGenerationResult
    {
        public string PaymentPageUrl { get; set; }

        public Guid PaymentRequestId { get; set; }
    }
}
