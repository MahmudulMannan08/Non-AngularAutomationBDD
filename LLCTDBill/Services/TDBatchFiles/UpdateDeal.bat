cd "C:\Program Files (x86)\SmartBear\SoapUI-5.0.0\bin"

set projectFileName=%1%
set RequestURL=%2%
set DealResponseFilePath=%3%
set LenderId=%4%
set LawyerID=%5%
set LenderReferenceNumber=%6%
set MortgageNumber=%7%
set ClosingDate=%8%
set City=%9%

shift
shift
shift
shift
shift
shift
shift
shift
shift

set Province=%1%
set DocumentType=%2%
set FCTURN=%3%
set TotalLoanAmount=%4%

testrunner.bat -s "LLCTDBill134 Test Suit" -c "UpdateDeal" -PDealResponseFilePath="%DealResponseFilePath%" -PLenderId=%LenderId% -PLawyerID=%LawyerID% -PLenderReferenceNumber=%LenderReferenceNumber% -PMortgageNumber=%MortgageNumber% -PClosingDate=%ClosingDate% -PCity=%City% -PProvince=%Province% -PDocumentType=%DocumentType% -PFCTURN=%FCTURN% -PTotalLoanAmount=%TotalLoanAmount% -e%RequestURL% %projectFileName%