using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 rng                                      RandomNumberGenerator IL2CPP_TYPE_CLASS
    // 010 LastUse                                  0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 Nc                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Hash                                     0001866A8DA0 ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer
    // 028 Parser                                   0001866D43C0 ModelClassType DigestHeaderParser DigestHeaderParser DigestHeaderParser Pointer
    // 030 Cnonce                                   000186671910 ModelPrimitiveType string string string String
    public partial class DigestSession : DataModel
    {
        public DateTime                                 LastUse                                 { get; set; }
        public int                                      Nc                                      { get; set; }
        public HashAlgorithm?                           Hash                                    { get; set; }
        public DigestHeaderParser?                      Parser                                  { get; set; }
        public string                                   Cnonce                                  { get; set; }

        public static DigestSession? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DigestSession() { Pointer= p0 };

            value.LastUse                                   = GetDateTime(new IntPtr(p + 0x010)); // 024667AB5E90 0x10 LastUse                     ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Nc                                        = GetInt32(new IntPtr(p + 0x018)); // 024667AB5EB0 0x18 Nc                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Hash                                      = GetObject<HashAlgorithm>(new IntPtr(p + 0x020), ReversePrism.DataModels.HashAlgorithm.FromPointer); // 024667AB5ED0 0x20 Hash                        ( 0001866A8DA0 ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer )
            value.Parser                                    = GetObject<DigestHeaderParser>(new IntPtr(p + 0x028), ReversePrism.DataModels.DigestHeaderParser.FromPointer); // 024667AB5EF0 0x28 Parser                      ( 0001866D43C0 ModelClassType DigestHeaderParser DigestHeaderParser DigestHeaderParser Pointer )
            value.Cnonce                                    = GetString(new IntPtr(p + 0x030)); // 024667AB5F10 0x30 Cnonce                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
