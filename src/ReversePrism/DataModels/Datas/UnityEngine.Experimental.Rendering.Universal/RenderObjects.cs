using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Settings                                 ModelClassType RenderObjectsSettings RenderObjectsSettings RenderObjectsSettings Pointer
    // 028 RenderObjectsPass                        ModelClassType RenderObjectsPass RenderObjectsPass RenderObjectsPass Pointer
    public partial class RenderObjects : DataModel
    {
        public RenderObjectsSettings?                   Settings                                { get; set; }
        public RenderObjectsPass?                       RenderObjectsPass                       { get; set; }

        public static RenderObjects? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderObjects() { Pointer= p0 };

            value.Settings                                  = GetObject<RenderObjectsSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderObjectsSettings.FromPointer); // 0x20 Settings                    ( ModelClassType RenderObjectsSettings RenderObjectsSettings RenderObjectsSettings Pointer )
            value.RenderObjectsPass                         = GetObject<RenderObjectsPass>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderObjectsPass.FromPointer); // 0x28 RenderObjectsPass           ( ModelClassType RenderObjectsPass RenderObjectsPass RenderObjectsPass Pointer )

            return value;
        }
    }
}
