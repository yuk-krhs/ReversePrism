using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Directory                                ModelPrimitiveType string string string String
    // 018 FileName                                 ModelPrimitiveType string string string String
    // 020 ReadSize                                 ModelPrimitiveType uint uint uint UInt32
    // 024 ExtractSize                              ModelPrimitiveType uint uint uint UInt32
    // 028 Offset                                   ModelPrimitiveType ulong ulong ulong UInt64
    // 030 FileId                                   ModelPrimitiveType int int int Int32
    // 038 UserStr                                  ModelPrimitiveType string string string String
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

            value.Directory                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Directory                   ( ModelPrimitiveType string string string String )
            value.FileName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 FileName                    ( ModelPrimitiveType string string string String )
            value.ReadSize                                  = GetUInt32(new IntPtr(p + 0x020)); // 0x20 ReadSize                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.ExtractSize                               = GetUInt32(new IntPtr(p + 0x024)); // 0x24 ExtractSize                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.Offset                                    = GetUInt64(new IntPtr(p + 0x028)); // 0x28 Offset                      ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.FileId                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 FileId                      ( ModelPrimitiveType int int int Int32 )
            value.UserStr                                   = GetString(new IntPtr(p + 0x038)); // 0x38 UserStr                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
