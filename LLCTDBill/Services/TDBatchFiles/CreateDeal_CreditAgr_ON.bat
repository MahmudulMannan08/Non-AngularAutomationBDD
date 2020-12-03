cd "C:\Program Files (x86)\SmartBear\SoapUI-5.0.0\bin"

set projectFileName=%1%
set RequestURL=%2%
set DealResponseFilePath=%3%
set LenderId=%4%
set LawyerID=%5%
set ClosingDate=%6%
set City=%7%
set Province=%8%
set DocumentType=%9%

shift
shift
shift
shift
shift
shift
shift
shift
shift

set CreditAgreementFormNumber=%1%
set CreditAgreementFormName=%2%
set CreditAgreementDate=%3%
set ProductReslPlIndicator=%4%
set TotalLoanAmount=%5%

testrunner.bat -s "LLCTDBill134 Test Suit" -c "CreateDeal_CreditAgr_ON" -PDealResponseFilePath="%DealResponseFilePath%" -PLenderId=%LenderId% -PLawyerID=%LawyerID% -PClosingDate=%ClosingDate% -PCity=%City% -PProvince=%Province% -PDocumentType=%DocumentType% -PCreditAgreementFormNumber=%CreditAgreementFormNumber% -PCreditAgreementFormName=%CreditAgreementFormName% -PCreditAgreementDate=%CreditAgreementDate% -PProductReslPlIndicator=%ProductReslPlIndicator% -PTotalLoanAmount=%TotalLoanAmount% -e%RequestURL% %projectFileName%