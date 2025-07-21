using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Version> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 MajorFieldNumber                         int IL2CPP_TYPE_I4
    // 008 MajorDefaultValue                        int IL2CPP_TYPE_I4
    // 01C Major                                    ModelPrimitiveType int int int Int32
    // 000 MinorFieldNumber                         int IL2CPP_TYPE_I4
    // 00C MinorDefaultValue                        int IL2CPP_TYPE_I4
    // 020 Minor                                    ModelPrimitiveType int int int Int32
    // 000 PatchFieldNumber                         int IL2CPP_TYPE_I4
    // 010 PatchDefaultValue                        ModelPrimitiveType int int int Int32
    // 024 Patch                                    ModelPrimitiveType int int int Int32
    // 000 SuffixFieldNumber                        int IL2CPP_TYPE_I4
    // 018 SuffixDefaultValue                       ModelPrimitiveType string string string String
    // 028 Suffix                                   ModelPrimitiveType string string string String
    public partial class Version : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public int                                      Major                                   { get; set; }
        public int                                      Minor                                   { get; set; }
        public int                                      PatchDefaultValue                       { get; set; }
        public int                                      Patch                                   { get; set; }
        public string                                   SuffixDefaultValue                      { get; set; }
        public string                                   Suffix                                  { get; set; }

        public static Version? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Version() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Major                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Major                       ( ModelPrimitiveType int int int Int32 )
            value.Minor                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Minor                       ( ModelPrimitiveType int int int Int32 )
            value.PatchDefaultValue                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 PatchDefaultValue           ( ModelPrimitiveType int int int Int32 )
            value.Patch                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Patch                       ( ModelPrimitiveType int int int Int32 )
            value.SuffixDefaultValue                        = GetString(new IntPtr(p + 0x018)); // 0x18 SuffixDefaultValue          ( ModelPrimitiveType string string string String )
            value.Suffix                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Suffix                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
