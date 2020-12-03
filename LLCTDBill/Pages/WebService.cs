using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace LLCTDBill.Pages
{
    public class WebService : TestBase
    {
        public static string ResponseFCTURN = null;
        public static string LenderRefNo = null;
        public static string MortgageNo = null;
        public static string ClosingDate = null;

        public void CreateTDDealWithCreditAgr(string PropertyCity, string PropertyProvince, string DocumentType, string CreditAgreementFormNumber, string CreditAgreementFormName, string CreditAgreementDate, string ProductReslPlIndicator, string TotalLoanAmount, string BatFile, string ResponseFilePath)
        {
            var pathSoapUI = projectDirectory + @"\LLCTDBill\LLCTDBill\Services\LLCTDBill134.xml";
            //var TDEndPoint = "http://iisprillciqa11.prefirstcdn.com/InboundLenderService/InboundLenderService.svc";
            var pathFile = projectDirectory + @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs";
            //var LenderIdNo = "-44";
            //var LawyerIDNo = "100030845";
            //var ClosingDate = "2020-12-08";
            ClosingDate = CurrentOrFutureDate("yyyy-MM-dd");

            Process proc = null;
            try
            {
                string targetDir = string.Format(projectDirectory + @"\LLCTDBill\LLCTDBill\Services\TDBatchFiles");   //this is where mybatch.bat lies
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = BatFile;
                proc.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\" \"{10}\" \"{11}\" \"{12}\" \"{13}\"", pathSoapUI, TDEndPoint, pathFile, LenderIdNo, LawyerIDNo, ClosingDate, PropertyCity, PropertyProvince, DocumentType, CreditAgreementFormNumber, CreditAgreementFormName, CreditAgreementDate, ProductReslPlIndicator, TotalLoanAmount);
                //proc.StartInfo.Arguments = [pathSoapUI, TDEndPoint, pathFile, LenderIdNo, LawyerIDNo, ClosingDate, PropertyCity, PropertyProvince, DocumentType];
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  //this is for hiding the cmd window...so execution will happen in back ground.
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }

            var response = ConvertXML2Json(projectDirectory + ResponseFilePath);
            var responseData = JObject.Parse(response);
            ResponseFCTURN = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["FCTURN"]["#text"].ToString();
            LenderRefNo = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["LenderReferenceNumber"]["#text"].ToString();
            Console.WriteLine("Fct Urn: ", ResponseFCTURN);
            Console.WriteLine("Lender Reference No: ", LenderRefNo);

            MortgageNo = ReadTXT(projectDirectory + @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\MortgageNumber.txt");
            Console.WriteLine("Mortgage Number: ", MortgageNo);
        }

        public void CreateTDDealWithoutCreditAgr(string PropertyCity, string PropertyProvince, string DocumentType, string TotalLoanAmount, string BatFile, string ResponseFilePath)
        {
            var pathSoapUI = projectDirectory + @"\LLCTDBill\LLCTDBill\Services\LLCTDBill134.xml";
            var pathFile = projectDirectory + @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs";
            ClosingDate = CurrentOrFutureDate("yyyy-MM-dd");

            Process proc = null;
            try
            {
                string targetDir = string.Format(projectDirectory + @"\LLCTDBill\LLCTDBill\Services\TDBatchFiles");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = BatFile;
                proc.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\"", pathSoapUI, TDEndPoint, pathFile, LenderIdNo, LawyerIDNo, ClosingDate, PropertyCity, PropertyProvince, DocumentType, TotalLoanAmount);
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }

            var response = ConvertXML2Json(projectDirectory + ResponseFilePath);
            var responseData = JObject.Parse(response);
            ResponseFCTURN = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["FCTURN"]["#text"].ToString();
            LenderRefNo = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["LenderReferenceNumber"]["#text"].ToString();
            Console.WriteLine("Fct Urn: ", ResponseFCTURN);
            Console.WriteLine("Lender Reference No: ", LenderRefNo);

            MortgageNo = ReadTXT(projectDirectory + @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs\MortgageNumber.txt");
            Console.WriteLine("Mortgage Number: ", MortgageNo);
        }

        public void UpdateTDDealWithCreditAgr(string ClosingDateUpdate, string PropertyCity, string PropertyProvince, string DocumentType, string FCTURN, string CreditAgreementFormNumber, string CreditAgreementFormName, string CreditAgreementDate, string TotalLoanAmount, string BatFile, string ResponseFilePath)
        {
            var pathSoapUI = projectDirectory + @"\LLCTDBill\LLCTDBill\Services\LLCTDBill134.xml";
            var pathFile = projectDirectory + @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs";
            //var ClosingDate = CurrentOrFutureDate("yyyy-MM-dd");

            Process proc = null;
            try
            {
                string targetDir = string.Format(projectDirectory + @"\LLCTDBill\LLCTDBill\Services\TDBatchFiles");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = BatFile;
                proc.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\" \"{10}\" \"{11}\" \"{12}\" \"{13}\" \"{14}\" \"{15}\"", pathSoapUI, TDEndPoint, pathFile, LenderIdNo, LawyerIDNo, LenderRefNo, MortgageNo, ClosingDateUpdate, PropertyCity, PropertyProvince, DocumentType, FCTURN, CreditAgreementFormNumber, CreditAgreementFormName, CreditAgreementDate, TotalLoanAmount);
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }

            var response = ConvertXML2Json(projectDirectory + ResponseFilePath);
            var responseData = JObject.Parse(response);
            ResponseFCTURN = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["FCTURN"]["#text"].ToString();
            LenderRefNo = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["LenderReferenceNumber"]["#text"].ToString();
            Assert.True(ResponseFCTURN.Equals(FCTURN));
        }

        public void UpdateTDDealWithoutCreditAgr(string ClosingDateUpdate, string PropertyCity, string PropertyProvince, string DocumentType, string FCTURN, string TotalLoanAmount, string BatFile, string ResponseFilePath)
        {
            var pathSoapUI = projectDirectory + @"\LLCTDBill\LLCTDBill\Services\LLCTDBill134.xml";
            var pathFile = projectDirectory + @"\LLCTDBill\LLCTDBill\TestData\TDResponseXMLs";

            Process proc = null;
            try
            {
                string targetDir = string.Format(projectDirectory + @"\LLCTDBill\LLCTDBill\Services\TDBatchFiles");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = BatFile;
                proc.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\" \"{10}\" \"{11}\" \"{12}\"", pathSoapUI, TDEndPoint, pathFile, LenderIdNo, LawyerIDNo, LenderRefNo, MortgageNo, ClosingDateUpdate, PropertyCity, PropertyProvince, DocumentType, FCTURN, TotalLoanAmount);
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }

            var response = ConvertXML2Json(projectDirectory + ResponseFilePath);
            var responseData = JObject.Parse(response);
            ResponseFCTURN = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["FCTURN"]["#text"].ToString();
            LenderRefNo = responseData["s:Envelope"]["s:Body"]["LenderResponse"]["LenderReferenceNumber"]["#text"].ToString();
            Assert.True(ResponseFCTURN.Equals(FCTURN));
        }
    }
}
