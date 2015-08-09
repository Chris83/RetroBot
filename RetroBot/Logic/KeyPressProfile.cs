using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using RetroBot.Messenger;

namespace RetroBot
{
    class KeyPressProfile
    {
        public const bool COMBINE_PRESS = true;
        public const bool DISTINCT_PRESS = false;

        public const int PRESS_PADDING = 15;

        private KeyPressInfo[] keys;

        // Default constructor.
        public KeyPressProfile()
        {
            Messenger<Key, KeyPressInfo>.AddListener("UpdateKeyPressInfo", UpdateKey);
            Messenger<string>.AddListener("SaveKPPFile", Serialize);
            Messenger<string>.AddListener("LoadKPPFile", Deserialize);

            Messenger<Key, int>.AddListener("KeyPressDelayChanged", UpdateDelay);
            Messenger<Key, bool>.AddListener("KeyPressSameKeysChanged", UpdateSameKeyAction);
            Messenger<Key, bool>.AddListener("KeyPressDifferentKeysChanged", UpdateDifferentKeyAction);
            Messenger<Key, bool>.AddListener("KeyPressScalingChanged", UpdateScaling);
            Messenger<Key, int>.AddListener("KeyPressScalingMinChanged", UpdateScalingMin);
            Messenger<Key, int>.AddListener("KeyPressScalingMaxChanged", UpdateScalingMax);

            keys = new KeyPressInfo[Enum.GetNames(typeof(Key)).Length];

            for (int i = 0; i < keys.Length; i++)
            {
                keys[i].DifferentKeyAction = COMBINE_PRESS;
                keys[i].SameKeyAction = DISTINCT_PRESS;
                keys[i].Delay = 25;
                keys[i].Scaling = false;
                keys[i].Min = 25;
                keys[i].Max = 1000;
            }
        }

        public KeyPressInfo GetInfo(Key key)
        {
            return keys[(int)key];
        }

        public void Serialize(string filename)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
            {
                // Add code here to save information.
                int numKeys = Enum.GetNames(typeof(Key)).Length;
                for (int i = 0; i < numKeys; i++)
                {
                    writer.Write(keys[i].DifferentKeyAction);
                    writer.Write(keys[i].SameKeyAction);
                    writer.Write(keys[i].Delay);
                    writer.Write(keys[i].Scaling);
                    writer.Write(keys[i].Min);
                    writer.Write(keys[i].Max);
                }
            }            
        }

        public void Deserialize(string filename)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                // Add code here to load file.
                int numKeys = Enum.GetNames(typeof(Key)).Length;
                for (int i = 0; i < numKeys; i++)
                {
                    keys[i].DifferentKeyAction = reader.ReadBoolean();
                    keys[i].SameKeyAction = reader.ReadBoolean();
                    keys[i].Delay = reader.ReadInt32();
                    keys[i].Scaling = reader.ReadBoolean();
                    keys[i].Min = reader.ReadInt32();
                    keys[i].Max = reader.ReadInt32();
                }                                
            }
            // Add code to push info to UI.
            Messenger<KeyPressInfo[]>.Broadcast("KPPFileLoaded", keys);
        }

        #region Listener Methods
        private void UpdateKey(Key key, KeyPressInfo info)
        {
            keys[(int)key] = info;
        }

        private void UpdateDelay(Key key, int delay)
        {
            keys[(int)key].Delay = delay;
        }

        private void UpdateSameKeyAction(Key key, bool skAction)
        {
            keys[(int)key].SameKeyAction = skAction;
        }

        private void UpdateDifferentKeyAction(Key key, bool dkAction)
        {
            keys[(int)key].DifferentKeyAction = dkAction;
        }

        private void UpdateScaling(Key key, bool scaling)
        {
            keys[(int)key].Scaling = scaling;
        }

        private void UpdateScalingMin(Key key, int min)
        {
            keys[(int)key].Min = min;
        }

        private void UpdateScalingMax(Key key, int max)
        {
            keys[(int)key].Max = max;
        }
        #endregion
    }
}
