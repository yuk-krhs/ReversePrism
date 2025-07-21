using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    // 014 Keyword                                  ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    // 018 Number                                   ModelPrimitiveType float float float Single
    // 018 Length                                   ModelEnumType Length Length Length Int32
    // 018 Color                                    ModelEnumType Color Color Color Int32
    // 018 Resource                                 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 018 Position                                 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 018 Repeat                                   ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32
    public partial class StyleValue : DataModel
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
            var value   = new StyleValue() { Pointer= p0 };

            value.Id                                        = (StylePropertyId)GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )
            value.Keyword                                   = (StyleKeyword)GetInt32(new IntPtr(p + 0x014)); // 0x14 Keyword                     ( ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )
            value.Number                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 Number                      ( ModelPrimitiveType float float float Single )
            value.Length                                    = (Length)GetInt32(new IntPtr(p + 0x018)); // 0x18 Length                      ( ModelEnumType Length Length Length Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x018)); // 0x18 Color                       ( ModelEnumType Color Color Color Int32 )
            value.Resource                                  = (GCHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 Resource                    ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.Position                                  = (BackgroundPosition)GetInt32(new IntPtr(p + 0x018)); // 0x18 Position                    ( ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.Repeat                                    = (BackgroundRepeat)GetInt32(new IntPtr(p + 0x018)); // 0x18 Repeat                      ( ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32 )

            return value;
        }
    }
}
