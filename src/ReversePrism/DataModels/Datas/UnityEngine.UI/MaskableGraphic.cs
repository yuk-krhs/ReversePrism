using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 M_ShouldRecalculateStencil               000186597990 ModelPrimitiveType bool bool bool Bool
    // 0B0 M_MaskMaterial                           00018660CE20 ModelClassType Material Material Material Pointer
    // 0B8 M_ParentMask                             00018662ED90 ModelClassType RectMask2D RectMask2D RectMask2D Pointer
    // 0C0 M_Maskable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C1 M_IsMaskingGraphic                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C2 M_IncludeForMasking                      000186597990 ModelPrimitiveType bool bool bool Bool
    // 0C8 M_OnCullStateChanged                     0001866FA0E0 ModelClassType CullStateChangedEvent CullStateChangedEvent CullStateChangedEvent Pointer
    // 0D0 M_ShouldRecalculate                      000186597990 ModelPrimitiveType bool bool bool Bool
    // 0D4 M_StencilValue                           0001865F5770 ModelPrimitiveType int int int Int32
    // 0D8 M_Corners                                000185CB10A8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    public partial class MaskableGraphic
    {
        public bool                                     M_ShouldRecalculateStencil              { get; set; }
        public Material?                                M_MaskMaterial                          { get; set; }
        public RectMask2D?                              M_ParentMask                            { get; set; }
        public bool                                     M_Maskable                              { get; set; }
        public bool                                     M_IsMaskingGraphic                      { get; set; }
        public bool                                     M_IncludeForMasking                     { get; set; }
        public CullStateChangedEvent?                   M_OnCullStateChanged                    { get; set; }
        public bool                                     M_ShouldRecalculate                     { get; set; }
        public int                                      M_StencilValue                          { get; set; }
        public List<Vector3>?                           M_Corners                               { get; set; }

        public static MaskableGraphic? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaskableGraphic();

            value.M_ShouldRecalculateStencil                = GetBool(new IntPtr(p + 0x0A8)); // 027003C4F900 0xA8 M_ShouldRecalculateStencil  ( 000186597990 ModelPrimitiveType bool bool bool Bool )
            value.M_MaskMaterial                            = GetObject<Material>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Material.FromPointer); // 027003C4F920 0xB0 M_MaskMaterial              ( 00018660CE20 ModelClassType Material Material Material Pointer )
            value.M_ParentMask                              = GetObject<RectMask2D>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RectMask2D.FromPointer); // 027003C4F940 0xB8 M_ParentMask                ( 00018662ED90 ModelClassType RectMask2D RectMask2D RectMask2D Pointer )
            value.M_Maskable                                = GetBool(new IntPtr(p + 0x0C0)); // 027003C4F960 0xC0 M_Maskable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsMaskingGraphic                        = GetBool(new IntPtr(p + 0x0C1)); // 027003C4F980 0xC1 M_IsMaskingGraphic          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IncludeForMasking                       = GetBool(new IntPtr(p + 0x0C2)); // 027003C4F9A0 0xC2 M_IncludeForMasking         ( 000186597990 ModelPrimitiveType bool bool bool Bool )
            value.M_OnCullStateChanged                      = GetObject<CullStateChangedEvent>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CullStateChangedEvent.FromPointer); // 027003C4F9C0 0xC8 M_OnCullStateChanged        ( 0001866FA0E0 ModelClassType CullStateChangedEvent CullStateChangedEvent CullStateChangedEvent Pointer )
            value.M_ShouldRecalculate                       = GetBool(new IntPtr(p + 0x0D0)); // 027003C4F9E0 0xD0 M_ShouldRecalculate         ( 000186597990 ModelPrimitiveType bool bool bool Bool )
            value.M_StencilValue                            = GetInt32(new IntPtr(p + 0x0D4)); // 027003C4FA00 0xD4 M_StencilValue              ( 0001865F5770 ModelPrimitiveType int int int Int32 )
            value.M_Corners                                 = GetEnumList<Vector3>(new IntPtr(p + 0x0D8)); // 027003C4FA20 0xD8 M_Corners                   ( 000185CB10A8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
