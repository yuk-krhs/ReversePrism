using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Version                                  ModelPrimitiveType int int int Int32
    // 020 Atlas                                    ModelClassType Texture2D Texture2D Texture2D Pointer
    // 028 Vertices                                 ModelEnumListType VectorImageVertex[] VectorImageVertex[] List<VectorImageVertex> Pointer
    // 030 Indices                                  ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 038 Settings                                 ModelEnumListType GradientSettings[] GradientSettings[] List<GradientSettings> Pointer
    // 040 Size                                     ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class VectorImage : DataModel
    {
        public int                                      Version                                 { get; set; }
        public Texture2D?                               Atlas                                   { get; set; }
        public List<VectorImageVertex>?                 Vertices                                { get; set; }
        public List<ushort>?                            Indices                                 { get; set; }
        public List<GradientSettings>?                  Settings                                { get; set; }
        public Vector2                                  Size                                    { get; set; }

        public static VectorImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VectorImage() { Pointer= p0 };

            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Version                     ( ModelPrimitiveType int int int Int32 )
            value.Atlas                                     = GetObject<Texture2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture2D.FromPointer); // 0x20 Atlas                       ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Vertices                                  = GetEnumList<VectorImageVertex>(new IntPtr(p + 0x028)); // 0x28 Vertices                    ( ModelEnumListType VectorImageVertex[] VectorImageVertex[] List<VectorImageVertex> Pointer )
            value.Indices                                   = GetUInt16List(new IntPtr(p + 0x030)); // 0x30 Indices                     ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.Settings                                  = GetEnumList<GradientSettings>(new IntPtr(p + 0x038)); // 0x38 Settings                    ( ModelEnumListType GradientSettings[] GradientSettings[] List<GradientSettings> Pointer )
            value.Size                                      = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 Size                        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
