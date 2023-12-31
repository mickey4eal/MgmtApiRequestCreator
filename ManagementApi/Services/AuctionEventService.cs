﻿namespace ManagementApi.Services
{
    using ManagementApi.Responses;
    using ManagementApi.Services.Interfaces;
    using System.Collections.Generic;

    public class AuctionEventService : IAuctionEventService
    {
        private readonly ISqlConnectionWrapper _sqlConnectionWrapper;

        private const string AUCTION_DETAILS_QUERY = @"SELECT
      [SaleName]
	  ,[SaleNumber]
	  ,[StatusCode] AS SaleStatus
	  ,[SaleTypeCode] AS SaleType
	  ,[SalesTaxExemptionEnabled]
	  ,[EmailAddress] AS SaleEmail
	  ,[HasInBondLots] AS SaleHasInBondLots
	  ,[SaleCoordinatorEmailSignatureHtml] AS SaleCoordinatorEmailSignature
	  ,[LotEndTimeInterval]
	  ,[KycMandatory]
	  ,bis.[Name] AS BidIncrementSet
	  ,[BondedDeliveryDisabled]
	  ,[BuyersPremiumOverride]
	  ,bus.[Code] AS CompanyCode
	  --CompanyCode
	  ,cur.[ISO_4217_Code] AS Currency
	  ,[DefaultCreditLimit]
	  ,[AnalyticsSaleType]
	  ,[Starts] AS SaleStartTime
	  ,[Ends] AS SaleEndTime
	  ,aes.[SessionStart] AS SessionStartTime
	  --SessionStart
	  ,aes.[SessionEnd] AS SessionEndTime
	  --SessionEnd
	  ,[ShippingConfigurationType]
	  --OffsetMinutes
	  ,jgrsa.[AttributeName] AS GeoRestrictionAttribute
	  --GeoRestrictionAttribute
  FROM [dbo].[AuctionEvents] ae
  Join [dbo].[Businesses] bus ON ae.[BusinessId] = bus.[Id]
  Join [dbo].[AuctionEventSessions] aes ON ae.[Id] = aes.[AuctionEventId]
  Left Join [dbo].[JdeGeoRestrictionSaleAttributes] jgrsa ON ae.[Id] = jgrsa.[AuctionEventId]
  Join [dbo].[Currencies] cur ON ae.[CurrencyId] = cur.[Id]
  Join [dbo].[BidIncrementSets] bis ON ae.[BidIncrementSetId] = bis.[Id]
  Where ae.[Id] = @SaleId";

        public AuctionEventService(ISqlConnectionWrapper sqlConnectionWrapper)
        {
            _sqlConnectionWrapper = sqlConnectionWrapper;
        }

        public async Task<AuctionEventsResponse?> GetAuctionEventDetails(int? saleId)
        {
            try
            {
                AuctionEventsResponse? auctionEventsResponse;

                using (_sqlConnectionWrapper)
                {
                    auctionEventsResponse = await _sqlConnectionWrapper.QuerySingleOrDefaultAsync<AuctionEventsResponse?>(CreateGetAuctionEventDetailsCommand(), new
                    {
                        SaleId = saleId
                    });
                }

                return auctionEventsResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught! {ex}\n");
                return null;
            }
        }

        public async Task<AuctionEventsResponse?> GetAuctionEventDetailsRouteTwo(int? saleId)
        {
            try
            {
                IEnumerable<AuctionEventsResponse?> auctionEventsResponse;

                using (_sqlConnectionWrapper)
                {
                    auctionEventsResponse = await _sqlConnectionWrapper.QueryAsync<AuctionEventsResponse?>(CreateGetAuctionEventDetailsCommand(), new
                    {
                        SaleId = saleId
                    });
                }

                return auctionEventsResponse.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught! {ex}\n");
                return null;
            }
        }

        private static string CreateGetAuctionEventDetailsCommand() => AUCTION_DETAILS_QUERY;
    }
}