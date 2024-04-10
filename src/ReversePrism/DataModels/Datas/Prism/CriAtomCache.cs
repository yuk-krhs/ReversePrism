using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AcbPath                                  000186671910 ModelPrimitiveType string string string String
    // 018 AwbPath                                  000186671910 ModelPrimitiveType string string string String
    // 020 Handle                                   000186645230 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer
    // 028 SheetName                                000186672F10 ModelPrimitiveType string string string String
    // 030 RefCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Loaded                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtomCache : DataModel
    {
        public string                                   AcbPath                                 { get; set; }
        public string                                   AwbPath                                 { get; set; }
        public CriAtomExAcb?                            Handle                                  { get; set; }
        public string                                   SheetName                               { get; set; }
        public int                                      RefCount                                { get; set; }
        public bool                                     Loaded                                  { get; set; }

        public static CriAtomCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomCache() { Pointer= p0 };

            value.AcbPath                                   = GetString(new IntPtr(p + 0x010)); // 0245A4235C28 0x10 AcbPath                     ( 000186671910 ModelPrimitiveType string string string String )
            value.AwbPath                                   = GetString(new IntPtr(p + 0x018)); // 0245A4235C48 0x18 AwbPath                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Handle                                    = GetObject<CriAtomExAcb>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExAcb.FromPointer); // 0245A4235C68 0x20 Handle                      ( 000186645230 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer )
            value.SheetName                                 = GetString(new IntPtr(p + 0x028)); // 0245A4235C88 0x28 SheetName                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x030)); // 0245A4235CA8 0x30 RefCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Loaded                                    = GetBool(new IntPtr(p + 0x034)); // 0245A4235CC8 0x34 Loaded                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
