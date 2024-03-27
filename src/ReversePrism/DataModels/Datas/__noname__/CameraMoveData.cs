using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MoveID                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 CameraPos                                000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 020 TiltPanRoll                              000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 028 Zoom                                     000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 030 Focus                                    000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class CameraMoveData
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
            var value   = new CameraMoveData();

            value.MoveID                                    = GetString(new IntPtr(p + 0x010)); // 027006B1D950 0x10 MoveID                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CameraPos                                 = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 027006B1D970 0x18 CameraPos                   ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.TiltPanRoll                               = GetEnumList<Vector3>(new IntPtr(p + 0x020)); // 027006B1D990 0x20 TiltPanRoll                 ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Zoom                                      = GetSingleList(new IntPtr(p + 0x028)); // 027006B1D9B0 0x28 Zoom                        ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Focus                                     = GetSingleList(new IntPtr(p + 0x030)); // 027006B1D9D0 0x30 Focus                       ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
