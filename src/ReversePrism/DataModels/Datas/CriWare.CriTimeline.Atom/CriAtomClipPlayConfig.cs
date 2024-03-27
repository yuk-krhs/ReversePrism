using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Clip                                     000186642740 ModelClassType CriAtomClipBase CriAtomClipBase CriAtomClipBase Pointer
    // 018 StartTimeMs                              0001865F87A0 ModelPrimitiveType long long long Int64
    // 020 SpeedRate                                0001865C3800 ModelPrimitiveType double double double Double
    // 028 Loop                                     000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtomClipPlayConfig
    {
        public CriAtomClipBase?                         Clip                                    { get; set; }
        public long                                     StartTimeMs                             { get; set; }
        public double                                   SpeedRate                               { get; set; }
        public bool                                     Loop                                    { get; set; }

        public static CriAtomClipPlayConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomClipPlayConfig();

            value.Clip                                      = GetObject<CriAtomClipBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.CriAtomClipBase.FromPointer); // 0270DACEDF90 0x10 Clip                        ( 000186642740 ModelClassType CriAtomClipBase CriAtomClipBase CriAtomClipBase Pointer )
            value.StartTimeMs                               = GetInt64(new IntPtr(p + 0x018)); // 0270DACEDFB0 0x18 StartTimeMs                 ( 0001865F87A0 ModelPrimitiveType long long long Int64 )
            value.SpeedRate                                 = GetDouble(new IntPtr(p + 0x020)); // 0270DACEDFD0 0x20 SpeedRate                   ( 0001865C3800 ModelPrimitiveType double double double Double )
            value.Loop                                      = GetBool(new IntPtr(p + 0x028)); // 0270DACEDFF0 0x28 Loop                        ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
