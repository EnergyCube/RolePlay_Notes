using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RolePlay_Notes
{
    public class RPN_API_Json
    {
        /* Internal */
        public class InternalData
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("renseignementid")]
            public int RenseignementID { get; set; }

            [JsonProperty("permission")]
            public string Permission { get; set; }


            [JsonProperty("money")]
            public int Money { get; set; }
        }

        public class InternalJSON
        {
            [JsonProperty("data")]
            public IList<InternalData> Data { get; set; }
        }
        /* END Internal */

        /* Money */
        public class MoneyData
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("money_perso")]
            public int MoneyPerso { get; set; }

            [JsonProperty("money_group")]
            public int MoneyGroup { get; set; }

            [JsonProperty("renseignementid")]
            public int RenseignementID { get; set; }
        }

        public class MoneyJSON
        {
            [JsonProperty("data")]
            public IList<MoneyData> Data { get; set; }
        }
        /* END Money */

        /* Relation */
        public class RelationData
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("behaviour")]
            public string Behaviour { get; set; }

            [JsonProperty("strength")]
            public string Strength { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("financial_situation")]
            public string FinancialSituation { get; set; }

            [JsonProperty("headcount")]
            public int Headcount { get; set; }

            [JsonProperty("info")]
            public string Info { get; set; }
        }

        public class RelationJSON
        {
            [JsonProperty("data")]
            public IList<RelationData> Data { get; set; }
        }
        /* END Relation */

        /* Renseignement */
        public class RenseignementData
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("nickname")]
            public string Nickname { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("pseudo")]
            public string Pseudo { get; set; }

            [JsonProperty("tel")]
            public string Tel { get; set; }

            [JsonProperty("affiliation")]
            public string Affiliation { get; set; }

            [JsonProperty("old_affiliation")]
            public string OldAffiliation { get; set; }

            [JsonProperty("position")]
            public string Position { get; set; }

            [JsonProperty("license_plate")]
            public string LicensePlate { get; set; }

            [JsonProperty("known_vehicle")]
            public string KnownVehicle { get; set; }

            [JsonProperty("financial_situation")]
            public string FinancialSituation { get; set; }

            [JsonProperty("behaviour")]
            public string Behaviour { get; set; }

            [JsonProperty("info")]
            public string Info { get; set; }

            [JsonProperty("info_hrp")]
            public string InfoHrp { get; set; }

            [JsonProperty("dead")]
            public bool Dead { get; set; }

            [JsonProperty("wanted")]
            public bool Wanted { get; set; }

            [JsonProperty("wanted_since")]
            public DateTime WantedSince { get; set; }

            [JsonProperty("fake_nickname")]
            public string FakeNickname { get; set; }

            [JsonProperty("fake_name")]
            public string FakeName { get; set; }

            [JsonProperty("last_edit_date")]
            public DateTime LastEditDate { get; set; }

            [JsonProperty("last_edit_by")]
            public string LastEditBy { get; set; }
        }

        public class RenseignementJSON
        {

            [JsonProperty("data")]
            public IList<RenseignementData> Data { get; set; }
        }
        /* END Renseignement */

        /* Storage */
        public class RessourceTypeData
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("mass")]
            public int Mass { get; set; }

            [JsonProperty("price")]
            public int Price { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }

        public class RessourceTypeJSON
        {
            [JsonProperty("data")]
            public IList<RessourceTypeData> Data { get; set; }
        }

        public class StorageTypeData
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("size")]
            public int Size { get; set; }

            [JsonProperty("storage_id")]
            public int StorageId { get; set; }
        }

        public class StorageTypeJSON
        {
            [JsonProperty("data")]
            public IList<StorageTypeData> Data { get; set; }
        }

        public class Storage
        {

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("owner")]
            public string Owner { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("storage_type_id")]
            public int StorageTypeId { get; set; }

            [JsonProperty("location")]
            public string Location { get; set; }
        }

        public class StorageJSON
        {

            [JsonProperty("data")]
            public IList<Storage> Data { get; set; }
        }

        public class StorageData
        {

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("ressource_type_id")]
            public int RessourceType { get; set; }

            [JsonProperty("quantity")]
            public int Quantity { get; set; }

            [JsonProperty("belongto")]
            public string BelongTo { get; set; }

            [JsonProperty("storage_id")]
            public int StorageId { get; set; }
        }

        public class StorageDataJSON
        {

            [JsonProperty("data")]
            public IList<StorageData> Data { get; set; }
        }
        /* END Storage */
    }
}
