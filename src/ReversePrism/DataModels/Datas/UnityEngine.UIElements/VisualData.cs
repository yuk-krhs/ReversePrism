using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BackgroundColor                          0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 BackgroundImage                          000186733F40 ModelEnumType Background Background Background Int32
    // 040 BackgroundPositionX                      00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 04C BackgroundPositionY                      00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 058 BackgroundRepeat                         000186590710 ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32
    // 060 BackgroundSize                           0001865913C0 ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32
    // 074 BorderBottomColor                        0001865AB0A0 ModelEnumType Color Color Color Int32
    // 084 BorderBottomLeftRadius                   0001866063F0 ModelEnumType Length Length Length Int32
    // 08C BorderBottomRightRadius                  0001866063F0 ModelEnumType Length Length Length Int32
    // 094 BorderLeftColor                          0001865AB0A0 ModelEnumType Color Color Color Int32
    // 0A4 BorderRightColor                         0001865AB0A0 ModelEnumType Color Color Color Int32
    // 0B4 BorderTopColor                           0001865AB0A0 ModelEnumType Color Color Color Int32
    // 0C4 BorderTopLeftRadius                      0001866063F0 ModelEnumType Length Length Length Int32
    // 0CC BorderTopRightRadius                     0001866063F0 ModelEnumType Length Length Length Int32
    // 0D4 Opacity                                  000186666050 ModelPrimitiveType float float float Single
    // 0D8 Overflow                                 0001866FDB40 ModelEnumType OverflowInternal OverflowInternal OverflowInternal Int32
    public partial class VisualData
    {
        public Color                                    BackgroundColor                         { get; set; }
        public Background                               BackgroundImage                         { get; set; }
        public BackgroundPosition                       BackgroundPositionX                     { get; set; }
        public BackgroundPosition                       BackgroundPositionY                     { get; set; }
        public BackgroundRepeat                         BackgroundRepeat                        { get; set; }
        public BackgroundSize                           BackgroundSize                          { get; set; }
        public Color                                    BorderBottomColor                       { get; set; }
        public Length                                   BorderBottomLeftRadius                  { get; set; }
        public Length                                   BorderBottomRightRadius                 { get; set; }
        public Color                                    BorderLeftColor                         { get; set; }
        public Color                                    BorderRightColor                        { get; set; }
        public Color                                    BorderTopColor                          { get; set; }
        public Length                                   BorderTopLeftRadius                     { get; set; }
        public Length                                   BorderTopRightRadius                    { get; set; }
        public float                                    Opacity                                 { get; set; }
        public OverflowInternal                         Overflow                                { get; set; }

        public static VisualData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualData();

            value.BackgroundColor                           = (Color)GetInt32(new IntPtr(p + 0x010)); // 027003F2D1A0 0x10 BackgroundColor             ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BackgroundImage                           = (Background)GetInt32(new IntPtr(p + 0x020)); // 027003F2D1C0 0x20 BackgroundImage             ( 000186733F40 ModelEnumType Background Background Background Int32 )
            value.BackgroundPositionX                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x040)); // 027003F2D1E0 0x40 BackgroundPositionX         ( 00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundPositionY                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x04C)); // 027003F2D200 0x4C BackgroundPositionY         ( 00018658F640 ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundRepeat                          = (BackgroundRepeat)GetInt32(new IntPtr(p + 0x058)); // 027003F2D220 0x58 BackgroundRepeat            ( 000186590710 ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32 )
            value.BackgroundSize                            = (BackgroundSize)GetInt32(new IntPtr(p + 0x060)); // 027003F2D240 0x60 BackgroundSize              ( 0001865913C0 ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32 )
            value.BorderBottomColor                         = (Color)GetInt32(new IntPtr(p + 0x074)); // 027003F2D260 0x74 BorderBottomColor           ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BorderBottomLeftRadius                    = (Length)GetInt32(new IntPtr(p + 0x084)); // 027003F2D280 0x84 BorderBottomLeftRadius      ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.BorderBottomRightRadius                   = (Length)GetInt32(new IntPtr(p + 0x08C)); // 027003F2D2A0 0x8C BorderBottomRightRadius     ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.BorderLeftColor                           = (Color)GetInt32(new IntPtr(p + 0x094)); // 027003F2D2C0 0x94 BorderLeftColor             ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BorderRightColor                          = (Color)GetInt32(new IntPtr(p + 0x0A4)); // 027003F2D2E0 0xA4 BorderRightColor            ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BorderTopColor                            = (Color)GetInt32(new IntPtr(p + 0x0B4)); // 027003F2D300 0xB4 BorderTopColor              ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BorderTopLeftRadius                       = (Length)GetInt32(new IntPtr(p + 0x0C4)); // 027003F2D320 0xC4 BorderTopLeftRadius         ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.BorderTopRightRadius                      = (Length)GetInt32(new IntPtr(p + 0x0CC)); // 027003F2D340 0xCC BorderTopRightRadius        ( 0001866063F0 ModelEnumType Length Length Length Int32 )
            value.Opacity                                   = GetSingle(new IntPtr(p + 0x0D4)); // 027003F2D360 0xD4 Opacity                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.Overflow                                  = (OverflowInternal)GetInt32(new IntPtr(p + 0x0D8)); // 027003F2D380 0xD8 Overflow                    ( 0001866FDB40 ModelEnumType OverflowInternal OverflowInternal OverflowInternal Int32 )

            return value;
        }
    }
}
