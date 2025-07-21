using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TargetPoint                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C RotateSpeed                              ModelPrimitiveType float float float Single
    // 030 TranslateSpeed                           ModelPrimitiveType float float float Single
    // 034 ZoomSpeed                                ModelPrimitiveType float float float Single
    // 038 LastPos                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 IsUseGyro                                ModelPrimitiveType bool bool bool Bool
    // 045 IsActoveControll                         ModelPrimitiveType bool bool bool Bool
    // 048 BASE_ROTATION                            ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class SceneCameraController_Stream : DataModel
    {
        public Vector3                                  TargetPoint                             { get; set; }
        public float                                    RotateSpeed                             { get; set; }
        public float                                    TranslateSpeed                          { get; set; }
        public float                                    ZoomSpeed                               { get; set; }
        public Vector3                                  LastPos                                 { get; set; }
        public bool                                     IsUseGyro                               { get; set; }
        public bool                                     IsActoveControll                        { get; set; }
        public Quaternion                               BASE_ROTATION                           { get; set; }

        public static SceneCameraController_Stream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneCameraController_Stream() { Pointer= p0 };

            value.TargetPoint                               = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 TargetPoint                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RotateSpeed                               = GetSingle(new IntPtr(p + 0x02C)); // 0x2C RotateSpeed                 ( ModelPrimitiveType float float float Single )
            value.TranslateSpeed                            = GetSingle(new IntPtr(p + 0x030)); // 0x30 TranslateSpeed              ( ModelPrimitiveType float float float Single )
            value.ZoomSpeed                                 = GetSingle(new IntPtr(p + 0x034)); // 0x34 ZoomSpeed                   ( ModelPrimitiveType float float float Single )
            value.LastPos                                   = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 LastPos                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.IsUseGyro                                 = GetBool(new IntPtr(p + 0x044)); // 0x44 IsUseGyro                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsActoveControll                          = GetBool(new IntPtr(p + 0x045)); // 0x45 IsActoveControll            ( ModelPrimitiveType bool bool bool Bool )
            value.BASE_ROTATION                             = (Quaternion)GetInt32(new IntPtr(p + 0x048)); // 0x48 BASE_ROTATION               ( ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
