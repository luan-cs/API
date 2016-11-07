//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Security.Cryptography;
//using System.IO;
//using Microsoft.Win32;

//namespace VVPosM1.Common
//{
//    class KeyChecking
//    {
//        private string link = "http://vv-pos.net/vvcrm/keyChecking.php";
//        public bool checkLicense()
//        {
//            bool result = false;
//            try
//            {
//                //get hardware identifier
//                string ClientIdentifier = identifier();
//                //registry key name
//                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("software\\VietVangCRM");
//                string storedIdetifier = (string)rkey.GetValue("i", null); //base 64 encode of encrypted value of hardware sign
//                string storedKey = (string)rkey.GetValue("k", null); //base 64 encode of private key
//                string storedLicense = (string)rkey.GetValue("l", null);// base 64 encode of license key
//                if (storedIdetifier == null || storedKey == null || storedLicense == null) //not license
//                {
//                    if(storedLicense != null)
//                    {
//                        string key = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(storedLicense));
//                        if (getLicense(key)) result = true;
//                    }
//                }

//                else
//                {
//                    byte[] key = Convert.FromBase64String(storedKey);
//                    byte[] Identifi = Convert.FromBase64String(storedIdetifier);

//                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
//                    rsa.FromXmlString(System.Text.Encoding.Unicode.GetString(key));

//                    byte[] decryptData = rsa.Decrypt(Identifi, true);
//                    string storageIdentifier = System.Text.Encoding.Unicode.GetString(decryptData);

//                    if (storageIdentifier.Equals(ClientIdentifier))
//                    {
//                        result = true;
//                    }
//                }
//            }
//            catch { }

//            return result;
//        }

//        /*private string identifier(string wmiClass = "Win32_DiskDrive", string wmiProperty = "Signature")
//        //Return a hardware identifier
//        {
//            string result = "";
//            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
//            System.Management.ManagementObjectCollection moc = mc.GetInstances();
//            foreach (System.Management.ManagementObject mo in moc)
//            {
//                //Only get the first one
//                if (result == "")
//                {
//                    try
//                    {
//                        result = mo[wmiProperty].ToString();
//                        break;
//                    }
//                    catch
//                    {
//                    }
//                }
//            }
//            return result;
//        }*/

//        //regis a new license
//        public bool getLicense(string key, string email = null, string username = null, string phone = null)
//        {
//            if (!string.IsNullOrEmpty(link))
//            {
//                try
//                {
//                    key = System.Text.RegularExpressions.Regex.Replace(key, "_", "");
//                    string data = key + "$" + identifier();
//                    if (!string.IsNullOrEmpty(email)) data += "$" + email;
//                    if (!string.IsNullOrEmpty(username)) data += "$" + username;
//                    if (!string.IsNullOrEmpty(phone)) data += "$" + phone;

//                    data = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(data));

//                    string URL = link + "?data=" + data;
//                    System.Net.WebRequest request = System.Net.WebRequest.Create(URL);

//                    request.Timeout = 10000;

//                    System.Net.WebResponse response = request.GetResponse();

//                    string resultCheck = null;
//                    using (Stream stream = response.GetResponseStream())
//                    {
//                        StreamReader str = new StreamReader(stream);
//                        resultCheck = System.Text.Encoding.Default.GetString(Convert.FromBase64String(str.ReadToEnd()));
//                    }

//                    if (resultCheck.Equals("Accepted"))//license right
//                    {
//                        regisLicense(key);
//                        return true;
//                    }
//                    else return false;
//                }
//                catch
//                {
//                    return false;
//                }
//            }
//            else return false;

//        }

//        private void regisLicense(string key)
//        {
//            var cps = new RSACryptoServiceProvider(2048);
//            var pubKey = cps.ExportParameters(false);
//            var priKey = cps.ExportParameters(true);


//            string priKeyString;
//            {
//                var sw = new System.IO.StringWriter();
//                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
//                xs.Serialize(sw, priKey);
//                priKeyString = sw.ToString();
//                sw.Close();
//            }

//            string identifie = identifier();

//            cps.ImportParameters(pubKey);
//            byte[] encrpted = cps.Encrypt(System.Text.Encoding.Unicode.GetBytes(identifie), true);

//            //write to registry
//            string regisKey = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(priKeyString));
//            string regisIdentifier = Convert.ToBase64String(encrpted);
//            string regisLicense = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(key));

//            Microsoft.Win32.RegistryKey rKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\VietVangCRM");
//            rKey.SetValue("i", regisIdentifier, RegistryValueKind.String);
//            rKey.SetValue("k", regisKey, RegistryValueKind.String);
//            rKey.SetValue("l", regisLicense, RegistryValueKind.String);
//        }
//    }
//}
