using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AcbPath                                  ModelPrimitiveType string string string String
    // 018 AwbPath                                  ModelPrimitiveType string string string String
    // 020 Handle                                   ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer
    // 028 SheetName                                ModelPrimitiveType string string string String
    // 030 RefCount                                 ModelPrimitiveType int int int Int32
    // 034 Loaded                                   ModelPrimitiveType bool bool bool Bool
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

            value.AcbPath                                   = GetString(new IntPtr(p + 0x010)); // 0x10 AcbPath                     ( ModelPrimitiveType string string string String )
            value.AwbPath                                   = GetString(new IntPtr(p + 0x018)); // 0x18 AwbPath                     ( ModelPrimitiveType string string string String )
            value.Handle                                    = GetObject<CriAtomExAcb>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExAcb.FromPointer); // 0x20 Handle                      ( ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer )
            value.SheetName                                 = GetString(new IntPtr(p + 0x028)); // 0x28 SheetName                   ( ModelPrimitiveType string string string String )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 RefCount                    ( ModelPrimitiveType int int int Int32 )
            value.Loaded                                    = GetBool(new IntPtr(p + 0x034)); // 0x34 Loaded                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
