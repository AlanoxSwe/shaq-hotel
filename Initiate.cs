using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ShaqHotel
{
    class Initiate
    {
        private string subkey;
        private RegistryKey key;

        public Initiate(string subkey)
        {
            this.subkey = subkey;
            key = Registry.CurrentUser.OpenSubKey(subkey, true);
        }

        public bool KeyExists()
        {
            
            if (key != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Initiated()
        {
            if (key != null)
            {
                if (key.GetValue("Initiated").ToString().Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public void CreateKey()
        {
            RegistryKey keys = Registry.CurrentUser.CreateSubKey(subkey);
            keys.SetValue("Initiated", "true");
            keys.Close();
        }

        public void SetKey(bool status)
        {
            //Set to true
            key.SetValue("Initiated", "true");
            key.Close();
        }

        public void DeleteKey()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(subkey, true);
            /*if (key != null)
            {*/
            Registry.CurrentUser.DeleteSubKeyTree(subkey);
            //}
        }

        public void CheckFirstTimeUse()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(subkey, true);
            if (key != null)
            {
                //Exists
                if (!key.GetValue("Initiated").ToString().Equals("true"))
                {
                    //Set to true
                    key.SetValue("Initiated", "true");
                    key.Close();
                }
            }
            else
            {
                //Doesn't exist, create
                HotelInitiate hotelInitiate = new HotelInitiate();
                hotelInitiate.ShowDialog();
                RegistryKey keys = Registry.CurrentUser.CreateSubKey(subkey);
                keys.SetValue("Initiated", "true");
                keys.Close();
            }

        }
    }
}
