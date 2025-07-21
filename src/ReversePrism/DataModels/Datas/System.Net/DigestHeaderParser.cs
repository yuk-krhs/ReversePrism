using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Header                                   ModelPrimitiveType string string string String
    // 018 Length                                   ModelPrimitiveType int int int Int32
    // 01C Pos                                      ModelPrimitiveType int int int Int32
    // 000 keywords                                 string[] IL2CPP_TYPE_SZARRAY
    // 020 Values                                   ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class DigestHeaderParser : DataModel
    {
        public string                                   Header                                  { get; set; }
        public int                                      Length                                  { get; set; }
        public int                                      Pos                                     { get; set; }
        public List<string>?                            Values                                  { get; set; }

        public static DigestHeaderParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DigestHeaderParser() { Pointer= p0 };

            value.Header                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Header                      ( ModelPrimitiveType string string string String )
            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Length                      ( ModelPrimitiveType int int int Int32 )
            value.Pos                                       = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Pos                         ( ModelPrimitiveType int int int Int32 )
            value.Values                                    = GetStringList(new IntPtr(p + 0x020)); // 0x20 Values                      ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
