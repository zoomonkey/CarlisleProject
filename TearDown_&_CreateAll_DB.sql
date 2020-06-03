DROP TABLE IF EXISTS [dbo].OrderDetail;
DROP TABLE IF EXISTS [dbo].OrderHeader;
DROP TABLE IF EXISTS [dbo].Customer;
DROP TABLE IF EXISTS [dbo].Item;

CREATE TABLE [dbo].OrderHeader
(
	OrderNumber varchar(20) NOT NULL PRIMARY KEY 
	,OrderDateKey varchar(20) 
	,CustomerNumber varchar(20)	
	,RequestedShipDate	varchar(20)
	,OrderStatus varchar(20)
	,FreightTerms varchar(20)
	,CustomerPONumber varchar(20)
);

CREATE TABLE [dbo].OrderDetail
(
	OrderNumber varchar(20) NOT NULL FOREIGN KEY REFERENCES OrderHeader(OrderNumber) 
	,LineNumber varchar(20) 
	,ItemNumber varchar(20)	
	,GrossSalesAmount	money
	,StandardPrice money
	,Quantity int
);

CREATE TABLE [dbo].Customer
(
	CustomerNumber varchar(20) NOT NULL PRIMARY KEY 
	,Customer varchar(30) 
	,Address1 varchar(30)	
	,Address2	varchar(30)
	,Address3 varchar(30)
	,BillingCity varchar(20)
	,BillingState varchar(20)
	,BillingZip varchar(20)
	,BillingCountry varchar(20)
);

CREATE TABLE [dbo].Item
(
	ItemNumber varchar(30) NOT NULL PRIMARY KEY 
	,ItemDesc varchar(60) 
	,Color varchar(60)	
);	


INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787083', N'20200424', N'20645000', N'20200424', N'Invoiced', N'Third Party Bill', N'79539010')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787084', N'20200424', N'81739100', N'20200424', N'Open', N'Third Party Bill', N'CS228243429')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787085', N'20200424', N'81739100', N'20200424', N'Cancelled', N'Third Party Bill', N'CS228271437')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787087', N'20200424', N'89999469', N'20200424', N'Open', N'Third Party Bill', N'16563121')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787088', N'20200424', N'89999469', N'20200424', N'Open', N'Third Party Bill', N'08606182')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787089', N'20200424', N'9990100', N'20200424', N'Open', N'Prepaid', N'WEBCART104607-CMB')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787090', N'20200424', N'37990000', N'20200424', N'Open', N'Prepaid', N'WEBCART104357-MRK')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787091', N'20200424', N'41545000', N'20200424', N'Open', N'Third Party Bill', N'1574334070110')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787092', N'20200424', N'41545000', N'20200424', N'Open', N'Third Party Bill', N'1574334110262')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787093', N'20200424', N'41545000', N'20200424', N'Open', N'Third Party Bill', N'1574334210124')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787094', N'20200424', N'41545000', N'20200424', N'Open', N'Third Party Bill', N'1574334280110')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787095', N'20200424', N'20645000', N'20200424', N'Invoiced', N'Third Party Bill', N'79539030')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787098', N'20200424', N'89999469', N'20200424', N'Invoiced', N'Third Party Bill', N'08620289')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787118', N'20200424', N'81739100', N'20200424', N'Open', N'Third Party Bill', N'CS228322283')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787119', N'20200424', N'41545000', N'20200424', N'Open', N'Third Party Bill', N'1574334720124')
INSERT INTO [dbo].[OrderHeader] ([OrderNumber], [OrderDateKey], [CustomerNumber], [RequestedShipDate], [OrderStatus], [FreightTerms], [CustomerPONumber]) VALUES (N'5787124', N'20200424', N'81739100', N'20200424', N'Open', N'Third Party Bill', N'CS228328147')


INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787083', N'1', N'369816B00', N'30.96', N'2.58', 12)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787084', N'1', N'5526-207', N'11.76', N'0.49', 24)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787085', N'1', N'6400106', N'89.52', N'7.46', 12)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787087', N'1', N'36141003-1', N'9.12', N'9.12', 1)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787088', N'1', N'36141503', N'14.23', N'14.23', 1)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787089', N'1', N'10223B07', N'71.16', N'35.58', 2)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787089', N'2', N'10230U07', N'26.92', N'13.46', 2)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787090', N'1', N'53201554L018', N'56.06', N'56.06', 1)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787091', N'1', N'DX4GC607', N'78.18', N'78.18', 1)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787092', N'1', N'SCDG13', N'68.36', N'68.36', 1)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787093', N'1', N'4042100', N'198.84', N'16.57', 12)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787094', N'1', N'DXSMC1520NSM23', N'520.26', N'260.13', 2)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787095', N'1', N'36315600', N'95.28', N'7.94', 12)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787095', N'2', N'34104424', N'76.05', N'25.35', 3)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787095', N'3', N'36141003-1', N'9.12', N'9.12', 1)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787098', N'1', N'4114000', N'11.8', N'11.8', 1)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787118', N'1', N'54001-415', N'75.04', N'37.52', 2)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787119', N'1', N'369024C00', N'70.32', N'5.86', 12)
INSERT INTO [dbo].[OrderDetail] ([OrderNumber], [LineNumber], [ItemNumber], [GrossSalesAmount], [StandardPrice], [Quantity]) VALUES (N'5787124', N'1', N'5526-207', N'11.76', N'0.49', 24)


INSERT INTO [dbo].[Customer] ([CustomerNumber], [Customer], [Address1], [Address2], [Address3], [BillingCity], [BillingState], [BillingZip], [BillingCountry]) VALUES (N'20645000', N'HIGH PRICE FOODSERVICE', N'PO BOX 1111', N'', N'', N'GRAND RAPIDS', N'MI', N'49501', N'US')
INSERT INTO [dbo].[Customer] ([CustomerNumber], [Customer], [Address1], [Address2], [Address3], [BillingCity], [BillingState], [BillingZip], [BillingCountry]) VALUES (N'81739100', N'LOW PRICE FOODSERVICE', N'177 HUNTINGTON AVE SUITE 300', N'', N'', N'BOSTON', N'MA', N'02115', N'US')
INSERT INTO [dbo].[Customer] ([CustomerNumber], [Customer], [Address1], [Address2], [Address3], [BillingCity], [BillingState], [BillingZip], [BillingCountry]) VALUES (N'89999469', N'THE HOME SHOP', N'THE HOME SHOP RECEIVING', N'PO BOX 105744', N'', N'ATLANTA', N'GA', N'30348', N'US')
INSERT INTO [dbo].[Customer] ([CustomerNumber], [Customer], [Address1], [Address2], [Address3], [BillingCity], [BillingState], [BillingZip], [BillingCountry]) VALUES (N'9990100', N'ADVANCED SUPPLIES', N'ADVANCED SUPPLIES RECEIVING', N'PO BOX 53006', N'', N'OKLAHOMA CITY', N'OK', N'73152', N'US')
INSERT INTO [dbo].[Customer] ([CustomerNumber], [Customer], [Address1], [Address2], [Address3], [BillingCity], [BillingState], [BillingZip], [BillingCountry]) VALUES (N'37990000', N'ELITE DEPOT', N'P.O. BOX 22222', N'', N'', N'HONOLULU', N'HI', N'96828', N'US')
INSERT INTO [dbo].[Customer] ([CustomerNumber], [Customer], [Address1], [Address2], [Address3], [BillingCity], [BillingState], [BillingZip], [BillingCountry]) VALUES (N'41545000', N'GORDON SHIPPING SERVICE', N'101 CHASTAIN MEADOWS CT NW', N'STE 206', N'', N'KENNESAW', N'GA', N'30144', N'US')


INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'369816B00', N'#16 4-PLY SM CTN C/END WETMOP', N'Miscellaneous/Variegated/Assortments')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'5526-207', N'TUMBLER STACKABL 8 OZ CRYS 2DZ', N'Clear/Crystal/Natural/Satin')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'6400106', N'GROVE 11" DINNER PLATE - BUFF', N'Beige/Buff/Oatmeal')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'36141003-1', N'12" DUO-PAN LOBBY DUST PAN', NULL)
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'36141503', N'DUO-PAN LBY DSTPN W/BR/Y-CLIP&', N'Black')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'10223B07', N'FOOD PAN 1/2 SIZE 8" DP CLEAR', N'Clear/Crystal/Natural/Satin')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'10230U07', N'LID FP UNIV 1/2 SZ HADLD CLR', N'Clear/Crystal/Natural/Satin')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'53201554L018', N'VINYL CLR 12-GAUGE 15YD ROLL', N'Orange')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'DX4GC607', N'TUMBLER 6OZ PLASTIC CLR 72/PK', N'Clear/Crystal/Natural/Satin')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'SCDG13', N'NSF LISTED DIGITAL SCALE, 13 LB / 6 KG', NULL)
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'4042100', N'SCRUB BRUSH W/SQUEEGEE', N'Miscellaneous/Variegated/Assortments')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'DXSMC1520NSM23', N'TRAY 15X20 NON-SKID SMC MARBLE GRAY 12/CS', N'Aluminum/Grey/Clasic Gry/Dove Gry/Mirror')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'36315600', N'52"-81"TELESCOPING WOOL DUSTER', N'Miscellaneous/Variegated/Assortments')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'34104424', N'44 GAL ROUND TRASH CAN ORANGE', N'Orange/Pumpkin')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'4114000', N'3'' POLYSTR PIPE BR 1.5"D WH', N'Miscellaneous/Variegated/Assortments')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'54001-415', N'MINGLE 11" DINNER PLATE- AQUA', N'Teal')
INSERT INTO [dbo].[Item] ([ItemNumber], [ItemDesc], [Color]) VALUES (N'369024C00', N'#24 KWIK-ON COTTON MOP', N'Miscellaneous/Variegated/Assortments')

GO

CREATE TRIGGER UpdateGrossSalesAmount
ON dbo.OrderDetail
AFTER INSERT, UPDATE, DELETE 
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE OrderDetail
	SET GrossSalesAmount = StandardPrice * Quantity
END

GO

IF EXISTS ( SELECT * 
			FROM   sysobjects 
			WHERE  id = object_id(N'[dbo].[MainSelect]') 
				   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
	DROP PROCEDURE [dbo].[MainSelect]
END

GO

CREATE PROCEDURE [dbo].[MainSelect]
AS
	SELECT 
		C.Customer 
		,OH.OrderNumber
		,I.ItemDesc
		,I.Color 
		,OrderDateKey 
		,OH.CustomerNumber 
		,RequestedShipDate	
		,OrderStatus 
		,FreightTerms 
		,LineNumber
		,GrossSalesAmount	
		,StandardPrice 
		,Quantity 

FROM OrderHeader OH
	INNER JOIN OrderDetail OD ON OH.OrderNumber = OD.OrderNumber
	INNER JOIN Customer C on OH.CustomerNumber = C.CustomerNumber
	INNER JOIN Item I on OD.ItemNumber = I.ItemNumber

RETURN 0

GO
IF EXISTS ( SELECT * 
			FROM   sysobjects 
			WHERE  id = object_id(N'[dbo].[UpdateOrderDetail]') 
				   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
	DROP PROCEDURE [dbo].[UpdateOrderDetail]
END
 
GO

CREATE PROCEDURE [UpdateOrderDetail]
	@RequestedShipDate varchar(20),
	@OrderNumber varchar(20),
	@Quantity int,
	@OrderStatus varchar(20),
	@FreightTerms varchar(20)

AS

	
BEGIN TRANSACTION 

  BEGIN TRY

    UPDATE [OrderDetail] SET 
		[Quantity] = @Quantity
	WHERE [OrderNumber] = @OrderNumber
	
    UPDATE [OrderHeader] SET 
		[RequestedShipDate] = @RequestedShipDate,
		[OrderStatus] = @OrderStatus,
		[FreightTerms] = @FreightTerms
	WHERE [OrderNumber] = @OrderNumber
	
    COMMIT TRANSACTION 

  END TRY
  
  BEGIN CATCH  
	SELECT   
		ERROR_NUMBER() AS ErrorNumber  
		,ERROR_SEVERITY() AS ErrorSeverity  
		,ERROR_STATE() AS ErrorState  
		,ERROR_PROCEDURE() AS ErrorProcedure  
		,ERROR_LINE() AS ErrorLine  
		,ERROR_MESSAGE() AS ErrorMessage;  
  
	IF @@TRANCOUNT > 0  
		ROLLBACK TRANSACTION;  
   END CATCH;  
  
	IF @@TRANCOUNT > 0  
	COMMIT TRANSACTION;  
	GO  





