using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Version                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Atlas                                    000186685CB0 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 028 Vertices                                 000185CB1878 ModelEnumListType VectorImageVertex[] VectorImageVertex[] List<VectorImageVertex> Pointer
    // 030 Indices                                  000185CAEC08 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 038 Settings                                 000185B832A0 ModelEnumListType GradientSettings[] GradientSettings[] List<GradientSettings> Pointer
    // 040 Size                                     0001866A8240 ModelEnumType Vector2 Vector2 Vector2 Int32
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

            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A681B500 0x18 Version                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Atlas                                     = GetObject<Texture2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A681B520 0x20 Atlas                       ( 000186685CB0 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Vertices                                  = GetEnumList<VectorImageVertex>(new IntPtr(p + 0x028)); // 0245A681B540 0x28 Vertices                    ( 000185CB1878 ModelEnumListType VectorImageVertex[] VectorImageVertex[] List<VectorImageVertex> Pointer )
            value.Indices                                   = GetUInt16List(new IntPtr(p + 0x030)); // 0245A681B560 0x30 Indices                     ( 000185CAEC08 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.Settings                                  = GetEnumList<GradientSettings>(new IntPtr(p + 0x038)); // 0245A681B580 0x38 Settings                    ( 000185B832A0 ModelEnumListType GradientSettings[] GradientSettings[] List<GradientSettings> Pointer )
            value.Size                                      = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0245A681B5A0 0x40 Size                        ( 0001866A8240 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
