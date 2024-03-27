using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Keys                                     000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 Values                                   000185B767E0 ModelClassListType ConfigurationEntry[] ConfigurationEntry[] List<ConfigurationEntry> Pointer
    public partial class SerializableProjectConfiguration
    {
        public List<string>?                            Keys                                    { get; set; }
        public List<ConfigurationEntry>?                Values                                  { get; set; }

        public static SerializableProjectConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializableProjectConfiguration();

            value.Keys                                      = GetStringList(new IntPtr(p + 0x010)); // 02700664C318 0x10 Keys                        ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Values                                    = GetObjectList<ConfigurationEntry>(new IntPtr(p + 0x018), ReversePrism.DataModels.ConfigurationEntry.FromPointer); // 02700664C338 0x18 Values                      ( 000185B767E0 ModelClassListType ConfigurationEntry[] ConfigurationEntry[] List<ConfigurationEntry> Pointer )

            return value;
        }
    }
}
