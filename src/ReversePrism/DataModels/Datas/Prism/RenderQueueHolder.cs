using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RenderQueue                              ModelPrimitiveType int int int Int32
    // 028 MeshRenderer                             ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    // 030 LastEnable                               ModelPrimitiveType bool bool bool Bool
    public partial class RenderQueueHolder : DataModel
    {
        public int                                      RenderQueue                             { get; set; }
        public MeshRenderer?                            MeshRenderer                            { get; set; }
        public bool                                     LastEnable                              { get; set; }

        public static RenderQueueHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderQueueHolder() { Pointer= p0 };

            value.RenderQueue                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 RenderQueue                 ( ModelPrimitiveType int int int Int32 )
            value.MeshRenderer                              = GetObject<MeshRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.MeshRenderer.FromPointer); // 0x28 MeshRenderer                ( ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )
            value.LastEnable                                = GetBool(new IntPtr(p + 0x030)); // 0x30 LastEnable                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
