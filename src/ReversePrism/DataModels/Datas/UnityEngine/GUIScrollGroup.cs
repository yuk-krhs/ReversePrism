using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CalcMinWidth                             000186666050 ModelPrimitiveType float float float Single
    // 094 CalcMaxWidth                             000186666050 ModelPrimitiveType float float float Single
    // 098 CalcMinHeight                            000186666050 ModelPrimitiveType float float float Single
    // 09C CalcMaxHeight                            000186666050 ModelPrimitiveType float float float Single
    // 0A0 ClientWidth                              000186666050 ModelPrimitiveType float float float Single
    // 0A4 ClientHeight                             000186666050 ModelPrimitiveType float float float Single
    // 0A8 AllowHorizontalScroll                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A9 AllowVerticalScroll                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 0AA NeedsHorizontalScrollbar                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 0AB NeedsVerticalScrollbar                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B0 HorizontalScrollbar                      0001865DF030 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0B8 VerticalScrollbar                        0001865DF030 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    public partial class GUIScrollGroup : DataModel
    {
        public float                                    CalcMinWidth                            { get; set; }
        public float                                    CalcMaxWidth                            { get; set; }
        public float                                    CalcMinHeight                           { get; set; }
        public float                                    CalcMaxHeight                           { get; set; }
        public float                                    ClientWidth                             { get; set; }
        public float                                    ClientHeight                            { get; set; }
        public bool                                     AllowHorizontalScroll                   { get; set; }
        public bool                                     AllowVerticalScroll                     { get; set; }
        public bool                                     NeedsHorizontalScrollbar                { get; set; }
        public bool                                     NeedsVerticalScrollbar                  { get; set; }
        public GUIStyle?                                HorizontalScrollbar                     { get; set; }
        public GUIStyle?                                VerticalScrollbar                       { get; set; }

        public static GUIScrollGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIScrollGroup() { Pointer= p0 };

            value.CalcMinWidth                              = GetSingle(new IntPtr(p + 0x090)); // 0245A21D2190 0x90 CalcMinWidth                ( 000186666050 ModelPrimitiveType float float float Single )
            value.CalcMaxWidth                              = GetSingle(new IntPtr(p + 0x094)); // 0245A21D21B0 0x94 CalcMaxWidth                ( 000186666050 ModelPrimitiveType float float float Single )
            value.CalcMinHeight                             = GetSingle(new IntPtr(p + 0x098)); // 0245A21D21D0 0x98 CalcMinHeight               ( 000186666050 ModelPrimitiveType float float float Single )
            value.CalcMaxHeight                             = GetSingle(new IntPtr(p + 0x09C)); // 0245A21D21F0 0x9C CalcMaxHeight               ( 000186666050 ModelPrimitiveType float float float Single )
            value.ClientWidth                               = GetSingle(new IntPtr(p + 0x0A0)); // 0245A21D2210 0xA0 ClientWidth                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.ClientHeight                              = GetSingle(new IntPtr(p + 0x0A4)); // 0245A21D2230 0xA4 ClientHeight                ( 000186666050 ModelPrimitiveType float float float Single )
            value.AllowHorizontalScroll                     = GetBool(new IntPtr(p + 0x0A8)); // 0245A21D2250 0xA8 AllowHorizontalScroll       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AllowVerticalScroll                       = GetBool(new IntPtr(p + 0x0A9)); // 0245A21D2270 0xA9 AllowVerticalScroll         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedsHorizontalScrollbar                  = GetBool(new IntPtr(p + 0x0AA)); // 0245A21D2290 0xAA NeedsHorizontalScrollbar    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedsVerticalScrollbar                    = GetBool(new IntPtr(p + 0x0AB)); // 0245A21D22B0 0xAB NeedsVerticalScrollbar      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HorizontalScrollbar                       = GetObject<GUIStyle>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GUIStyle.FromPointer); // 0245A21D22D0 0xB0 HorizontalScrollbar         ( 0001865DF030 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.VerticalScrollbar                         = GetObject<GUIStyle>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GUIStyle.FromPointer); // 0245A21D22F0 0xB8 VerticalScrollbar           ( 0001865DF030 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )

            return value;
        }
    }
}
