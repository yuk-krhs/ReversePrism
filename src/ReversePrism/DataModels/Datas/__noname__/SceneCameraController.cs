using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TargetObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 TargetPoint                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 000 RotateSpeed                              float IL2CPP_TYPE_R4
    // 000 ZoomSpeed                                float IL2CPP_TYPE_R4
    // 000 TranslateSpeed                           float IL2CPP_TYPE_R4
    // 000 IsCameraLookChara                        bool IL2CPP_TYPE_BOOLEAN
    // 034 LastPos                                  0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class SceneCameraController : DataModel
    {
        public GameObject?                              TargetObject                            { get; set; }
        public Vector3                                  TargetPoint                             { get; set; }
        public Vector3                                  LastPos                                 { get; set; }

        public static SceneCameraController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneCameraController() { Pointer= p0 };

            value.TargetObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024663330B80 0x20 TargetObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TargetPoint                               = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 024663330BA0 0x28 TargetPoint                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LastPos                                   = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 024663330C40 0x34 LastPos                     ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
