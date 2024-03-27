using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Text                                     000186672F10 ModelPrimitiveType string string string String
    // 028 <fontSize>k__BackingField                Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 030 BgColor                                  0001865ABA40 ModelEnumType Color Color Color Int32
    // 040 SpriteName                               000186672F10 ModelPrimitiveType string string string String
    // 048 Padding                                  0001866AF290 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 058 Attributes                               000185CCDA78 ModelEnumListType List`1<Attribute> List`1<Attribute> List<Attribute> Pointer
    public partial class XMLTextItemParam
    {
        public string                                   Text                                    { get; set; }
        public Color                                    BgColor                                 { get; set; }
        public string                                   SpriteName                              { get; set; }
        public Vector4                                  Padding                                 { get; set; }
        public List<Attribute>?                         Attributes                              { get; set; }

        public static XMLTextItemParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLTextItemParam();

            value.Text                                      = GetString(new IntPtr(p + 0x020)); // 0270D4B4DB60 0x20 Text                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.BgColor                                   = (Color)GetInt32(new IntPtr(p + 0x030)); // 0270D4B4DBA0 0x30 BgColor                     ( 0001865ABA40 ModelEnumType Color Color Color Int32 )
            value.SpriteName                                = GetString(new IntPtr(p + 0x040)); // 0270D4B4DBC0 0x40 SpriteName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Padding                                   = (Vector4)GetInt32(new IntPtr(p + 0x048)); // 0270D4B4DBE0 0x48 Padding                     ( 0001866AF290 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Attributes                                = GetEnumList<Attribute>(new IntPtr(p + 0x058)); // 0270D4B4DC00 0x58 Attributes                  ( 000185CCDA78 ModelEnumListType List`1<Attribute> List`1<Attribute> List<Attribute> Pointer )

            return value;
        }
    }
}
