using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Directory                                000186675150 ModelPrimitiveType string string string String
    // 018 FileName                                 000186675150 ModelPrimitiveType string string string String
    // 020 ReadSize                                 0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 ExtractSize                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 Offset                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 FileId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 UserStr                                  000186674750 ModelPrimitiveType string string string String
    public partial class ContentsFileInfo : DataModel
    {
        public string                                   Directory                               { get; set; }
        public string                                   FileName                                { get; set; }
        public uint                                     ReadSize                                { get; set; }
        public uint                                     ExtractSize                             { get; set; }
        public ulong                                    Offset                                  { get; set; }
        public int                                      FileId                                  { get; set; }
        public string                                   UserStr                                 { get; set; }

        public static ContentsFileInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentsFileInfo() { Pointer= p0 };

            value.Directory                                 = GetString(new IntPtr(p + 0x010)); // 02466AD1C9C8 0x10 Directory                   ( 000186675150 ModelPrimitiveType string string string String )
            value.FileName                                  = GetString(new IntPtr(p + 0x018)); // 02466AD1C9E8 0x18 FileName                    ( 000186675150 ModelPrimitiveType string string string String )
            value.ReadSize                                  = GetUInt32(new IntPtr(p + 0x020)); // 02466AD1CA08 0x20 ReadSize                    ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ExtractSize                               = GetUInt32(new IntPtr(p + 0x024)); // 02466AD1CA28 0x24 ExtractSize                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Offset                                    = GetUInt64(new IntPtr(p + 0x028)); // 02466AD1CA48 0x28 Offset                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.FileId                                    = GetInt32(new IntPtr(p + 0x030)); // 02466AD1CA68 0x30 FileId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UserStr                                   = GetString(new IntPtr(p + 0x038)); // 02466AD1CA88 0x38 UserStr                     ( 000186674750 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
