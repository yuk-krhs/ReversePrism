using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 rng                                      RandomNumberGenerator IL2CPP_TYPE_CLASS
    // 010 LastUse                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 Nc                                       ModelPrimitiveType int int int Int32
    // 020 Hash                                     ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer
    // 028 Parser                                   ModelClassType DigestHeaderParser DigestHeaderParser DigestHeaderParser Pointer
    // 030 Cnonce                                   ModelPrimitiveType string string string String
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

            value.LastUse                                   = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastUse                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Nc                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Nc                          ( ModelPrimitiveType int int int Int32 )
            value.Hash                                      = GetObject<HashAlgorithm>(new IntPtr(p + 0x020), ReversePrism.DataModels.HashAlgorithm.FromPointer); // 0x20 Hash                        ( ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer )
            value.Parser                                    = GetObject<DigestHeaderParser>(new IntPtr(p + 0x028), ReversePrism.DataModels.DigestHeaderParser.FromPointer); // 0x28 Parser                      ( ModelClassType DigestHeaderParser DigestHeaderParser DigestHeaderParser Pointer )
            value.Cnonce                                    = GetString(new IntPtr(p + 0x030)); // 0x30 Cnonce                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
