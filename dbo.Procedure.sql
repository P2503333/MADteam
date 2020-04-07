CREATE PROCEDURE sproc_tblOrder_FilterByOrder_ID
	--parameter to store the OrderID we looking for
	@Order_ID int 	
	AS 
	-- select all fields from the table where OrderID matches the parameter data
	SELECT * from tblOrder where Order_ID = @Order_ID

RETURN 0
