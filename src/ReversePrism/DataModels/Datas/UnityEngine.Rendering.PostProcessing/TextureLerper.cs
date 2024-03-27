using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Instance                               TextureLerper IL2CPP_TYPE_CLASS
    // 010 M_Command                                0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 018 M_PropertySheets                         0001865D6000 ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer
    // 020 M_Resources                              00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 028 M_Recycled                               000185D02058 ModelClassListType List`1<RenderTexture> List`1<RenderTexture> List<RenderTexture> Pointer
    // 030 M_Actives                                000185D02058 ModelClassListType List`1<RenderTexture> List`1<RenderTexture> List<RenderTexture> Pointer
    public partial class TextureLerper
    {
        public CommandBuffer?                           M_Command                               { get; set; }
        public PropertySheetFactory?                    M_PropertySheets                        { get; set; }
        public PostProcessResources?                    M_Resources                             { get; set; }
        public List<RenderTexture>?                     M_Recycled                              { get; set; }
        public List<RenderTexture>?                     M_Actives                               { get; set; }

        public static TextureLerper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureLerper();

            value.M_Command                                 = GetObject<CommandBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0270065F74A0 0x10 M_Command                   ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_PropertySheets                          = GetObject<PropertySheetFactory>(new IntPtr(p + 0x018), ReversePrism.DataModels.PropertySheetFactory.FromPointer); // 0270065F74C0 0x18 M_PropertySheets            ( 0001865D6000 ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer )
            value.M_Resources                               = GetObject<PostProcessResources>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessResources.FromPointer); // 0270065F74E0 0x20 M_Resources                 ( 00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.M_Recycled                                = GetObjectList<RenderTexture>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderTexture.FromPointer); // 0270065F7500 0x28 M_Recycled                  ( 000185D02058 ModelClassListType List`1<RenderTexture> List`1<RenderTexture> List<RenderTexture> Pointer )
            value.M_Actives                                 = GetObjectList<RenderTexture>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTexture.FromPointer); // 0270065F7520 0x30 M_Actives                   ( 000185D02058 ModelClassListType List`1<RenderTexture> List`1<RenderTexture> List<RenderTexture> Pointer )

            return value;
        }
    }
}
