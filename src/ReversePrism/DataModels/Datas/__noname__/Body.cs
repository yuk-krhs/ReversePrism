using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UniqueDownloadId                         ModelPrimitiveType int int int Int32
    // 018 Url                                      ModelPrimitiveType string string string String
    // 020 Path                                     ModelPrimitiveType string string string String
    // 028 Size                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 030 Checksum                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 038 Strategy                                 ModelPrimitiveType int int int Int32
    // 03C Priority                                 ModelPrimitiveType int int int Int32
    public partial class Body : DataModel
    {
        public int                                      UniqueDownloadId                        { get; set; }
        public string                                   Url                                     { get; set; }
        public string                                   Path                                    { get; set; }
        public ulong                                    Size                                    { get; set; }
        public ulong                                    Checksum                                { get; set; }
        public int                                      Strategy                                { get; set; }
        public int                                      Priority                                { get; set; }

        public static Body? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Body() { Pointer= p0 };

            value.UniqueDownloadId                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 UniqueDownloadId            ( ModelPrimitiveType int int int Int32 )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Url                         ( ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Path                        ( ModelPrimitiveType string string string String )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x028)); // 0x28 Size                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x030)); // 0x30 Checksum                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Strategy                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 Strategy                    ( ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Priority                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
