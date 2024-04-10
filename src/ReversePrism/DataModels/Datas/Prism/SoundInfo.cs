using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AcbFileName                              0001866722E0 ModelPrimitiveType string string string String
    // 018 SheetName                                0001866722E0 ModelPrimitiveType string string string String
    // 020 CueInfos                                 000185CD5A88 ModelClassListType List`1<CueInfoEx> List`1<CueInfoEx> List<CueInfoEx> Pointer
    public partial class SoundInfo : DataModel
    {
        public string                                   AcbFileName                             { get; set; }
        public string                                   SheetName                               { get; set; }
        public List<CueInfoEx>?                         CueInfos                                { get; set; }

        public static SoundInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundInfo() { Pointer= p0 };

            value.AcbFileName                               = GetString(new IntPtr(p + 0x010)); // 024664F275A0 0x10 AcbFileName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SheetName                                 = GetString(new IntPtr(p + 0x018)); // 024664F275C0 0x18 SheetName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CueInfos                                  = GetObjectList<CueInfoEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.CueInfoEx.FromPointer); // 024664F275E0 0x20 CueInfos                    ( 000185CD5A88 ModelClassListType List`1<CueInfoEx> List`1<CueInfoEx> List<CueInfoEx> Pointer )

            return value;
        }
    }
}
