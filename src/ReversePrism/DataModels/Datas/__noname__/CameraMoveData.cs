using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MoveID                                   ModelPrimitiveType string string string String
    // 018 CameraPos                                ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 020 TiltPanRoll                              ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 028 Zoom                                     ModelPrimitiveListType float[] float[] List<float> Pointer
    // 030 Focus                                    ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class CameraMoveData : DataModel
    {
        public string                                   MoveID                                  { get; set; }
        public List<Vector3>?                           CameraPos                               { get; set; }
        public List<Vector3>?                           TiltPanRoll                             { get; set; }
        public List<float>?                             Zoom                                    { get; set; }
        public List<float>?                             Focus                                   { get; set; }

        public static CameraMoveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraMoveData() { Pointer= p0 };

            value.MoveID                                    = GetString(new IntPtr(p + 0x010)); // 0x10 MoveID                      ( ModelPrimitiveType string string string String )
            value.CameraPos                                 = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0x18 CameraPos                   ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.TiltPanRoll                               = GetEnumList<Vector3>(new IntPtr(p + 0x020)); // 0x20 TiltPanRoll                 ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Zoom                                      = GetSingleList(new IntPtr(p + 0x028)); // 0x28 Zoom                        ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Focus                                     = GetSingleList(new IntPtr(p + 0x030)); // 0x30 Focus                       ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
