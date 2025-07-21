using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_MouseUsed                              bool IL2CPP_TYPE_BOOLEAN
    // 008 m_LastHit                                HitInfo[] IL2CPP_TYPE_SZARRAY
    // 010 M_MouseDownHit                           ModelEnumListType HitInfo[] HitInfo[] List<HitInfo> Pointer
    // 018 M_CurrentHit                             ModelEnumListType HitInfo[] HitInfo[] List<HitInfo> Pointer
    // 020 M_Cameras                                ModelClassListType Camera[] Camera[] List<Camera> Pointer
    // 028 s_GetMouseState                          Func`1<KeyValuePair`2<int, Vector2>> IL2CPP_TYPE_GENERICINST
    // 030 S_MousePosition                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 S_MouseButtonPressedThisFrame            ModelPrimitiveType bool bool bool Bool
    // 039 S_MouseButtonIsPressed                   ModelPrimitiveType bool bool bool Bool
    public partial class SendMouseEvents : DataModel
    {
        public List<HitInfo>?                           M_MouseDownHit                          { get; set; }
        public List<HitInfo>?                           M_CurrentHit                            { get; set; }
        public List<Camera>?                            M_Cameras                               { get; set; }
        public Vector2                                  S_MousePosition                         { get; set; }
        public bool                                     S_MouseButtonPressedThisFrame           { get; set; }
        public bool                                     S_MouseButtonIsPressed                  { get; set; }

        public static SendMouseEvents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SendMouseEvents() { Pointer= p0 };

            value.M_MouseDownHit                            = GetEnumList<HitInfo>(new IntPtr(p + 0x010)); // 0x10 M_MouseDownHit              ( ModelEnumListType HitInfo[] HitInfo[] List<HitInfo> Pointer )
            value.M_CurrentHit                              = GetEnumList<HitInfo>(new IntPtr(p + 0x018)); // 0x18 M_CurrentHit                ( ModelEnumListType HitInfo[] HitInfo[] List<HitInfo> Pointer )
            value.M_Cameras                                 = GetObjectList<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 M_Cameras                   ( ModelClassListType Camera[] Camera[] List<Camera> Pointer )
            value.S_MousePosition                           = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0x30 S_MousePosition             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.S_MouseButtonPressedThisFrame             = GetBool(new IntPtr(p + 0x038)); // 0x38 S_MouseButtonPressedThisFrame ( ModelPrimitiveType bool bool bool Bool )
            value.S_MouseButtonIsPressed                    = GetBool(new IntPtr(p + 0x039)); // 0x39 S_MouseButtonIsPressed      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
