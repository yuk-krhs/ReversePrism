using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Filename                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 FileSize                                 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class ArchiveFileInfo
    {
        public string                                   Filename                                { get; set; }
        public ulong                                    FileSize                                { get; set; }

        public static ArchiveFileInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArchiveFileInfo();

            value.Filename                                  = GetString(new IntPtr(p + 0x010)); // 0270022F3468 0x10 Filename                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FileSize                                  = GetUInt64(new IntPtr(p + 0x018)); // 0270022F3488 0x18 FileSize                    ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
