using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace RolePlay_Notes
{
    public class RPN_API_Web
    {

        // HTTPS IS VERY IMPORT (but not required) TO ENCRYPT POST DATA (=> USERNAME AND PASSWORD etc)
        // You need to change this URL when you init your project
        public static string BaseURL = null;

        public enum Permission
        {
            Unknown = -1, Min = 0, Med = 1, Max = 2
        }

        private string db_username, db_password, db_group;

        public RPN_API_Web(string db_username, string db_password, string db_group)
        {
            this.db_username = db_username;
            this.db_password = db_password;
            this.db_group = db_group;
        }

        private NameValueCollection GetLoginPost()
        {
            NameValueCollection data = new NameValueCollection();
            data.Set("username", db_username);
            data.Set("password", db_password);
            data.Set("group", db_group);
            return data;
        }

        /* Utils*/
        public string ImageToBase64(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public Image Base64ToImage(string baseImage)
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(baseImage)))
            {
                return Image.FromStream(ms);
            }
        }
        /* END Utils */

        /* API INFO */
        public string GetUsername()
        {
            return db_username;
        }

        public string GetGroup()
        {
            return db_group;
        }
        /* END API INFO */

        /* Internal */
        public bool Login()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();

                byte[] response = wb.UploadValues(BaseURL + "login.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }


        public Permission GetPermission(string username)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "internal.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.InternalJSON data = JsonConvert.DeserializeObject<RPN_API_Json.InternalJSON>(responseInString);

                foreach (RPN_API_Json.InternalData internalData in data.Data)
                {
                    if (internalData.Username.Equals(username))
                    {
                        if (internalData.Permission.Equals("max"))
                            return Permission.Max;
                        if (internalData.Permission.Equals("med"))
                            return Permission.Med;
                        if (internalData.Permission.Equals("min"))
                            return Permission.Min;
                    }
                }
                return Permission.Unknown;
            }
        }

        public List<RPN_API_Json.InternalData> GetAllUsers()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "internal.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.InternalJSON data = JsonConvert.DeserializeObject<RPN_API_Json.InternalJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.InternalData GetUser(string username)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "getfromusername");
                defaultPost.Set("targetuser", username);

                byte[] response = wb.UploadValues(BaseURL + "internal.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.InternalJSON data = JsonConvert.DeserializeObject<RPN_API_Json.InternalJSON>(responseInString);

                foreach (RPN_API_Json.InternalData internalData in data.Data)
                    if (internalData.Username.Equals(username))
                        return internalData;

                return null;
            }
        }


        public bool CreateUser(string username, string password, int renseignementid, Permission permission)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "add");
                defaultPost.Set("newuser", username);
                defaultPost.Set("newpass", password);
                defaultPost.Set("renseignementid", renseignementid.ToString());

                if (permission == Permission.Max)
                {
                    defaultPost.Set("permission", "max");
                }
                else if (permission == Permission.Med)
                {
                    defaultPost.Set("permission", "med");
                }
                else if (permission == Permission.Min)
                {
                    defaultPost.Set("permission", "min");
                }

                byte[] response = wb.UploadValues(BaseURL + "internal.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        /// <summary>
        /// Set password to null if you don't want to update the password
        /// </summary>
        public bool EditUser(string username, string password, int renseignementid, Permission permission)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "edit");
                defaultPost.Set("newuser", username);
                if (password != null)
                    defaultPost.Set("newpass", password);
                defaultPost.Set("renseignementid", renseignementid.ToString());

                if (permission == Permission.Max)
                {
                    defaultPost.Set("permission", "max");
                }
                else if (permission == Permission.Med)
                {
                    defaultPost.Set("permission", "med");
                }
                else if (permission == Permission.Min)
                {
                    defaultPost.Set("permission", "min");
                }

                byte[] response = wb.UploadValues(BaseURL + "internal.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public bool DeleteUser(string username)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "del");
                defaultPost.Set("targetuser", username);

                byte[] response = wb.UploadValues(BaseURL + "internal.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }
        /* END Internal */

        /* Relation */
        public List<RPN_API_Json.RelationData> GetAllRelations()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "relation.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.RelationJSON data = JsonConvert.DeserializeObject<RPN_API_Json.RelationJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.RelationData GetRelation(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "getfromid");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "relation.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.RelationJSON data = JsonConvert.DeserializeObject<RPN_API_Json.RelationJSON>(responseInString);

                return data.Data[0];
            }
        }

        public bool EditRelation(int id, string name, string behaviour, string strength, string type,
            string financial_situation, int headcount, string info)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "edit");
                defaultPost.Set("id", id.ToString());
                defaultPost.Set("name", name);
                defaultPost.Set("behaviour", behaviour);
                defaultPost.Set("strength", strength);
                defaultPost.Set("type", type);
                defaultPost.Set("financial_situation", financial_situation);
                defaultPost.Set("headcount", headcount.ToString());
                defaultPost.Set("info", info);

                byte[] response = wb.UploadValues(BaseURL + "relation.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public bool CreateRelation(string name, string behaviour, string strength, string type,
            string financial_situation, int headcount, string info)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "add");
                defaultPost.Set("name", name);
                defaultPost.Set("behaviour", behaviour);
                defaultPost.Set("strength", strength);
                defaultPost.Set("type", type);
                defaultPost.Set("financial_situation", financial_situation);
                defaultPost.Set("headcount", headcount.ToString());
                defaultPost.Set("info", info);

                byte[] response = wb.UploadValues(BaseURL + "relation.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);
                Console.WriteLine(responseInString);

                return responseInString.Equals("Success");
            }
        }

        public bool DeleteRelation(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "del");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "relation.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }
        /* END Relation */

        /* Money */
        public List<RPN_API_Json.MoneyData> GetAllMoney()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "money.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.MoneyJSON data = JsonConvert.DeserializeObject<RPN_API_Json.MoneyJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.MoneyData GetMoney(string username)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "getfromusername");
                defaultPost.Set("targetuser", username);

                byte[] response = wb.UploadValues(BaseURL + "money.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.MoneyJSON data = JsonConvert.DeserializeObject<RPN_API_Json.MoneyJSON>(responseInString);

                return data.Data[0];
            }
        }

        /// <summary>
        /// type should be perso (for personnal money) or group (for group money)
        /// </summary>
        public bool EditMoney(string username, int money, string type)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "edit");
                defaultPost.Set("targetuser", username);
                defaultPost.Set("money", money.ToString());
                defaultPost.Set("type", type.ToLower());

                byte[] response = wb.UploadValues(BaseURL + "money.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }
        /* END Relation */

        /* Renseignement */
        public List<RPN_API_Json.RenseignementData> GetRenseignements(bool full)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                if (full)
                    defaultPost.Set("action", "getfull");
                else
                    defaultPost.Set("action", "getlite");

                byte[] response = wb.UploadValues(BaseURL + "renseignement.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.RenseignementJSON data = JsonConvert.DeserializeObject<RPN_API_Json.RenseignementJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.RenseignementData GetRenseignement(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "getfromid");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "renseignement.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.RenseignementJSON data = JsonConvert.DeserializeObject<RPN_API_Json.RenseignementJSON>(responseInString);

                return data.Data[0];
            }
        }

        /// <summary>
        /// To not filter the date, simply pass the min_last_edit_date argument to DateTime.Min
        /// </summary>
        public List<RPN_API_Json.RenseignementData> SearchRenseignement(string nickname, string name, string pseudo, string tel,
            string affiliation, string old_affiliation, string position, string license_plate, string known_vehicle,
            string financial_situation, string behaviour, string dead_boolean, string wanted_boolean, string fake_nickname,
            string fake_name, DateTime min_last_edit_date)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "search");

                if (!string.IsNullOrEmpty(nickname))
                    defaultPost.Set("nickname", nickname);
                if (!string.IsNullOrEmpty(name))
                    defaultPost.Set("name", name);
                if (!string.IsNullOrEmpty(pseudo))
                    defaultPost.Set("pseudo", pseudo);
                if (!string.IsNullOrEmpty(tel))
                    defaultPost.Set("tel", tel);
                if (!string.IsNullOrEmpty(affiliation))
                    defaultPost.Set("affiliation", affiliation);
                if (!string.IsNullOrEmpty(old_affiliation))
                    defaultPost.Set("old_affiliation", old_affiliation);
                if (!string.IsNullOrEmpty(position))
                    defaultPost.Set("position", position);
                if (!string.IsNullOrEmpty(license_plate))
                    defaultPost.Set("license_plate", license_plate);
                if (!string.IsNullOrEmpty(known_vehicle))
                    defaultPost.Set("known_vehicle", known_vehicle);
                if (!string.IsNullOrEmpty(financial_situation))
                    defaultPost.Set("financial_situation", financial_situation);
                if (!string.IsNullOrEmpty(behaviour))
                    defaultPost.Set("behaviour", behaviour);

                if (!string.IsNullOrEmpty(dead_boolean))
                    defaultPost.Set("dead", (bool.Parse(dead_boolean) ? 1 : 0).ToString());
                if (!string.IsNullOrEmpty(wanted_boolean))
                    defaultPost.Set("wanted", (bool.Parse(wanted_boolean) ? 1 : 0).ToString());

                if (!string.IsNullOrEmpty(fake_nickname))
                    defaultPost.Set("fake_nickname", fake_nickname);
                if (!string.IsNullOrEmpty(fake_name))
                    defaultPost.Set("fake_name", fake_name);

                if (min_last_edit_date != null && min_last_edit_date != DateTime.MinValue)
                    defaultPost.Set("min_last_edit_date", min_last_edit_date.ToString("yyyy-MM-dd HH:mm:ss"));


                byte[] response = wb.UploadValues(BaseURL + "renseignement.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.RenseignementJSON data = JsonConvert.DeserializeObject<RPN_API_Json.RenseignementJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        /// <summary>
        /// If a string has to be null in the database you have to send a null value.
        /// </summary>
        public bool CreateRenseignement(string nickname, string name, string pseudo, string tel,
            string affiliation, string old_affiliation, string position, string license_plate, string known_vehicle,
            string financial_situation, string behaviour, string info, string info_hrp, bool dead, bool wanted,
            DateTime wanted_since, string fake_nickname, string fake_name)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "add");

                if (!string.IsNullOrEmpty(nickname))
                    defaultPost.Set("nickname", nickname);
                if (!string.IsNullOrEmpty(name))
                    defaultPost.Set("name", name);
                if (!string.IsNullOrEmpty(pseudo))
                    defaultPost.Set("pseudo", pseudo);
                if (!string.IsNullOrEmpty(tel))
                    defaultPost.Set("tel", tel);
                if (!string.IsNullOrEmpty(affiliation))
                    defaultPost.Set("affiliation", affiliation);
                if (!string.IsNullOrEmpty(old_affiliation))
                    defaultPost.Set("old_affiliation", old_affiliation);
                if (!string.IsNullOrEmpty(position))
                    defaultPost.Set("position", position);
                if (!string.IsNullOrEmpty(license_plate))
                    defaultPost.Set("license_plate", license_plate);
                if (!string.IsNullOrEmpty(known_vehicle))
                    defaultPost.Set("known_vehicle", known_vehicle);
                if (!string.IsNullOrEmpty(financial_situation))
                    defaultPost.Set("financial_situation", financial_situation);
                if (!string.IsNullOrEmpty(behaviour))
                    defaultPost.Set("behaviour", behaviour);
                if (!string.IsNullOrEmpty(info))
                    defaultPost.Set("info", info);
                if (!string.IsNullOrEmpty(info_hrp))
                    defaultPost.Set("info_hrp", info_hrp);
                defaultPost.Set("dead", (dead ? 1 : 0).ToString());
                defaultPost.Set("wanted", (wanted ? 1 : 0).ToString());

                if (wanted)
                    defaultPost.Set("wanted_since", wanted_since.ToString("yyyy-MM-dd HH:mm:ss"));
                else
                {
                    DateTime dateTime = new DateTime(2000, 1, 1);
                    defaultPost.Set("wanted_since", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                }

                if (!string.IsNullOrEmpty(fake_nickname))
                    defaultPost.Set("fake_nickname", fake_nickname);
                if (!string.IsNullOrEmpty(fake_name))
                    defaultPost.Set("fake_name", fake_name);

                byte[] response = wb.UploadValues(BaseURL + "renseignement.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        /// <summary>
        /// If a string has to be null in the database you have to send a null value.
        /// </summary>
        public bool EditRenseignement(int id, string nickname, string name, string pseudo, string tel,
            string affiliation, string old_affiliation, string position, string license_plate, string known_vehicle,
            string financial_situation, string behaviour, string info, string info_hrp, bool dead, bool wanted,
            DateTime wanted_since, string fake_nickname, string fake_name)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "edit");

                if (id != -1)
                    defaultPost.Set("id", id.ToString());
                else
                    return false;

                if (!string.IsNullOrEmpty(nickname))
                    defaultPost.Set("nickname", nickname);
                if (!string.IsNullOrEmpty(name))
                    defaultPost.Set("name", name);
                if (!string.IsNullOrEmpty(pseudo))
                    defaultPost.Set("pseudo", pseudo);
                if (!string.IsNullOrEmpty(tel))
                    defaultPost.Set("tel", tel);
                if (!string.IsNullOrEmpty(affiliation))
                    defaultPost.Set("affiliation", affiliation);
                if (!string.IsNullOrEmpty(old_affiliation))
                    defaultPost.Set("old_affiliation", old_affiliation);
                if (!string.IsNullOrEmpty(position))
                    defaultPost.Set("position", position);
                if (!string.IsNullOrEmpty(license_plate))
                    defaultPost.Set("license_plate", license_plate);
                if (!string.IsNullOrEmpty(known_vehicle))
                    defaultPost.Set("known_vehicle", known_vehicle);
                if (!string.IsNullOrEmpty(financial_situation))
                    defaultPost.Set("financial_situation", financial_situation);
                if (!string.IsNullOrEmpty(behaviour))
                    defaultPost.Set("behaviour", behaviour);
                if (!string.IsNullOrEmpty(info))
                    defaultPost.Set("info", info);
                if (!string.IsNullOrEmpty(info_hrp))
                    defaultPost.Set("info_hrp", info_hrp);
                defaultPost.Set("dead", (dead ? 1 : 0).ToString());
                defaultPost.Set("wanted", (wanted ? 1 : 0).ToString());

                if (wanted)
                    defaultPost.Set("wanted_since", wanted_since.ToString("yyyy-MM-dd HH:mm:ss"));
                else
                {
                    DateTime dateTime = new DateTime(2000, 1, 1);
                    defaultPost.Set("wanted_since", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                }

                if (!string.IsNullOrEmpty(fake_nickname))
                    defaultPost.Set("fake_nickname", fake_nickname);
                if (!string.IsNullOrEmpty(fake_name))
                    defaultPost.Set("fake_name", fake_name);

                byte[] response = wb.UploadValues(BaseURL + "renseignement.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public bool DeleteRenseignements(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("action", "del");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "renseignement.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }
        /* END Renseignement */


        /* RessourceType */
        public bool CreateRessourceType(string name, int mass, int price, Image baseIcon)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "ressource_type");
                defaultPost.Set("action", "add");
                defaultPost.Set("name", name);
                defaultPost.Set("mass", mass.ToString());
                defaultPost.Set("price", price.ToString());
                if (baseIcon != null)
                    defaultPost.Set("icon", ImageToBase64(baseIcon));

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public bool EditRessourceType(int id, string name, int mass, int price, Image baseIcon)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "ressource_type");
                defaultPost.Set("action", "edit");
                defaultPost.Set("id", id.ToString());
                defaultPost.Set("name", name);
                defaultPost.Set("mass", mass.ToString());
                defaultPost.Set("price", price.ToString());
                if (baseIcon != null)
                    defaultPost.Set("icon", ImageToBase64(baseIcon));

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public List<RPN_API_Json.RessourceTypeData> GetRessourceType()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "ressource_type");
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.RessourceTypeJSON data = JsonConvert.DeserializeObject<RPN_API_Json.RessourceTypeJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.RessourceTypeData GetRessourceTypeFromId(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "ressource_type");
                defaultPost.Set("action", "getfromid");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.RessourceTypeJSON data = JsonConvert.DeserializeObject<RPN_API_Json.RessourceTypeJSON>(responseInString);

                return data.Data[0];
            }
        }

        public bool DeleteRessourceType(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "ressource_type");
                defaultPost.Set("action", "del");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        /* END RessourceType */

        /* StorageType */
        public bool CreateStorageType(string name, int size)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_type");
                defaultPost.Set("action", "add");
                defaultPost.Set("name", name);
                defaultPost.Set("size", size.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public bool EditStorageType(int id, string name, int size)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_type");
                defaultPost.Set("action", "edit");
                defaultPost.Set("id", id.ToString());
                defaultPost.Set("name", name);
                defaultPost.Set("size", size.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public List<RPN_API_Json.StorageTypeData> GetStorageType()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_type");
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.StorageTypeJSON data = JsonConvert.DeserializeObject<RPN_API_Json.StorageTypeJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.StorageTypeData GetStorageTypeFromId(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_type");
                defaultPost.Set("action", "getfromid");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.StorageTypeJSON data = JsonConvert.DeserializeObject<RPN_API_Json.StorageTypeJSON>(responseInString);

                return data.Data[0];
            }
        }

        public bool DeleteStorageType(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_type");
                defaultPost.Set("action", "del");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }
        /* END StorageType */

        /* StorageData */
        public bool CreateStorageData(int ressource_type, int quantity, string belongto, int storage_id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_data");
                defaultPost.Set("action", "add");

                defaultPost.Set("ressource_type_id", ressource_type.ToString());
                defaultPost.Set("quantity", quantity.ToString());
                defaultPost.Set("belongto", belongto);
                defaultPost.Set("storage_id", storage_id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public bool EditStorageData(int id, int ressource_type, int quantity, string belongto, int storage_id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_data");
                defaultPost.Set("action", "edit");

                defaultPost.Set("id", id.ToString());
                defaultPost.Set("ressource_type_id", ressource_type.ToString());
                defaultPost.Set("quantity", quantity.ToString());
                defaultPost.Set("belongto", belongto);
                defaultPost.Set("storage_id", storage_id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public List<RPN_API_Json.StorageData> GetStorageData()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_data");
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.StorageDataJSON data = JsonConvert.DeserializeObject<RPN_API_Json.StorageDataJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public List<RPN_API_Json.StorageData> GetStorageDataFromStorageId(int storage_id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_data");
                defaultPost.Set("action", "getfromstorageid");

                defaultPost.Set("storage_id", storage_id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.StorageDataJSON data = JsonConvert.DeserializeObject<RPN_API_Json.StorageDataJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.StorageData GetStorageDataFromId(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_data");
                defaultPost.Set("action", "getfromid");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.StorageDataJSON data = JsonConvert.DeserializeObject<RPN_API_Json.StorageDataJSON>(responseInString);

                return data.Data[0];
            }
        }

        public bool DeleteStorageData(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage_data");
                defaultPost.Set("action", "del");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }
        /* END StorageData */


        /* Storage */
        public bool CreateStorage(string name, string owner, int storage_type_id, string location)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage");
                defaultPost.Set("action", "add");

                defaultPost.Set("owner", owner);
                defaultPost.Set("name", name);
                defaultPost.Set("storage_type", storage_type_id.ToString());
                defaultPost.Set("location", location);

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public bool EditStorage(int id, string name, string owner, int storage_type_id, string location)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage");
                defaultPost.Set("action", "edit");
                defaultPost.Set("id", id.ToString());

                defaultPost.Set("owner", owner);
                defaultPost.Set("name", name);
                defaultPost.Set("storage_type", storage_type_id.ToString());
                defaultPost.Set("location", location);

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }

        public List<RPN_API_Json.Storage> GetStorages()
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage");
                defaultPost.Set("action", "get");

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                if (response == null) // skip list creation
                    return null;
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.StorageJSON data = JsonConvert.DeserializeObject<RPN_API_Json.StorageJSON>(responseInString);

                return data.Data.ToList();
            }
        }

        public RPN_API_Json.Storage GetStorageFromId(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage");
                defaultPost.Set("action", "getfromid");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                // Convert to C# Class typed object
                RPN_API_Json.StorageJSON data = JsonConvert.DeserializeObject<RPN_API_Json.StorageJSON>(responseInString);

                return data.Data[0];
            }
        }

        public bool DeleteStorage(int id)
        {
            using (WebClient wb = new WebClient())
            {
                NameValueCollection defaultPost = GetLoginPost();
                defaultPost.Set("type", "storage");
                defaultPost.Set("action", "del");
                defaultPost.Set("id", id.ToString());

                byte[] response = wb.UploadValues(BaseURL + "storage.php", "POST", defaultPost);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString.Equals("Success");
            }
        }
        /* END Storage */
    }
}