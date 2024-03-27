using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DebugItems                             000185CB9338 ModelClassListType Widget[] Widget[] List<Widget> Pointer
    // 018 M_DebugPanel                             000186587F40 ModelClassType Panel Panel Panel Pointer
    // 020 ClearRenderTargetsAtCreation             000186595960 ModelPrimitiveType bool bool bool Bool
    // 021 ClearRenderTargetsAtRelease              000186595960 ModelPrimitiveType bool bool bool Bool
    // 022 DisablePassCulling                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 023 ImmediateMode                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 024 EnableLogging                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 025 LogFrameInformation                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 026 LogResources                             000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class RenderGraphDebugParams
    {
        public List<Widget>?                            M_DebugItems                            { get; set; }
        public Panel?                                   M_DebugPanel                            { get; set; }
        public bool                                     ClearRenderTargetsAtCreation            { get; set; }
        public bool                                     ClearRenderTargetsAtRelease             { get; set; }
        public bool                                     DisablePassCulling                      { get; set; }
        public bool                                     ImmediateMode                           { get; set; }
        public bool                                     EnableLogging                           { get; set; }
        public bool                                     LogFrameInformation                     { get; set; }
        public bool                                     LogResources                            { get; set; }

        public static RenderGraphDebugParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphDebugParams();

            value.M_DebugItems                              = GetObjectList<Widget>(new IntPtr(p + 0x010), ReversePrism.DataModels.Widget.FromPointer); // 0270D907A8D8 0x10 M_DebugItems                ( 000185CB9338 ModelClassListType Widget[] Widget[] List<Widget> Pointer )
            value.M_DebugPanel                              = GetObject<Panel>(new IntPtr(p + 0x018), ReversePrism.DataModels.Panel.FromPointer); // 0270D907A8F8 0x18 M_DebugPanel                ( 000186587F40 ModelClassType Panel Panel Panel Pointer )
            value.ClearRenderTargetsAtCreation              = GetBool(new IntPtr(p + 0x020)); // 0270D907A918 0x20 ClearRenderTargetsAtCreation ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ClearRenderTargetsAtRelease               = GetBool(new IntPtr(p + 0x021)); // 0270D907A938 0x21 ClearRenderTargetsAtRelease ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DisablePassCulling                        = GetBool(new IntPtr(p + 0x022)); // 0270D907A958 0x22 DisablePassCulling          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ImmediateMode                             = GetBool(new IntPtr(p + 0x023)); // 0270D907A978 0x23 ImmediateMode               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EnableLogging                             = GetBool(new IntPtr(p + 0x024)); // 0270D907A998 0x24 EnableLogging               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LogFrameInformation                       = GetBool(new IntPtr(p + 0x025)); // 0270D907A9B8 0x25 LogFrameInformation         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LogResources                              = GetBool(new IntPtr(p + 0x026)); // 0270D907A9D8 0x26 LogResources                ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
