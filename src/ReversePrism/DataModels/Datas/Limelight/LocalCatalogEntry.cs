using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LabelCrc                                 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Checksum                                 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 Size                                     00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 Seed                                     00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 ResourceType                             0001865F4260 ModelPrimitiveType int int int Int32
    // 038 Dependencies                             000185B847E0 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    public partial class LocalCatalogEntry : DataModel
    {
        public ulong                                    LabelCrc                                { get; set; }
        public ulong                                    Checksum                                { get; set; }
        public ulong                                    Size                                    { get; set; }
        public ulong                                    Seed                                    { get; set; }
        public int                                      ResourceType                            { get; set; }
        public List<ulong>?                             Dependencies                            { get; set; }

        public static LocalCatalogEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalCatalogEntry() { Pointer= p0 };

            value.LabelCrc                                  = GetUInt64(new IntPtr(p + 0x010)); // 0245A3E1A310 0x10 LabelCrc                    ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x018)); // 0245A3E1A330 0x18 Checksum                    ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x020)); // 0245A3E1A350 0x20 Size                        ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x028)); // 0245A3E1A370 0x28 Seed                        ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x030)); // 0245A3E1A390 0x30 ResourceType                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Dependencies                              = GetUInt64List(new IntPtr(p + 0x038)); // 0245A3E1A3B0 0x38 Dependencies                ( 000185B847E0 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )

            return value;
        }
    }
}
