using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 AcbFile                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 AwbFile                                  0001866722E0 ModelPrimitiveType string string string String
    // 028 Acb                                      0001866454D0 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer
    // 030 LoaderStatus                             000186545850 ModelEnumType Status Status Status Int32
    public partial class CriAtomCueSheet : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   AcbFile                                 { get; set; }
        public string                                   AwbFile                                 { get; set; }
        public CriAtomExAcb?                            Acb                                     { get; set; }
        public Status                                   LoaderStatus                            { get; set; }

        public static CriAtomCueSheet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomCueSheet() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024661816AB8 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AcbFile                                   = GetString(new IntPtr(p + 0x018)); // 024661816AD8 0x18 AcbFile                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AwbFile                                   = GetString(new IntPtr(p + 0x020)); // 024661816AF8 0x20 AwbFile                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Acb                                       = GetObject<CriAtomExAcb>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomExAcb.FromPointer); // 024661816B18 0x28 Acb                         ( 0001866454D0 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer )
            value.LoaderStatus                              = (Status)GetInt32(new IntPtr(p + 0x030)); // 024661816B38 0x30 LoaderStatus                ( 000186545850 ModelEnumType Status Status Status Int32 )

            return value;
        }
    }
}
