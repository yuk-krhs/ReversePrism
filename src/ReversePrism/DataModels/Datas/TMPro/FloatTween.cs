using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Target                                 0001866C27A0 ModelClassType FloatTweenCallback FloatTweenCallback FloatTweenCallback Pointer
    // 018 M_StartValue                             0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_TargetValue                            0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_Duration                               0001866656B0 ModelPrimitiveType float float float Single
    // 024 M_IgnoreTimeScale                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FloatTween
    {
        public FloatTweenCallback?                      M_Target                                { get; set; }
        public float                                    M_StartValue                            { get; set; }
        public float                                    M_TargetValue                           { get; set; }
        public float                                    M_Duration                              { get; set; }
        public bool                                     M_IgnoreTimeScale                       { get; set; }

        public static FloatTween? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FloatTween();

            value.M_Target                                  = GetObject<FloatTweenCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.FloatTweenCallback.FromPointer); // 0270DA611830 0x10 M_Target                    ( 0001866C27A0 ModelClassType FloatTweenCallback FloatTweenCallback FloatTweenCallback Pointer )
            value.M_StartValue                              = GetSingle(new IntPtr(p + 0x018)); // 0270DA611850 0x18 M_StartValue                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TargetValue                             = GetSingle(new IntPtr(p + 0x01C)); // 0270DA611870 0x1C M_TargetValue               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Duration                                = GetSingle(new IntPtr(p + 0x020)); // 0270DA611890 0x20 M_Duration                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_IgnoreTimeScale                         = GetBool(new IntPtr(p + 0x024)); // 0270DA6118B0 0x24 M_IgnoreTimeScale           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
