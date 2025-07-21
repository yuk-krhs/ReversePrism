using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FullPath                               ModelPrimitiveType int int int Int32
    // 014 M_UserName                               ModelPrimitiveType int int int Int32
    // 018 M_Name                                   ModelPrimitiveType int int int Int32
    // 01C M_HasFixedDuration                       ModelPrimitiveType bool bool bool Bool
    // 020 M_Duration                               ModelPrimitiveType float float float Single
    // 024 M_NormalizedTime                         ModelPrimitiveType float float float Single
    // 028 M_AnyState                               ModelPrimitiveType bool bool bool Bool
    // 02C M_TransitionType                         ModelPrimitiveType int int int Int32
    public partial class AnimatorTransitionInfo : DataModel
    {
        public int                                      M_FullPath                              { get; set; }
        public int                                      M_UserName                              { get; set; }
        public int                                      M_Name                                  { get; set; }
        public bool                                     M_HasFixedDuration                      { get; set; }
        public float                                    M_Duration                              { get; set; }
        public float                                    M_NormalizedTime                        { get; set; }
        public bool                                     M_AnyState                              { get; set; }
        public int                                      M_TransitionType                        { get; set; }

        public static AnimatorTransitionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatorTransitionInfo() { Pointer= p0 };

            value.M_FullPath                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_FullPath                  ( ModelPrimitiveType int int int Int32 )
            value.M_UserName                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_UserName                  ( ModelPrimitiveType int int int Int32 )
            value.M_Name                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Name                      ( ModelPrimitiveType int int int Int32 )
            value.M_HasFixedDuration                        = GetBool(new IntPtr(p + 0x01C)); // 0x1C M_HasFixedDuration          ( ModelPrimitiveType bool bool bool Bool )
            value.M_Duration                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_Duration                  ( ModelPrimitiveType float float float Single )
            value.M_NormalizedTime                          = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_NormalizedTime            ( ModelPrimitiveType float float float Single )
            value.M_AnyState                                = GetBool(new IntPtr(p + 0x028)); // 0x28 M_AnyState                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_TransitionType                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_TransitionType            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
