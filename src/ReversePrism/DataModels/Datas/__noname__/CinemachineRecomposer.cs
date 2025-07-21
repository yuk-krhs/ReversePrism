using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_ApplyAfter                             ModelEnumType Stage Stage Stage Int32
    // 034 M_Tilt                                   ModelPrimitiveType float float float Single
    // 038 M_Pan                                    ModelPrimitiveType float float float Single
    // 03C M_Dutch                                  ModelPrimitiveType float float float Single
    // 040 M_ZoomScale                              ModelPrimitiveType float float float Single
    // 044 M_FollowAttachment                       ModelPrimitiveType float float float Single
    // 048 M_LookAtAttachment                       ModelPrimitiveType float float float Single
    public partial class CinemachineRecomposer : DataModel
    {
        public Stage                                    M_ApplyAfter                            { get; set; }
        public float                                    M_Tilt                                  { get; set; }
        public float                                    M_Pan                                   { get; set; }
        public float                                    M_Dutch                                 { get; set; }
        public float                                    M_ZoomScale                             { get; set; }
        public float                                    M_FollowAttachment                      { get; set; }
        public float                                    M_LookAtAttachment                      { get; set; }

        public static CinemachineRecomposer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineRecomposer() { Pointer= p0 };

            value.M_ApplyAfter                              = (Stage)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_ApplyAfter                ( ModelEnumType Stage Stage Stage Int32 )
            value.M_Tilt                                    = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_Tilt                      ( ModelPrimitiveType float float float Single )
            value.M_Pan                                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_Pan                       ( ModelPrimitiveType float float float Single )
            value.M_Dutch                                   = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_Dutch                     ( ModelPrimitiveType float float float Single )
            value.M_ZoomScale                               = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_ZoomScale                 ( ModelPrimitiveType float float float Single )
            value.M_FollowAttachment                        = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_FollowAttachment          ( ModelPrimitiveType float float float Single )
            value.M_LookAtAttachment                        = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_LookAtAttachment          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
