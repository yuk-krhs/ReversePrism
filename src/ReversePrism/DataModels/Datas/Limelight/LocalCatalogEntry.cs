using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LabelCrc                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Checksum                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 Size                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 028 Seed                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 030 ResourceType                             ModelPrimitiveType int int int Int32
    // 038 Dependencies                             ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
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

            value.LabelCrc                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 LabelCrc                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Checksum                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x020)); // 0x20 Size                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x028)); // 0x28 Seed                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 ResourceType                ( ModelPrimitiveType int int int Int32 )
            value.Dependencies                              = GetUInt64List(new IntPtr(p + 0x038)); // 0x38 Dependencies                ( ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )

            return value;
        }
    }
}
