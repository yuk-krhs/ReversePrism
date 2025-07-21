using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   ModelClassType RTHandle RTHandle RTHandle Pointer
    // 018 Fallback                                 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    public partial class RTHandleRenderTargetIdentifierCompat : DataModel
    {
        public RTHandle?                                Handle                                  { get; set; }
        public RenderTargetIdentifier                   Fallback                                { get; set; }

        public static RTHandleRenderTargetIdentifierCompat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RTHandleRenderTargetIdentifierCompat() { Pointer= p0 };

            value.Handle                                    = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0x10 Handle                      ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.Fallback                                  = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x018)); // 0x18 Fallback                    ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )

            return value;
        }
    }
}
