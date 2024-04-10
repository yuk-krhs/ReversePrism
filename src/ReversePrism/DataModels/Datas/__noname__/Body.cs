using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UniqueDownloadId                         0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Url                                      000186671BA0 ModelPrimitiveType string string string String
    // 020 Path                                     000186671BA0 ModelPrimitiveType string string string String
    // 028 Size                                     00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 Checksum                                 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 038 Strategy                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C Priority                                 0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.UniqueDownloadId                          = GetInt32(new IntPtr(p + 0x010)); // 02466B575620 0x10 UniqueDownloadId            ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 02466B575640 0x18 Url                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x020)); // 02466B575660 0x20 Path                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Size                                      = GetUInt64(new IntPtr(p + 0x028)); // 02466B575680 0x28 Size                        ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Checksum                                  = GetUInt64(new IntPtr(p + 0x030)); // 02466B5756A0 0x30 Checksum                    ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Strategy                                  = GetInt32(new IntPtr(p + 0x038)); // 02466B5756C0 0x38 Strategy                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x03C)); // 02466B5756E0 0x3C Priority                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
