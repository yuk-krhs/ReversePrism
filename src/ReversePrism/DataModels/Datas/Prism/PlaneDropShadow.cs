using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MeshRenderer                             000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    // 028 BaseColor                                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 038 MaxHeight                                0001866656B0 ModelPrimitiveType float float float Single
    // 040 DataList                                 000185CF97A8 ModelClassListType List`1<PlaneDropShadowData> List`1<PlaneDropShadowData> List<PlaneDropShadowData> Pointer
    // 048 Zbias                                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class PlaneDropShadow
    {
        public MeshRenderer?                            MeshRenderer                            { get; set; }
        public Color                                    BaseColor                               { get; set; }
        public float                                    MaxHeight                               { get; set; }
        public List<PlaneDropShadowData>?               DataList                                { get; set; }
        public float                                    Zbias                                   { get; set; }

        public static PlaneDropShadow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaneDropShadow();

            value.MeshRenderer                              = GetObject<MeshRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshRenderer.FromPointer); // 027006AAC800 0x20 MeshRenderer                ( 000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )
            value.BaseColor                                 = (Color)GetInt32(new IntPtr(p + 0x028)); // 027006AAC820 0x28 BaseColor                   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.MaxHeight                                 = GetSingle(new IntPtr(p + 0x038)); // 027006AAC840 0x38 MaxHeight                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DataList                                  = GetObjectList<PlaneDropShadowData>(new IntPtr(p + 0x040), ReversePrism.DataModels.PlaneDropShadowData.FromPointer); // 027006AAC860 0x40 DataList                    ( 000185CF97A8 ModelClassListType List`1<PlaneDropShadowData> List`1<PlaneDropShadowData> List<PlaneDropShadowData> Pointer )
            value.Zbias                                     = GetSingle(new IntPtr(p + 0x048)); // 027006AAC880 0x48 Zbias                       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
