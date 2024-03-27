using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 028 Timeline                                 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 030 RootCurveData                            0001866EA5C0 ModelClassType RootCurveData RootCurveData RootCurveData Pointer
    // 038 StartPos                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 000 commonHipsHight                          float IL2CPP_TYPE_R4
    public partial class RootAnimation
    {
        public Character?                               Character                               { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public RootCurveData?                           RootCurveData                           { get; set; }
        public Vector3                                  StartPos                                { get; set; }

        public static RootAnimation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RootAnimation();

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 027006AAAF50 0x20 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlayableDirector.FromPointer); // 027006AAAF70 0x28 Timeline                    ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.RootCurveData                             = GetObject<RootCurveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.RootCurveData.FromPointer); // 027006AAAF90 0x30 RootCurveData               ( 0001866EA5C0 ModelClassType RootCurveData RootCurveData RootCurveData Pointer )
            value.StartPos                                  = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 027006AAAFB0 0x38 StartPos                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
