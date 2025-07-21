using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Time                                   ModelPrimitiveType float float float Single
    // 018 M_FunctionName                           ModelPrimitiveType string string string String
    // 020 M_StringParameter                        ModelPrimitiveType string string string String
    // 028 M_ObjectReferenceParameter               ModelClassType Object Object Object Pointer
    // 030 M_FloatParameter                         ModelPrimitiveType float float float Single
    // 034 M_IntParameter                           ModelPrimitiveType int int int Int32
    // 038 M_MessageOptions                         ModelPrimitiveType int int int Int32
    // 03C M_Source                                 ModelEnumType AnimationEventSource AnimationEventSource AnimationEventSource Int32
    // 040 M_StateSender                            ModelClassType AnimationState AnimationState AnimationState Pointer
    // 048 M_AnimatorStateInfo                      ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32
    // 06C M_AnimatorClipInfo                       ModelEnumType AnimatorClipInfo AnimatorClipInfo AnimatorClipInfo Int32
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

            value.M_Time                                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_Time                      ( ModelPrimitiveType float float float Single )
            value.M_FunctionName                            = GetString(new IntPtr(p + 0x018)); // 0x18 M_FunctionName              ( ModelPrimitiveType string string string String )
            value.M_StringParameter                         = GetString(new IntPtr(p + 0x020)); // 0x20 M_StringParameter           ( ModelPrimitiveType string string string String )
            value.M_ObjectReferenceParameter                = GetObject<Object>(new IntPtr(p + 0x028), ReversePrism.DataModels.Object.FromPointer); // 0x28 M_ObjectReferenceParameter  ( ModelClassType Object Object Object Pointer )
            value.M_FloatParameter                          = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_FloatParameter            ( ModelPrimitiveType float float float Single )
            value.M_IntParameter                            = GetInt32(new IntPtr(p + 0x034)); // 0x34 M_IntParameter              ( ModelPrimitiveType int int int Int32 )
            value.M_MessageOptions                          = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_MessageOptions            ( ModelPrimitiveType int int int Int32 )
            value.M_Source                                  = (AnimationEventSource)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_Source                    ( ModelEnumType AnimationEventSource AnimationEventSource AnimationEventSource Int32 )
            value.M_StateSender                             = GetObject<AnimationState>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationState.FromPointer); // 0x40 M_StateSender               ( ModelClassType AnimationState AnimationState AnimationState Pointer )
            value.M_AnimatorStateInfo                       = (AnimatorStateInfo)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_AnimatorStateInfo         ( ModelEnumType AnimatorStateInfo AnimatorStateInfo AnimatorStateInfo Int32 )
            value.M_AnimatorClipInfo                        = (AnimatorClipInfo)GetInt32(new IntPtr(p + 0x06C)); // 0x6C M_AnimatorClipInfo          ( ModelEnumType AnimatorClipInfo AnimatorClipInfo AnimatorClipInfo Int32 )

            return value;
        }
    }
}
