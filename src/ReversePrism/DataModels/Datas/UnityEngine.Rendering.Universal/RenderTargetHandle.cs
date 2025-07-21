using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 Rtid                                     ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 000 CameraTarget                             RenderTargetHandle IL2CPP_TYPE_VALUETYPE
    public partial class RenderTargetHandle : DataModel
    {
        public int                                      Id                                      { get; set; }
        public RenderTargetIdentifier                   Rtid                                    { get; set; }

        public static RenderTargetHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderTargetHandle() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Rtid                                      = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x018)); // 0x18 Rtid                        ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )

            return value;
        }
    }
}
