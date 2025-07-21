using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_EyeCount                               int IL2CPP_TYPE_I4
    // 010 M_ViewProjection                         ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 018 M_PreviousViewProjection                 ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 020 M_LastFrameIndex                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 M_PrevAspectRatio                        ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class MotionVectorsPersistentData : DataModel
    {
        public List<Matrix4x4>?                         M_ViewProjection                        { get; set; }
        public List<Matrix4x4>?                         M_PreviousViewProjection                { get; set; }
        public List<int>?                               M_LastFrameIndex                        { get; set; }
        public List<float>?                             M_PrevAspectRatio                       { get; set; }

        public static MotionVectorsPersistentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MotionVectorsPersistentData() { Pointer= p0 };

            value.M_ViewProjection                          = GetEnumList<Matrix4x4>(new IntPtr(p + 0x010)); // 0x10 M_ViewProjection            ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_PreviousViewProjection                  = GetEnumList<Matrix4x4>(new IntPtr(p + 0x018)); // 0x18 M_PreviousViewProjection    ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_LastFrameIndex                          = GetInt32List(new IntPtr(p + 0x020)); // 0x20 M_LastFrameIndex            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_PrevAspectRatio                         = GetSingleList(new IntPtr(p + 0x028)); // 0x28 M_PrevAspectRatio           ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
