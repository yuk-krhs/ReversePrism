using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RenderQueue                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 MeshRenderer                             000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    // 030 LastEnable                               000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.RenderQueue                               = GetInt32(new IntPtr(p + 0x020)); // 024664DCCC90 0x20 RenderQueue                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MeshRenderer                              = GetObject<MeshRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.MeshRenderer.FromPointer); // 024664DCCCB0 0x28 MeshRenderer                ( 000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )
            value.LastEnable                                = GetBool(new IntPtr(p + 0x030)); // 024664DCCCD0 0x30 LastEnable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
