﻿using System.Collections.Generic;

namespace CW.Backend.Service.Authentication.Models
{
    public class ProfileDb
    {
        public static List<Profile> GetGata()
        {
            var data = new List<Profile>();
            for (int i = 0; i < 3; i++)
            {
                data.Add(new Profile() { Id = "id" + i, ProfileType = "Type_" + i,Address = "Address_"+i,ItemSoldPurchased = i});
            }
            return data;

        }

        public static bool SaveProfile(RegisterBindingModel model)
        {
            return true;

        }
    }
}