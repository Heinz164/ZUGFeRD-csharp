/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
namespace s2industries.ZUGFeRD
{
    /// <summary>
    /// Reason codes for allowance based on UNTDID 5189
    /// https://unece.org/fileadmin/DAM/trade/untdid/d17a/tred/tred5189.htm
    /// </summary>
    public enum ReasonCodeAllowance_5189
    {
        /// <summary>
        /// Unknown/invalid value
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Fee for the processing of documentary credit, collection and payment which are charged to the customer. 
        /// </summary>
        HandlingCommission = 1,

        /// <summary>
        /// Fee for amendments in documentary credit and collection business (not extensions and increases of documentary credits). 
        /// </summary>
        AmendmentCommission = 2,

        /// <summary>
        /// Fee for the acceptance of draft in documentary credit and collection business which are drawn on us (also to be seen as a kind of 'guarantee commission'). 
        /// </summary>
        AcceptanceCommission = 3,

        /// <summary>
        /// Fee for obtaining an acceptance under collections on the basis of 'documents against acceptance'. 
        /// </summary>
        CommissionForObtainingAcceptance = 4,

        /// <summary>
        /// Fee for delivery of documents without corresponding payment. 
        /// </summary>
        CommissionOnDelivery = 5,

        /// <summary>
        /// Fee for advising documentary credits (charged also in case of confirmed credits). 
        /// </summary>
        AdvisingCommission = 6,

        /// <summary>
        /// Fee for confirmation of credit. 
        /// </summary>
        ConfirmationCommission = 7,

        /// <summary>
        /// Fee for the deferred payment period under documentary credits confirmed by bank. This fee are charges for the period from presentation of the document until due date of payment. 
        /// </summary>
        DeferredPaymentCommission = 8,

        /// <summary>
        /// Fee charged to the foreign bank for the processing of documentary credit. 
        /// </summary>
        CommissionForTakingUpDocuments = 9,

        /// <summary>
        /// Fee for opening revocable documentary credit. 
        /// </summary>
        OpeningCommission = 10,

        /// <summary>
        /// Fee charged to the customer for discrepancies in credit documents in the case of which the bank have to stipulate payment under reserve. 
        /// </summary>
        FeeForPaymentUnderReserve = 11,

        /// <summary>
        /// Fee charged to the foreign bank for discrepancies in credit documents. 
        /// </summary>
        DiscrepancyFee = 12,

        /// <summary>
        /// Fee for the domicilation of bills with the bank. 
        /// </summary>
        DomicilationCommission = 13,

        /// <summary>
        /// Commission for the release of goods sent to the bank. 
        /// </summary>
        CommissionForReleaseOfGoods = 14,

        /// <summary>
        /// Fee for settling collections on the basis of 'documents against payments'. 
        /// </summary>
        CollectionCommission = 15,

        /// <summary>
        /// Fee for the purchase of documents under sight credit for the first ten days. 
        /// </summary>
        NegotiationCommission = 16,

        /// <summary>
        /// Fee for cheques, bills and collections returned unpaid and/or recalled. 
        /// </summary>
        ReturnCommission = 17,

        /// <summary>
        /// Fee for the splitting of bills of lading. 
        /// </summary>
        BLSplittingCharges = 18,

        /// <summary>
        /// Fee for the handling on a fiduciary basis of imported goods that have been warehoused. 
        /// </summary>
        TrustCommission = 19,

        /// <summary>
        /// Fee for the transfer of transferable documentary credits. 
        /// </summary>
        TransferCommission = 20,

        /// <summary>
        /// Fee for opening irrevocable documentary credits. This fee is a kind of 'Guarantee commission' as compensation for the commitment into which the bank have entered on the customers behalf; similar to confirmation commission, acceptance commission.
        /// </summary>
        CommissionForOpeningIrrevocableDocumentaryCredits = 21,

        /// <summary>
        /// Fee for the pre-advice of a documentary credit. 
        /// </summary>
        PreAdviceCommission = 22,

        /// <summary>
        /// Fee for the supervising unconfirmed documentary credits with a deferred payment period. 
        /// </summary>
        SupervisoryCommission = 23,

        /// <summary>
        /// Fee for decoding telex messages. 
        /// </summary>
        ModelCharges = 24,

        /// <summary>
        /// Commission in addition to the confirmation commission for documentary credits from sensitive countries. 
        /// </summary>
        RiskCommission = 25,

        /// <summary>
        /// Commission for drawing up guaranties. 
        /// </summary>
        GuaranteeCommission = 26,

        /// <summary>
        /// Fee for reimbursement of, for example, documentary credits. 
        /// </summary>
        ReimbursementCommission = 27,

        /// <summary>
        /// Tax payable on bills in accordance with national bill of exchange legislation. 
        /// </summary>
        StampDuty = 28,

        /// <summary>
        /// Brokers commission arising, in trade with foreign currencies. 
        /// </summary>
        Brokerage = 29,

        /// <summary>
        /// Charges deducted/claimed by other banks involved in the transaction. 
        /// </summary>
        BankCharges = 30,

        /// <summary>
        /// Charges not included in the total charge amount i.e. the charges are for information only. 
        /// </summary>
        BankChargesInformation = 31,

        /// <summary>
        /// Fee for use of courier service. 
        /// </summary>
        CourierFee = 32,

        /// <summary>
        /// Fee for use of phone. 
        /// </summary>
        PhoneFee = 33,

        /// <summary>
        /// Fee for postage. 
        /// </summary>
        PostageFee = 34,

        /// <summary>
        /// Fee for use of S.W.I.F.T. 
        /// </summary>
        SWIFTFee = 35,

        /// <summary>
        /// Fee for telex. 
        /// </summary>
        TelexFee = 36,

        /// <summary>
        /// Penalty imposed when documents are delivered late. 
        /// </summary>
        PenaltyForLateDeliveryOfDocuments = 37,

        /// <summary>
        /// Penalty imposed when valuation of works is delivered late. 
        /// </summary>
        PenaltyForLateDeliveryOfValuationOfWorks = 38,

        /// <summary>
        /// Penalty imposed when the execution of works is behind schedule. 
        /// </summary>
        PenaltyForExecutionOfWorksBehindSchedule = 39,

        /// <summary>
        /// Penalty imposed for other reasons. 
        /// </summary>
        OtherPenalties = 40,

        /// <summary>
        /// Bonus for completing work ahead of schedule. 
        /// </summary>
        BonusForWorksAheadOfSchedule = 41,

        /// <summary>
        /// Bonus earned for other reasons. 
        /// </summary>
        OtherBonus = 42,

        /// <summary>
        /// Cost for project management. 
        /// </summary>
        ProjectManagementCost = 44,

        /// <summary>
        /// Proportional retention charge. 
        /// </summary>
        ProRataRetention = 45,

        /// <summary>
        /// Contractual retention charge. 
        /// </summary>
        ContractualRetention = 46,

        /// <summary>
        /// Retention charge not otherwise specified. 
        /// </summary>
        OtherRetentions = 47,

        /// <summary>
        /// Interest for late payment. 
        /// </summary>
        InterestOnArrears = 48,

        /// <summary>
        /// Cost of using money. 
        /// </summary>
        Interest = 49,

        /// <summary>
        /// Unit charge per credit cover established. 
        /// </summary>
        ChargePerCreditCover = 50,

        /// <summary>
        /// Unit charge per unused credit cover. 
        /// </summary>
        ChargePerUnusedCreditCover = 51,

        /// <summary>
        /// Minimum commission charge. 
        /// </summary>
        MinimumCommission = 52,

        /// <summary>
        /// Commission charged for factoring services. 
        /// </summary>
        FactoringCommission = 53,

        /// <summary>
        /// Identifies the charges from the chamber of commerce. 
        /// </summary>
        ChamberOfCommerceCharge = 54,

        /// <summary>
        /// Charges for transfer. 
        /// </summary>
        TransferCharges = 55,

        /// <summary>
        /// Charges for repatriation. 
        /// </summary>
        RepatriationCharges = 56,

        /// <summary>
        /// Not specifically defined charges. 
        /// </summary>
        MiscellaneousCharges = 57,

        /// <summary>
        /// Charges for foreign exchange. 
        /// </summary>
        ForeignExchangeCharges = 58,

        /// <summary>
        /// Charge for agreed debit interest 
        /// </summary>
        AgreedDebitInterestCharge = 59,

        /// <summary>
        /// A discount given by the manufacturer which should be passed on to the consumer. 
        /// </summary>
        ManufacturersConsumerDiscount = 60,

        /// <summary>
        /// Charge for fax advice. 
        /// </summary>
        FaxAdviceCharge = 61,

        /// <summary>
        /// Allowance granted because of the military status. 
        /// </summary>
        DueToMilitaryStatus = 62,

        /// <summary>
        /// Allowance granted to a victim of a work accident. 
        /// </summary>
        DueToWorkAccident = 63,

        /// <summary>
        /// An allowance or charge as specified in a special agreement. 
        /// </summary>
        SpecialAgreement = 64,

        /// <summary>
        /// A discount given for the purchase of a product with a production error. 
        /// </summary>
        ProductionErrorDiscount = 65,

        /// <summary>
        /// A discount given at the occasion of the opening of a new outlet. 
        /// </summary>
        NewOutletDiscount = 66,

        /// <summary>
        /// A discount given for the purchase of a sample of a product. 
        /// </summary>
        SampleDiscount = 67,

        /// <summary>
        /// A discount given for the purchase of an end-of-range product. 
        /// </summary>
        EndOfRangeDiscount = 68,

        /// <summary>
        /// A charge for the addition of a customer specific finish to a product. 
        /// </summary>
        ChargeForACustomerSpecificFinish = 69,

        /// <summary>
        /// A discount given for a specified Incoterm. 
        /// </summary>
        IncotermDiscount = 70,

        /// <summary>
        /// Allowance for reaching or exceeding an agreed sales threshold at the point of sales. 
        /// </summary>
        PointOfSalesThresholdAllowance = 71,

        /// <summary>
        /// Costs for technical modifications to a product. 
        /// </summary>
        TechnicalModificationCosts = 72,

        /// <summary>
        /// Costs of job-order production. 
        /// </summary>
        JobOrderProductionCosts = 73,

        /// <summary>
        /// Expenses for non-local activities. 
        /// </summary>
        OffPremisesCosts = 74,

        /// <summary>
        /// Costs of additional processing. 
        /// </summary>
        AdditionalProcessingCosts = 75,

        /// <summary>
        /// Costs of official attestation. 
        /// </summary>
        AttestingCharge = 76,

        /// <summary>
        /// Charge for increased delivery speed. 
        /// </summary>
        RushDeliverySurcharge = 77,

        /// <summary>
        /// Charge for costs incurred as result of special constructions. 
        /// </summary>
        SpecialConstructionCosts = 78,

        /// <summary>
        /// Amount to be paid for moving goods, by whatever means, from one place to another. 
        /// </summary>
        FreightCharges = 79,

        /// <summary>
        /// Charge for packing. 
        /// </summary>
        PackingCharge = 80,

        /// <summary>
        /// Charge for repair. 
        /// </summary>
        RepairCharge = 81,

        /// <summary>
        /// Charge for loading. 
        /// </summary>
        LoadingCharge = 82,

        /// <summary>
        /// Charge for setup. 
        /// </summary>
        SetupCharge = 83,

        /// <summary>
        /// Charge for testing. 
        /// </summary>
        TestingCharge = 84,

        /// <summary>
        /// Charge for storage and handling. 
        /// </summary>
        WarehousingCharge = 85,

        /// <summary>
        /// Difference between current price and basic value contained in product price in relation to gold content. 
        /// </summary>
        GoldSurcharge = 86,

        /// <summary>
        /// Difference between current price and basic value contained in product price in relation to copper content. 
        /// </summary>
        CopperSurcharge = 87,

        /// <summary>
        /// Surcharge/deduction, calculated for higher/ lower material's consumption. 
        /// </summary>
        MaterialSurchargeDeduction = 88,

        /// <summary>
        /// Difference between current price and basic value contained in product price in relation to lead content. 
        /// </summary>
        LeadSurcharge = 89,

        /// <summary>
        /// Higher/lower price, resulting from change in costs between the times of making offer and delivery. 
        /// </summary>
        PriceIndexSurcharge = 90,

        /// <summary>
        /// Difference between current price and basic value contained in product price in relation to platinum content. 
        /// </summary>
        PlatinumSurcharge = 91,

        /// <summary>
        /// Difference between current price and basic value contained in product price in relation to silver content. 
        /// </summary>
        SilverSurcharge = 92,

        /// <summary>
        /// Difference between current price and basic value contained in product price in relation to wolfram content. 
        /// </summary>
        WolframSurcharge = 93,

        /// <summary>
        /// Difference between current price and basic value contained in product price in relation to aluminum content. 
        /// </summary>
        AluminumSurcharge = 94,

        /// <summary>
        /// A reduction from a usual or list price. 
        /// </summary>
        Discount = 95,

        /// <summary>
        /// Charge for insurance. 
        /// </summary>
        Insurance = 96,

        /// <summary>
        /// Charge for minimum order or minimum billing. 
        /// </summary>
        MinimumOrderMinimumBillingCharge = 97,

        /// <summary>
        /// Surcharge for (special) materials. 
        /// </summary>
        MaterialSurcharge = 98,

        /// <summary>
        /// An additional amount added to the usual charge. 
        /// </summary>
        Surcharge = 99,

        /// <summary>
        /// A return of part of an amount paid for goods or services, serving as a reduction or discount. 
        /// </summary>
        SpecialRebate = 100,

        /// <summary>
        /// A monetary amount charged for carbon footprint related to a regulatory requirement. 
        /// </summary>
        CarbonFootprintCharge = 101,

        /// <summary>
        /// A fixed long term allowance or charge. 
        /// </summary>
        FixedLongTerm = 102,

        /// <summary>
        /// A temporary allowance or charge. 
        /// </summary>
        Temporary = 103,

        /// <summary>
        /// The standard available allowance or charge. 
        /// </summary>
        Standard = 104,

        /// <summary>
        /// An allowance or charge based on yearly turnover. 
        /// </summary>
        YearlyTurnover = 105,

    }
}
