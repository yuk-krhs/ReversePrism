using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Header                                   000186671910 ModelPrimitiveType string string string String
    // 018 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Pos                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 keywords                                 string[] IL2CPP_TYPE_SZARRAY
    // 020 Values                                   000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.Header                                    = GetString(new IntPtr(p + 0x010)); // 024667AB58D0 0x10 Header                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 024667AB58F0 0x18 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Pos                                       = GetInt32(new IntPtr(p + 0x01C)); // 024667AB5910 0x1C Pos                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Values                                    = GetStringList(new IntPtr(p + 0x020)); // 024667AB5950 0x20 Values                      ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
