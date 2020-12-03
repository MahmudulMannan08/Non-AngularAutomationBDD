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
set CreditAgreementFormNumber=%4%
set CreditAgreementFormName=%5%
set CreditAgreementDate=%6%
set TotalLoanAmount=%7%

testrunner.bat -s "LLCTDBill134 Test Suit" -c "UpdateDeal_CreditAgr_ON" -PDealResponseFilePath="%DealResponseFilePath%" -PLenderId=%LenderId% -PLawyerID=%LawyerID% -PLenderReferenceNumber=%LenderReferenceNumber% -PMortgageNumber=%MortgageNumber% -PClosingDate=%ClosingDate% -PCity=%City% -PProvince=%Province% -PDocumentType=%DocumentType% -PFCTURN=%FCTURN% -PCreditAgreementFormNumber=%CreditAgreementFormNumber% -PCreditAgreementFormName=%CreditAgreementFormName% -PCreditAgreementDate=%CreditAgreementDate% -PTotalLoanAmount=%TotalLoanAmount% -e%RequestURL% %projectFileName%