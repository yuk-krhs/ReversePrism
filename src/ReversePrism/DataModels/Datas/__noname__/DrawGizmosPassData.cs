using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderingData                            ModelEnumType RenderingData RenderingData RenderingData Int32
    // 2C8 Renderer                                 ModelClassType ScriptableRenderer ScriptableRenderer ScriptableRenderer Pointer
    // 2D0 GizmoSubset                              ModelEnumType GizmoSubset GizmoSubset GizmoSubset Int32
    public partial class DrawGizmosPassData : DataModel
    {
        public RenderingData                            RenderingData                           { get; set; }
        public ScriptableRenderer?                      Renderer                                { get; set; }
        public GizmoSubset                              GizmoSubset                             { get; set; }

        public static DrawGizmosPassData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawGizmosPassData() { Pointer= p0 };

            value.RenderingData                             = (RenderingData)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderingData               ( ModelEnumType RenderingData RenderingData RenderingData Int32 )
            value.Renderer                                  = GetObject<ScriptableRenderer>(new IntPtr(p + 0x2C8), ReversePrism.DataModels.ScriptableRenderer.FromPointer); // 0x2C8 Renderer                    ( ModelClassType ScriptableRenderer ScriptableRenderer ScriptableRenderer Pointer )
            value.GizmoSubset                               = (GizmoSubset)GetInt32(new IntPtr(p + 0x2D0)); // 0x2D0 GizmoSubset                 ( ModelEnumType GizmoSubset GizmoSubset GizmoSubset Int32 )

            return value;
        }
    }
}
