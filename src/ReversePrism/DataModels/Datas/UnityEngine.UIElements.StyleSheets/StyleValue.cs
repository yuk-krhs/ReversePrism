using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865C9B00 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    // 014 Keyword                                  0001865C82A0 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    // 018 Number                                   000186666050 ModelPrimitiveType float float float Single
    // 018 Length                                   0001866063F0 ModelEnumType Length Length Length Int32
    // 018 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 018 Resource                                 0001865D93A0 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 018 Position                                 00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 018 Repeat                                   000186590710 ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32
    public partial class StyleValue
    {
        public StylePropertyId                          Id                                      { get; set; }
        public StyleKeyword                             Keyword                                 { get; set; }
        public float                                    Number                                  { get; set; }
        public Length                                   Length                                  { get; set; }
        public Color                                    Color                                   { get; set; }
        public GCHandle                                 Resource                                { get; set; }
        public BackgroundPosition                       Position                                { get; set; }
        public BackgroundRepeat                         Repeat                                  { get; set; }

        public static StyleValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleValue();

            value.Id                                        = (StylePropertyId)GetInt32(new IntPtr(p + 0x010)); // 027006886E70 0x10 Id                          ( 0001865C9B00 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )
            value.Keyword                                   = (StyleKeyword)GetInt32(new IntPtr(p + 0x014)); // 027006886E90 0x14 Keyword                     ( 0001865C82A0 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )
            value.Number                                    = GetSingle(new IntPtr(p + 0x018)); // 027006886EB0 0x18 Number                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Length                                    = (Length)GetInt32(new IntPtr(p + 0x018)); // 027006886ED0 0x18 Length                      ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x018)); // 027006886EF0 0x18 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.Resource                                  = (GCHandle)GetInt32(new IntPtr(p + 0x018)); // 027006886F10 0x18 Resource                    ( 0001865D93A0 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.Position                                  = (BackgroundPosition)GetInt32(new IntPtr(p + 0x018)); // 027006886F30 0x18 Position                    ( 00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.Repeat                                    = (BackgroundRepeat)GetInt32(new IntPtr(p + 0x018)); // 027006886F50 0x18 Repeat                      ( 000186590710 ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32 )

            return value;
        }
    }
}
