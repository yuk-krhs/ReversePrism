using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Keys                                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 Values                                   ModelClassListType ConfigurationEntry[] ConfigurationEntry[] List<ConfigurationEntry> Pointer
    public partial class SerializableProjectConfiguration : DataModel
    {
        public List<string>?                            Keys                                    { get; set; }
        public List<ConfigurationEntry>?                Values                                  { get; set; }

        public static SerializableProjectConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializableProjectConfiguration() { Pointer= p0 };

            value.Keys                                      = GetStringList(new IntPtr(p + 0x010)); // 0x10 Keys                        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Values                                    = GetObjectList<ConfigurationEntry>(new IntPtr(p + 0x018), ReversePrism.DataModels.ConfigurationEntry.FromPointer); // 0x18 Values                      ( ModelClassListType ConfigurationEntry[] ConfigurationEntry[] List<ConfigurationEntry> Pointer )

            return value;
        }
    }
}
