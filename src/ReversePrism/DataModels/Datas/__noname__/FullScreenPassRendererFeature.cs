using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PassMaterial                             ModelClassType Material Material Material Pointer
    // 028 InjectionPoint                           ModelEnumType InjectionPoint InjectionPoint InjectionPoint Int32
    // 02C Requirements                             ModelEnumType ScriptableRenderPassInput ScriptableRenderPassInput ScriptableRenderPassInput Int32
    // 030 PassIndex                                ModelPrimitiveType int int int Int32
    // 038 FullScreenPass                           ModelClassType FullScreenRenderPass FullScreenRenderPass FullScreenRenderPass Pointer
    // 040 RequiresColor                            ModelPrimitiveType bool bool bool Bool
    // 041 InjectedBeforeTransparents               ModelPrimitiveType bool bool bool Bool
    public partial class FullScreenPassRendererFeature : DataModel
    {
        public Material?                                PassMaterial                            { get; set; }
        public InjectionPoint                           InjectionPoint                          { get; set; }
        public ScriptableRenderPassInput                Requirements                            { get; set; }
        public int                                      PassIndex                               { get; set; }
        public FullScreenRenderPass?                    FullScreenPass                          { get; set; }
        public bool                                     RequiresColor                           { get; set; }
        public bool                                     InjectedBeforeTransparents              { get; set; }

        public static FullScreenPassRendererFeature? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FullScreenPassRendererFeature() { Pointer= p0 };

            value.PassMaterial                              = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0x20 PassMaterial                ( ModelClassType Material Material Material Pointer )
            value.InjectionPoint                            = (InjectionPoint)GetInt32(new IntPtr(p + 0x028)); // 0x28 InjectionPoint              ( ModelEnumType InjectionPoint InjectionPoint InjectionPoint Int32 )
            value.Requirements                              = (ScriptableRenderPassInput)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Requirements                ( ModelEnumType ScriptableRenderPassInput ScriptableRenderPassInput ScriptableRenderPassInput Int32 )
            value.PassIndex                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 PassIndex                   ( ModelPrimitiveType int int int Int32 )
            value.FullScreenPass                            = GetObject<FullScreenRenderPass>(new IntPtr(p + 0x038), ReversePrism.DataModels.FullScreenRenderPass.FromPointer); // 0x38 FullScreenPass              ( ModelClassType FullScreenRenderPass FullScreenRenderPass FullScreenRenderPass Pointer )
            value.RequiresColor                             = GetBool(new IntPtr(p + 0x040)); // 0x40 RequiresColor               ( ModelPrimitiveType bool bool bool Bool )
            value.InjectedBeforeTransparents                = GetBool(new IntPtr(p + 0x041)); // 0x41 InjectedBeforeTransparents  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
