using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Color                                    ModelEnumType Color Color Color Int32
    // 030 VertexCounts                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 ColorToUVs                               ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 040 Tmp                                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ColorOld                                 ModelEnumType Color Color Color Int32
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

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 Color                       ( ModelEnumType Color Color Color Int32 )
            value.VertexCounts                              = GetInt32List(new IntPtr(p + 0x030)); // 0x30 VertexCounts                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ColorToUVs                                = GetEnumList<Vector4>(new IntPtr(p + 0x038)); // 0x38 ColorToUVs                  ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.Tmp                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 Tmp                         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ColorOld                                  = (Color)GetInt32(new IntPtr(p + 0x048)); // 0x48 ColorOld                    ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
