using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Time                                   000186665900 ModelPrimitiveType float float float Single
    // 018 M_FunctionName                           000186671BA0 ModelPrimitiveType string string string String
    // 020 M_StringParameter                        000186671BA0 ModelPrimitiveType string string string String
    // 028 M_ObjectReferenceParameter               0001866384B0 ModelClassType Object Object Object Pointer
    // 030 M_FloatParameter                         000186665900 ModelPrimitiveType float float float Single
    // 034 M_IntParameter                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 038 M_MessageOptions                         0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C M_Source                                 0001866B39B0 ModelEnumType AnimationEventSource AnimationEventSource AnimationEventSource Int32
    // 040 M_StateSender                            0001866B7D90 ModelClassType AnimationState AnimationState AnimationState Pointer
    // 048 M_AnimatorStateInfo                      000186588180 ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32
    // 06C M_AnimatorClipInfo                       0001866B9870 ModelEnumType AnimatorClipInfo AnimatorClipInfo AnimatorClipInfo Int32
    public partial class AnimationEvent : DataModel
    {
        public float                                    M_Time                                  { get; set; }
        public string                                   M_FunctionName                          { get; set; }
        public string                                   M_StringParameter                       { get; set; }
        public Object?                                  M_ObjectReferenceParameter              { get; set; }
        public float                                    M_FloatParameter                        { get; set; }
        public int                                      M_IntParameter                          { get; set; }
        public int                                      M_MessageOptions                        { get; set; }
        public AnimationEventSource                     M_Source                                { get; set; }
        public AnimationState?                          M_StateSender                           { get; set; }
        public AnimatorStateInfo                        M_AnimatorStateInfo                     { get; set; }
        public AnimatorClipInfo                         M_AnimatorClipInfo                      { get; set; }

        public static AnimationEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationEvent() { Pointer= p0 };

            value.M_Time                                    = GetSingle(new IntPtr(p + 0x010)); // 0245A2225248 0x10 M_Time                      ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_FunctionName                            = GetString(new IntPtr(p + 0x018)); // 0245A2225268 0x18 M_FunctionName              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_StringParameter                         = GetString(new IntPtr(p + 0x020)); // 0245A2225288 0x20 M_StringParameter           ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_ObjectReferenceParameter                = GetObject<Object>(new IntPtr(p + 0x028), ReversePrism.DataModels.Object.FromPointer); // 0245A22252A8 0x28 M_ObjectReferenceParameter  ( 0001866384B0 ModelClassType Object Object Object Pointer )
            value.M_FloatParameter                          = GetSingle(new IntPtr(p + 0x030)); // 0245A22252C8 0x30 M_FloatParameter            ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_IntParameter                            = GetInt32(new IntPtr(p + 0x034)); // 0245A22252E8 0x34 M_IntParameter              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_MessageOptions                          = GetInt32(new IntPtr(p + 0x038)); // 0245A2225308 0x38 M_MessageOptions            ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_Source                                  = (AnimationEventSource)GetInt32(new IntPtr(p + 0x03C)); // 0245A2225328 0x3C M_Source                    ( 0001866B39B0 ModelEnumType AnimationEventSource AnimationEventSource AnimationEventSource Int32 )
            value.M_StateSender                             = GetObject<AnimationState>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationState.FromPointer); // 0245A2225348 0x40 M_StateSender               ( 0001866B7D90 ModelClassType AnimationState AnimationState AnimationState Pointer )
            value.M_AnimatorStateInfo                       = (AnimatorStateInfo)GetInt32(new IntPtr(p + 0x048)); // 0245A2225368 0x48 M_AnimatorStateInfo         ( 000186588180 ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32 )
            value.M_AnimatorClipInfo                        = (AnimatorClipInfo)GetInt32(new IntPtr(p + 0x06C)); // 0245A2225388 0x6C M_AnimatorClipInfo          ( 0001866B9870 ModelEnumType AnimatorClipInfo AnimatorClipInfo AnimatorClipInfo Int32 )

            return value;
        }
    }
}
