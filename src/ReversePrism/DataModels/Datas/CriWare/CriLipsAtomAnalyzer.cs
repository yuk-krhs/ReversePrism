using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Mouth                                    000186656F50 ModelClassType CriLipsMouth CriLipsMouth CriLipsMouth Pointer
    // 028 handle                                   <int> IL2CPP_TYPE_I
    // 030 AttachedPlayer                           000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 038 MaxSamplingRate                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CriLipsAtomAnalyzer
    {
        public CriLipsMouth?                            Mouth                                   { get; set; }
        public CriAtomExPlayer?                         AttachedPlayer                          { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }

        public static CriLipsAtomAnalyzer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsAtomAnalyzer();

            value.Mouth                                     = GetObject<CriLipsMouth>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriLipsMouth.FromPointer); // 0270DBBA60C0 0x20 Mouth                       ( 000186656F50 ModelClassType CriLipsMouth CriLipsMouth CriLipsMouth Pointer )
            value.AttachedPlayer                            = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0270DBBA6100 0x30 AttachedPlayer              ( 000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x038)); // 0270DBBA6120 0x38 MaxSamplingRate             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
