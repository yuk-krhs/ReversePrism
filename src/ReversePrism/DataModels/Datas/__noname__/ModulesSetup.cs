using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShowPanel                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 AudioEnabled                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 PhysicsEnabled                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 013 Physics2DEnabled                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 SpriteEnabled                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 015 UiEnabled                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 016 TextMeshProEnabled                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 017 Tk2DEnabled                              000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ModulesSetup : DataModel
    {
        public bool                                     ShowPanel                               { get; set; }
        public bool                                     AudioEnabled                            { get; set; }
        public bool                                     PhysicsEnabled                          { get; set; }
        public bool                                     Physics2DEnabled                        { get; set; }
        public bool                                     SpriteEnabled                           { get; set; }
        public bool                                     UiEnabled                               { get; set; }
        public bool                                     TextMeshProEnabled                      { get; set; }
        public bool                                     Tk2DEnabled                             { get; set; }

        public static ModulesSetup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModulesSetup() { Pointer= p0 };

            value.ShowPanel                                 = GetBool(new IntPtr(p + 0x010)); // 0245A43A9438 0x10 ShowPanel                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AudioEnabled                              = GetBool(new IntPtr(p + 0x011)); // 0245A43A9458 0x11 AudioEnabled                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PhysicsEnabled                            = GetBool(new IntPtr(p + 0x012)); // 0245A43A9478 0x12 PhysicsEnabled              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Physics2DEnabled                          = GetBool(new IntPtr(p + 0x013)); // 0245A43A9498 0x13 Physics2DEnabled            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SpriteEnabled                             = GetBool(new IntPtr(p + 0x014)); // 0245A43A94B8 0x14 SpriteEnabled               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UiEnabled                                 = GetBool(new IntPtr(p + 0x015)); // 0245A43A94D8 0x15 UiEnabled                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.TextMeshProEnabled                        = GetBool(new IntPtr(p + 0x016)); // 0245A43A94F8 0x16 TextMeshProEnabled          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Tk2DEnabled                               = GetBool(new IntPtr(p + 0x017)); // 0245A43A9518 0x17 Tk2DEnabled                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
