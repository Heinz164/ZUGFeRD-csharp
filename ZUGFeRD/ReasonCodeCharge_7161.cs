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
    /// Reason codes for charges based on UNTDID 7161
    /// https://service.unece.org/trade/untdid/latest/tred/tred7161.htm
    /// </summary>

    public enum ReasonCodeCharge_7161
    {
        /// <summary>
        /// Unknown/invalid value
        /// </summary>
        Unknown,

        /// <summary>
        /// Advertising The service of providing advertising.
        /// </summary>
        AA,

        /// <summary>
        /// Telecommunication The service of providing telecommunication activities and/or faclities.
        /// </summary>
        AAA,

        /// <summary>
        /// Technical modification The service of making technical modifications to a product.
        /// </summary>
        AAC,

        /// <summary>
        /// Job-order production The service of producing to order.
        /// </summary>
        AAD,

        /// <summary>
        /// Outlays The service of providing money for outlays on behalf of a trading partner.
        /// </summary>
        AAE,

        /// <summary>
        /// Off-premises The service of providing services outside the premises of the provider.
        /// </summary>
        AAF,

        /// <summary>
        /// Additional processing The service of providing additional processing.
        /// </summary>
        AAH,

        /// <summary>
        /// Attesting The service of certifying validity.
        /// </summary>
        AAI,

        /// <summary>
        /// Acceptance The service of accepting goods or services.
        /// </summary>
        AAS,

        /// <summary>
        /// Rush delivery The service to provide a rush delivery.
        /// </summary>
        AAT,

        /// <summary>
        /// Special construction The service of providing special construction.
        /// </summary>
        AAV,

        /// <summary>
        /// Airport facilities The service of providing airport facilities.
        /// </summary>
        AAY,

        /// <summary>
        /// Concession The service allowing a party to use another party's facilities.
        /// </summary>
        AAZ,

        /// <summary>
        /// Compulsory storage The service provided to hold a compulsory inventory.
        /// </summary>
        ABA,

        /// <summary>
        /// Fuel removal Remove or off-load fuel from vehicle, vessel or craft.
        /// </summary>
        ABB,

        /// <summary>
        /// Into plane Service of delivering goods to an aircraft from local storage.
        /// </summary>
        ABC,

        /// <summary>
        /// Overtime The service of providing labour beyond the established limit of working hours.
        /// </summary>
        ABD,

        /// <summary>
        /// Tooling The service of providing specific tooling.
        /// </summary>
        ABF,

        /// <summary>
        /// Miscellaneous Miscellaneous services.
        /// </summary>
        ABK,

        /// <summary>
        /// Additional packaging The service of providing additional packaging.
        /// </summary>
        ABL,

        /// <summary>
        /// Dunnage The service of providing additional padding materials required to secure and protect a cargo within a shipping container.
        /// </summary>
        ABN,

        /// <summary>
        /// Containerisation The service of packing items into a container.
        /// </summary>
        ABR,

        /// <summary>
        /// Carton packing The service of packing items into a carton.
        /// </summary>
        ABS,

        /// <summary>
        /// Hessian wrapped The service of hessian wrapping.
        /// </summary>
        ABT,

        /// <summary>
        /// Polyethylene wrap packing The service of packing in polyethylene wrapping.
        /// </summary>
        ABU,

        /// <summary>
        /// Miscellaneous treatment Miscellaneous treatment service.
        /// </summary>
        ACF,

        /// <summary>
        /// Enamelling treatment The service of providing enamelling treatment.
        /// </summary>
        ACG,

        /// <summary>
        /// Heat treatment The service of treating with heat.
        /// </summary>
        ACH,

        /// <summary>
        /// Plating treatment The service of providing plating treatment.
        /// </summary>
        ACI,

        /// <summary>
        /// Painting The service of painting.
        /// </summary>
        ACJ,

        /// <summary>
        /// Polishing The service of polishing.
        /// </summary>
        ACK,

        /// <summary>
        /// Priming The service of priming.
        /// </summary>
        ACL,

        /// <summary>
        /// Preservation treatment The service of preservation treatment.
        /// </summary>
        ACM,

        /// <summary>
        /// Fitting Fitting service.
        /// </summary>
        ACS,

        /// <summary>
        /// Consolidation The service of consolidating multiple consignments into one shipment.
        /// </summary>
        ADC,

        /// <summary>
        /// Bill of lading The service of providing a bill of lading document.
        /// </summary>
        ADE,

        /// <summary>
        /// Airbag The service of surrounding a product with an air bag.
        /// </summary>
        ADJ,

        /// <summary>
        /// Transfer The service of transferring.
        /// </summary>
        ADK,

        /// <summary>
        /// Slipsheet The service of securing a stack of products on a slipsheet.
        /// </summary>
        ADL,

        /// <summary>
        /// Binding Binding service.
        /// </summary>
        ADM,

        /// <summary>
        /// Repair or replacement of broken returnable package The service of repairing or replacing a broken returnable package.
        /// </summary>
        ADN,

        /// <summary>
        /// Efficient logistics A code indicating efficient logistics services.
        /// </summary>
        ADO,

        /// <summary>
        /// Merchandising A code indicating that merchandising services are in operation.
        /// </summary>
        ADP,

        /// <summary>
        /// Product mix A code indicating that product mixing services are in operation.
        /// </summary>
        ADQ,

        /// <summary>
        /// Other services A code indicating that other non-specific services are in operation.
        /// </summary>
        ADR,

        /// <summary>
        /// Pick-up The service of picking up or collection of goods.
        /// </summary>
        ADT,

        /// <summary>
        /// Chronic illness The special services provided due to chronic illness.
        /// </summary>
        ADW,

        /// <summary>
        /// New product introduction A service provided by a buyer when introducing a new product from a suppliers range to the range traded by the buyer.
        /// </summary>
        ADY,

        /// <summary>
        /// Direct delivery Direct delivery service.
        /// </summary>
        ADZ,

        /// <summary>
        /// Diversion The service of diverting deliverables.
        /// </summary>
        AEA,

        /// <summary>
        /// Disconnect The service is a disconnection.
        /// </summary>
        AEB,

        /// <summary>
        /// Distribution Distribution service.
        /// </summary>
        AEC,

        /// <summary>
        /// Handling of hazardous cargo A service for handling hazardous cargo.
        /// </summary>
        AED,

        /// <summary>
        /// Rents and leases The service of renting and/or leasing.
        /// </summary>
        AEF,

        /// <summary>
        /// Location differential Delivery to a different location than previously contracted.
        /// </summary>
        AEH,

        /// <summary>
        /// Aircraft refueling Fuel being put into the aircraft.
        /// </summary>
        AEI,

        /// <summary>
        /// Fuel shipped into storage Fuel being shipped into a storage system.
        /// </summary>
        AEJ,

        /// <summary>
        /// Cash on delivery The provision of a cash on delivery (COD) service.
        /// </summary>
        AEK,

        /// <summary>
        /// Small order processing service A service related to the processing of small orders.
        /// </summary>
        AEL,

        /// <summary>
        /// Clerical or administrative services The provision of clerical or administrative services.
        /// </summary>
        AEM,

        /// <summary>
        /// Guarantee The service of providing a guarantee.
        /// </summary>
        AEN,

        /// <summary>
        /// Collection and recycling The service of collection and recycling products.
        /// </summary>
        AEO,

        /// <summary>
        /// Copyright fee collection The service of collecting copyright fees.
        /// </summary>
        AEP,

        /// <summary>
        /// Veterinary inspection service The service of providing veterinary inspection.
        /// </summary>
        AES,

        /// <summary>
        /// Pensioner service Special service when the subject is a pensioner.
        /// </summary>
        AET,

        /// <summary>
        /// Medicine free pass holder Special service when the subject holds a medicine free pass.
        /// </summary>
        AEU,

        /// <summary>
        /// Environmental protection service The provision of an environmental protection service.
        /// </summary>
        AEV,

        /// <summary>
        /// Environmental clean-up service The provision of an environmental clean-up service.
        /// </summary>
        AEW,

        /// <summary>
        /// National cheque processing service outside account area Service of processing a national cheque outside the ordering customer's bank trading area.
        /// </summary>
        AEX,

        /// <summary>
        /// National payment service outside account area Service of processing a national payment to a beneficiary holding an account outside the trading area of the ordering customer's bank.
        /// </summary>
        AEY,

        /// <summary>
        /// National payment service within account area Service of processing a national payment to a beneficiary holding an account within the trading area of the ordering customer's bank.
        /// </summary>
        AEZ,

        /// <summary>
        /// Adjustments The service of making adjustments.
        /// </summary>
        AJ,

        /// <summary>
        /// Authentication The service of authenticating.
        /// </summary>
        AU,

        /// <summary>
        /// Cataloguing The provision of cataloguing services.
        /// </summary>
        CA,

        /// <summary>
        /// Cartage Movement of goods by heavy duty cart or vehicle.
        /// </summary>
        CAB,

        /// <summary>
        /// Certification The service of certifying.
        /// </summary>
        CAD,

        /// <summary>
        /// Certificate of conformance The service of providing a certificate of conformance.
        /// </summary>
        CAE,

        /// <summary>
        /// Certificate of origin The service of providing a certificate of origin.
        /// </summary>
        CAF,

        /// <summary>
        /// Cutting The service of cutting.
        /// </summary>
        CAI,

        /// <summary>
        /// Consular service The service provided by consulates.
        /// </summary>
        CAJ,

        /// <summary>
        /// Customer collection The service of collecting goods by the customer.
        /// </summary>
        CAK,

        /// <summary>
        /// Payroll payment service Provision of a payroll payment service.
        /// </summary>
        CAL,

        /// <summary>
        /// Cash transportation Provision of a cash transportation service.
        /// </summary>
        CAM,

        /// <summary>
        /// Home banking service Provision of a home banking service.
        /// </summary>
        CAN,

        /// <summary>
        /// Bilateral agreement service Provision of a service as specified in a bilateral special agreement.
        /// </summary>
        CAO,

        /// <summary>
        /// Insurance brokerage service Provision of an insurance brokerage service.
        /// </summary>
        CAP,

        /// <summary>
        /// Cheque generation Provision of a cheque generation service.
        /// </summary>
        CAQ,

        /// <summary>
        /// Preferential merchandising location Service of assigning a preferential location for merchandising.
        /// </summary>
        CAR,

        /// <summary>
        /// Crane The service of providing a crane.
        /// </summary>
        CAS,

        /// <summary>
        /// Special colour service Providing a colour which is different from the default colour.
        /// </summary>
        CAT,

        /// <summary>
        /// Sorting The provision of sorting services.
        /// </summary>
        CAU,

        /// <summary>
        /// Battery collection and recycling The service of collecting and recycling batteries.
        /// </summary>
        CAV,

        /// <summary>
        /// Product take back fee The fee the consumer must pay the manufacturer to take back the product.
        /// </summary>
        CAW,

        /// <summary>
        /// Quality control released Informs the stockholder it is free to distribute the quality controlled passed goods.
        /// </summary>
        CAX,

        /// <summary>
        /// Quality control held Instructs the stockholder to withhold distribution of the goods until the manufacturer has completed a quality control assessment.
        /// </summary>
        CAY,

        /// <summary>
        /// Quality control embargo Instructs the stockholder to withhold distribution of goods which have failed quality control tests.
        /// </summary>
        CAZ,

        /// <summary>
        /// Car loading Car loading service.
        /// </summary>
        CD,

        /// <summary>
        /// Cleaning Cleaning service.
        /// </summary>
        CG,

        /// <summary>
        /// Cigarette stamping The service of providing cigarette stamping.
        /// </summary>
        CS,

        /// <summary>
        /// Count and recount The service of doing a count and recount.
        /// </summary>
        CT,

        /// <summary>
        /// Layout/design The service of providing layout/design.
        /// </summary>
        DAB,

        /// <summary>
        /// Assortment allowance Allowance given when a specific part of a suppliers assortment is purchased by the buyer.
        /// </summary>
        DAC,

        /// <summary>
        /// Driver assigned unloading The service of unloading by the driver.
        /// </summary>
        DAD,

        /// <summary>
        /// Debtor bound A special allowance or charge applicable to a specific debtor.
        /// </summary>
        DAF,

        /// <summary>
        /// Dealer allowance An allowance offered by a party dealing a certain brand or brands of products.
        /// </summary>
        DAG,

        /// <summary>
        /// Allowance transferable to the consumer An allowance given by the manufacturer which should be transfered to the consumer.
        /// </summary>
        DAH,

        /// <summary>
        /// Growth of business An allowance or charge related to the growth of business over a pre-determined period of time.
        /// </summary>
        DAI,

        /// <summary>
        /// Introduction allowance An allowance related to the introduction of a new product to the range of products traded by a retailer.
        /// </summary>
        DAJ,

        /// <summary>
        /// Multi-buy promotion A code indicating special conditions related to a multi- buy promotion.
        /// </summary>
        DAK,

        /// <summary>
        /// Partnership An allowance or charge related to the establishment and on-going maintenance of a partnership.
        /// </summary>
        DAL,

        /// <summary>
        /// Return handling An allowance or change related to the handling of returns.
        /// </summary>
        DAM,

        /// <summary>
        /// Minimum order not fulfilled charge Charge levied because the minimum order quantity could not be fulfilled.
        /// </summary>
        DAN,

        /// <summary>
        /// Point of sales threshold allowance Allowance for reaching or exceeding an agreed sales threshold at the point of sales.
        /// </summary>
        DAO,

        /// <summary>
        /// Wholesaling discount A special discount related to the purchase of products through a wholesaler.
        /// </summary>
        DAP,

        /// <summary>
        /// Documentary credits transfer commission Fee for the transfer of transferable documentary credits.
        /// </summary>
        DAQ,

        /// <summary>
        /// Delivery The service of providing delivery.
        /// </summary>
        DL,

        /// <summary>
        /// Engraving The service of providing engraving.
        /// </summary>
        EG,

        /// <summary>
        /// Expediting The service of expediting.
        /// </summary>
        EP,

        /// <summary>
        /// Exchange rate guarantee The service of guaranteeing exchange rate.
        /// </summary>
        ER,

        /// <summary>
        /// Fabrication The service of providing fabrication.
        /// </summary>
        FAA,

        /// <summary>
        /// Freight equalization The service of load balancing.
        /// </summary>
        FAB,

        /// <summary>
        /// Freight extraordinary handling The service of providing freight's extraordinary handling.
        /// </summary>
        FAC,

        /// <summary>
        /// Freight service The service of moving goods, by whatever means, from one place to another.
        /// </summary>
        FC,

        /// <summary>
        /// Filling/handling The service of providing filling/handling.
        /// </summary>
        FH,

        /// <summary>
        /// Financing The service of providing financing.
        /// </summary>
        FI,

        /// <summary>
        /// Grinding The service of grinding.
        /// </summary>
        GAA,

        /// <summary>
        /// Hose The service of providing a hose.
        /// </summary>
        HAA,

        /// <summary>
        /// Handling Handling service.
        /// </summary>
        HD,

        /// <summary>
        /// Hoisting and hauling The service of hoisting and hauling.
        /// </summary>
        HH,

        /// <summary>
        /// Installation The service of installing.
        /// </summary>
        IAA,

        /// <summary>
        /// Installation and warranty The service of installing and providing warranty.
        /// </summary>
        IAB,

        /// <summary>
        /// Inside delivery The service of providing delivery inside.
        /// </summary>
        ID,

        /// <summary>
        /// Inspection The service of inspection.
        /// </summary>
        IF,

        /// <summary>
        /// Installation and training The service of providing installation and training.
        /// </summary>
        IR,

        /// <summary>
        /// Invoicing The service of providing an invoice.
        /// </summary>
        IS,

        /// <summary>
        /// Koshering The service of preparing food in accordance with Jewish law.
        /// </summary>
        KO,

        /// <summary>
        /// Carrier count The service of counting by the carrier.
        /// </summary>
        L1,

        /// <summary>
        /// Labelling Labelling service.
        /// </summary>
        LA,

        /// <summary>
        /// Labour The service to provide required labour.
        /// </summary>
        LAA,

        /// <summary>
        /// Repair and return The service of repairing and returning.
        /// </summary>
        LAB,

        /// <summary>
        /// Legalisation The service of legalising.
        /// </summary>
        LF,

        /// <summary>
        /// Mounting The service of mounting.
        /// </summary>
        MAE,

        /// <summary>
        /// Mail invoice The service of mailing an invoice.
        /// </summary>
        MI,

        /// <summary>
        /// Mail invoice to each location The service of mailing an invoice to each location.
        /// </summary>
        ML,

        /// <summary>
        /// Non-returnable containers The service of providing non-returnable containers.
        /// </summary>
        NAA,

        /// <summary>
        /// Outside cable connectors The service of providing outside cable connectors.
        /// </summary>
        OA,

        /// <summary>
        /// Invoice with shipment The service of including the invoice with the shipment.
        /// </summary>
        PA,

        /// <summary>
        /// Phosphatizing (steel treatment) The service of phosphatizing the steel.
        /// </summary>
        PAA,

        /// <summary>
        /// Packing The service of packing.
        /// </summary>
        PC,

        /// <summary>
        /// Palletizing The service of palletizing.
        /// </summary>
        PL,

        /// <summary>
        /// Repacking The service of repacking.
        /// </summary>
        RAB,

        /// <summary>
        /// Repair The service of repairing.
        /// </summary>
        RAC,

        /// <summary>
        /// Returnable container The service of providing returnable containers.
        /// </summary>
        RAD,

        /// <summary>
        /// Restocking The service of restocking.
        /// </summary>
        RAF,

        /// <summary>
        /// Re-delivery The service of re-delivering.
        /// </summary>
        RE,

        /// <summary>
        /// Refurbishing The service of refurbishing.
        /// </summary>
        RF,

        /// <summary>
        /// Rail wagon hire The service of providing rail wagons for hire.
        /// </summary>
        RH,

        /// <summary>
        /// Loading The service of loading goods.
        /// </summary>
        RV,

        /// <summary>
        /// Salvaging The service of salvaging.
        /// </summary>
        SA,

        /// <summary>
        /// Shipping and handling The service of shipping and handling.
        /// </summary>
        SAA,

        /// <summary>
        /// Special packaging The service of special packaging.
        /// </summary>
        SAD,

        /// <summary>
        /// Stamping The service of stamping.
        /// </summary>
        SAE,

        /// <summary>
        /// Consignee unload The service of unloading by the consignee.
        /// </summary>
        SAI,

        /// <summary>
        /// Shrink-wrap The service of shrink-wrapping.
        /// </summary>
        SG,

        /// <summary>
        /// Special handling The service of special handling.
        /// </summary>
        SH,

        /// <summary>
        /// Special finish The service of providing a special finish.
        /// </summary>
        SM,

        /// <summary>
        /// Set-up The service of setting-up.
        /// </summary>
        SU,

        /// <summary>
        /// Tank renting The service of providing tanks for hire.
        /// </summary>
        TAB,

        /// <summary>
        /// Testing The service of testing.
        /// </summary>
        TAC,

        /// <summary>
        /// Transportation - third party billing The service of providing third party billing for transportation.
        /// </summary>
        TT,

        /// <summary>
        /// Transportation by vendor The service of providing transportation by the vendor.
        /// </summary>
        TV,

        /// <summary>
        /// Drop yard The service of delivering goods at the yard.
        /// </summary>
        V1,

        /// <summary>
        /// Drop dock The service of delivering goods at the dock.
        /// </summary>
        V2,

        /// <summary>
        /// Warehousing The service of storing and handling of goods in a warehouse.
        /// </summary>
        WH,

        /// <summary>
        /// Combine all same day shipment The service of combining all shipments for the same day.
        /// </summary>
        XAA,

        /// <summary>
        /// Split pick-up The service of providing split pick-up.
        /// </summary>
        YY,

        /// <summary>
        /// Mutually defined A code assigned within a code list to be used on an interim basis and as defined among trading partners until a precise code can be assigned to the code list.
        /// </summary>
        ZZZ
    }
}
