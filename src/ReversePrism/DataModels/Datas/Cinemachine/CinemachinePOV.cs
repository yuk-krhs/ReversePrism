using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_RecenterTarget                         ModelEnumType RecenterTargetMode RecenterTargetMode RecenterTargetMode Int32
    // 030 M_VerticalAxis                           ModelEnumType AxisState AxisState AxisState Int32
    // 0A0 M_VerticalRecentering                    ModelEnumType Recentering Recentering Recentering Int32
    // 0C0 M_HorizontalAxis                         ModelEnumType AxisState AxisState AxisState Int32
    // 130 M_HorizontalRecentering                  ModelEnumType Recentering Recentering Recentering Int32
    // 150 M_ApplyBeforeBody                        ModelPrimitiveType bool bool bool Bool
    // 154 M_PreviousCameraRotation                 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class CinemachinePOV : DataModel
    {
        public RecenterTargetMode                       M_RecenterTarget                        { get; set; }
        public AxisState                                M_VerticalAxis                          { get; set; }
        public Recentering                              M_VerticalRecentering                   { get; set; }
        public AxisState                                M_HorizontalAxis                        { get; set; }
        public Recentering                              M_HorizontalRecentering                 { get; set; }
        public bool                                     M_ApplyBeforeBody                       { get; set; }
        public Quaternion                               M_PreviousCameraRotation                { get; set; }

        public static CinemachinePOV? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachinePOV() { Pointer= p0 };

            value.M_RecenterTarget                          = (RecenterTargetMode)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_RecenterTarget            ( ModelEnumType RecenterTargetMode RecenterTargetMode RecenterTargetMode Int32 )
            value.M_VerticalAxis                            = (AxisState)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_VerticalAxis              ( ModelEnumType AxisState AxisState AxisState Int32 )
            value.M_VerticalRecentering                     = (Recentering)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_VerticalRecentering       ( ModelEnumType Recentering Recentering Recentering Int32 )
            value.M_HorizontalAxis                          = (AxisState)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 M_HorizontalAxis            ( ModelEnumType AxisState AxisState AxisState Int32 )
            value.M_HorizontalRecentering                   = (Recentering)GetInt32(new IntPtr(p + 0x130)); // 0x130 M_HorizontalRecentering     ( ModelEnumType Recentering Recentering Recentering Int32 )
            value.M_ApplyBeforeBody                         = GetBool(new IntPtr(p + 0x150)); // 0x150 M_ApplyBeforeBody           ( ModelPrimitiveType bool bool bool Bool )
            value.M_PreviousCameraRotation                  = (Quaternion)GetInt32(new IntPtr(p + 0x154)); // 0x154 M_PreviousCameraRotation    ( ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
