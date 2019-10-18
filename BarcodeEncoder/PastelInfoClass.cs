using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
namespace BarcodeEncoder
{
    class PastelInfoClass
    {
       

        public string GetResultDesc(string strRCode)
        {
            string GetResultDescRet = default(string);
            switch (strRCode)
            {
                case "0":
                    {
                        GetResultDescRet = "Call successfully executed" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case "1":
                    {
                        GetResultDescRet = "File Not found" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case "2":
                    {
                        GetResultDescRet = "Invalid number of fields" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        GetResultDescRet = GetResultDescRet + "Check your SetDataPath call and make sure" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        GetResultDescRet = GetResultDescRet + "pastel files exist at that path" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        GetResultDescRet = GetResultDescRet + "Try and use directories less than 8 characters long" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case "3":
                    {
                        GetResultDescRet = "Record update not successful" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case "4":
                    {
                        GetResultDescRet = "Record insert not successful" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
                        break;
                    }

                case "5":
                    {
                        GetResultDescRet = "Record does not exist in file";
                        break;
                    }

                case "6":
                    {
                        GetResultDescRet = "Data path does not exist";
                        break;
                    }

                case "7":
                    {
                        GetResultDescRet = "Access denied";
                        break;
                    }

                case "9":
                    {
                        GetResultDescRet = "End of file";
                        break;
                    }

                case "10":
                    {
                        GetResultDescRet = "Field number specified not valid";
                        break;
                    }

                case "11":
                    {
                        GetResultDescRet = "Invalid period number (1 to 13)";
                        break;
                    }

                case "12":
                    {
                        GetResultDescRet = "Invalid Date";
                        break;
                    }

                case "13":
                    {
                        GetResultDescRet = "Invalid account type (GDC)";
                        break;
                    }

                case "14":
                    {
                        GetResultDescRet = "Invalid general ledger account number";
                        break;
                    }

                case "15":
                    {
                        GetResultDescRet = "General ledger account contains sub accounts";
                        break;
                    }

                case "16":
                    {
                        GetResultDescRet = "General ledger account number must be numeric";
                        break;
                    }

                case "17":
                    {
                        GetResultDescRet = "Invalid customer account code";
                        break;
                    }

                case "18":
                    {
                        GetResultDescRet = "Invalid supplier account code";
                        break;
                    }

                case "19":
                    {
                        GetResultDescRet = "Invalid inventory item code";
                        break;
                    }

                case "20":
                    {
                        GetResultDescRet = "Invalid salesman code";
                        break;
                    }

                case "21":
                    {
                        GetResultDescRet = "Invalid job code";
                        break;
                    }

                case "22":
                    {
                        GetResultDescRet = "Invalid Tax Type (0 to 30)";
                        break;
                    }

                case "23":
                    {
                        GetResultDescRet = "Transaction amount cannot be less that the tax amount";
                        break;
                    }

                case "24":
                    {
                        GetResultDescRet = "Invalid open item transaction type - must be O (Original) or A (Allocation)";
                        break;
                    }

                case "25":
                    {
                        GetResultDescRet = "There cannot be more than 500 lines in a batch";
                        break;
                    }

                case "26":
                    {
                        GetResultDescRet = "Invalid account description";
                        break;
                    }

                case "27":
                    {
                        GetResultDescRet = "Default group needs to set up in Pastel";
                        break;
                    }

                case "28":
                    {
                        GetResultDescRet = "Invalid document line type – must be 2, 5, or 7";
                        break;
                    }

                case "29":
                    {
                        GetResultDescRet = "Invalid exclusive / inclusive – must be 0 or 1";
                        break;
                    }

                case "30":
                    {
                        GetResultDescRet = "Invalid Entry Type (1 to 90)";
                        break;
                    }

                case "31":
                    {
                        GetResultDescRet = "Duplicate inventory item";
                        break;
                    }

                case "32":
                    {
                        GetResultDescRet = "Invalid multi-store code";
                        break;
                    }

                case "33":
                    {
                        GetResultDescRet = "Invalid Currency Code";
                        break;
                    }

                case "99":
                    {
                        GetResultDescRet = "General Error (the error message is the VB 5 error code and description)";
                        break;
                    }
            }

            return GetResultDescRet;
        }

        public string GetSerNum(string A)
        {
            string SerNum = default(string);
            SerNum = "DK198110007";
            return SerNum;
        }

        public string GetAuthCode(string A)
        {
            string Authcode = default(string);
            Authcode = "5635796";
            return Authcode;
        }

    }

}

