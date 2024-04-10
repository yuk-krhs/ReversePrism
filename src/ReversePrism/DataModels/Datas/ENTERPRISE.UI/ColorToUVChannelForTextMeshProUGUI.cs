using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Color                                    0001865AAE00 ModelEnumType Color Color Color Int32
    // 030 VertexCounts                             000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 ColorToUVs                               000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 040 Tmp                                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ColorOld                                 0001865AA8E0 ModelEnumType Color Color Color Int32
    public partial class ColorToUVChannelForTextMeshProUGUI : DataModel
    {
        public Color                                    Color                                   { get; set; }
        public List<int>?                               VertexCounts                            { get; set; }
        public List<Vector4>?                           ColorToUVs                              { get; set; }
        public UITextMeshProUGUI?                       Tmp                                     { get; set; }
        public Color                                    ColorOld                                { get; set; }

        public static ColorToUVChannelForTextMeshProUGUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorToUVChannelForTextMeshProUGUI() { Pointer= p0 };

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x020)); // 0246609C6240 0x20 Color                       ( 0001865AAE00 ModelEnumType Color Color Color Int32 )
            value.VertexCounts                              = GetInt32List(new IntPtr(p + 0x030)); // 0246609C6260 0x30 VertexCounts                ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ColorToUVs                                = GetEnumList<Vector4>(new IntPtr(p + 0x038)); // 0246609C6280 0x38 ColorToUVs                  ( 000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.Tmp                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246609C62A0 0x40 Tmp                         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ColorOld                                  = (Color)GetInt32(new IntPtr(p + 0x048)); // 0246609C62C0 0x48 ColorOld                    ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
