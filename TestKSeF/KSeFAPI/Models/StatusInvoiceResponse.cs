// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KSeFAPI.Models
{
    /// <summary> The StatusInvoiceResponse. </summary>
    public partial class StatusInvoiceResponse
    {
        /// <summary> Initializes a new instance of StatusInvoiceResponse. </summary>
        /// <param name="timestamp"></param>
        /// <param name="referenceNumber"></param>
        /// <param name="processingCode"></param>
        /// <param name="processingDescription"></param>
        /// <param name="elementReferenceNumber"></param>
        /// <param name="invoiceStatus"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceNumber"/>, <paramref name="processingDescription"/>, <paramref name="elementReferenceNumber"/> or <paramref name="invoiceStatus"/> is null. </exception>
        internal StatusInvoiceResponse(DateTimeOffset timestamp, string referenceNumber, int processingCode, string processingDescription, string elementReferenceNumber, InvoiceStatusType invoiceStatus)
        {
            if (referenceNumber == null)
            {
                throw new ArgumentNullException(nameof(referenceNumber));
            }
            if (processingDescription == null)
            {
                throw new ArgumentNullException(nameof(processingDescription));
            }
            if (elementReferenceNumber == null)
            {
                throw new ArgumentNullException(nameof(elementReferenceNumber));
            }
            if (invoiceStatus == null)
            {
                throw new ArgumentNullException(nameof(invoiceStatus));
            }

            Timestamp = timestamp;
            ReferenceNumber = referenceNumber;
            ProcessingCode = processingCode;
            ProcessingDescription = processingDescription;
            ElementReferenceNumber = elementReferenceNumber;
            InvoiceStatus = invoiceStatus;
        }

        /// <summary> Gets the timestamp. </summary>
        public DateTimeOffset Timestamp { get; }
        /// <summary> Gets the reference number. </summary>
        public string ReferenceNumber { get; }
        /// <summary> Gets the processing code. </summary>
        public int ProcessingCode { get; }
        /// <summary> Gets the processing description. </summary>
        public string ProcessingDescription { get; }
        /// <summary> Gets the element reference number. </summary>
        public string ElementReferenceNumber { get; }
        /// <summary> Gets the invoice status. </summary>
        public InvoiceStatusType InvoiceStatus { get; }
    }
}
