using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShowPanel                                ModelPrimitiveType bool bool bool Bool
    // 011 AudioEnabled                             ModelPrimitiveType bool bool bool Bool
    // 012 PhysicsEnabled                           ModelPrimitiveType bool bool bool Bool
    // 013 Physics2DEnabled                         ModelPrimitiveType bool bool bool Bool
    // 014 SpriteEnabled                            ModelPrimitiveType bool bool bool Bool
    // 015 UiEnabled                                ModelPrimitiveType bool bool bool Bool
    // 016 TextMeshProEnabled                       ModelPrimitiveType bool bool bool Bool
    // 017 Tk2DEnabled                              ModelPrimitiveType bool bool bool Bool
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

            value.ShowPanel                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 ShowPanel                   ( ModelPrimitiveType bool bool bool Bool )
            value.AudioEnabled                              = GetBool(new IntPtr(p + 0x011)); // 0x11 AudioEnabled                ( ModelPrimitiveType bool bool bool Bool )
            value.PhysicsEnabled                            = GetBool(new IntPtr(p + 0x012)); // 0x12 PhysicsEnabled              ( ModelPrimitiveType bool bool bool Bool )
            value.Physics2DEnabled                          = GetBool(new IntPtr(p + 0x013)); // 0x13 Physics2DEnabled            ( ModelPrimitiveType bool bool bool Bool )
            value.SpriteEnabled                             = GetBool(new IntPtr(p + 0x014)); // 0x14 SpriteEnabled               ( ModelPrimitiveType bool bool bool Bool )
            value.UiEnabled                                 = GetBool(new IntPtr(p + 0x015)); // 0x15 UiEnabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.TextMeshProEnabled                        = GetBool(new IntPtr(p + 0x016)); // 0x16 TextMeshProEnabled          ( ModelPrimitiveType bool bool bool Bool )
            value.Tk2DEnabled                               = GetBool(new IntPtr(p + 0x017)); // 0x17 Tk2DEnabled                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
