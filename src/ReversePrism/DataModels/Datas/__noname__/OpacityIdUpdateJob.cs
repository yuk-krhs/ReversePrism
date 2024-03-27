using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 oldVerts                                 NativeSlice`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 020 newVerts                                 NativeSlice`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 030 OpacityData                              0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    public partial class OpacityIdUpdateJob
    {
        public Color32                                  OpacityData                             { get; set; }

        public static OpacityIdUpdateJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpacityIdUpdateJob();

            value.OpacityData                               = (Color32)GetInt32(new IntPtr(p + 0x030)); // 0270068681C8 0x30 OpacityData                 ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )

            return value;
        }
    }
}
