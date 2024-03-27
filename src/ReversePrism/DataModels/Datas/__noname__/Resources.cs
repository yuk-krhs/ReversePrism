using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Standard                                 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 018 Background                               00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 020 InputField                               00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 028 Knob                                     00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 030 Checkmark                                00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 038 Dropdown                                 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 040 Mask                                     00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    public partial class Resources
    {
        public Sprite?                                  Standard                                { get; set; }
        public Sprite?                                  Background                              { get; set; }
        public Sprite?                                  InputField                              { get; set; }
        public Sprite?                                  Knob                                    { get; set; }
        public Sprite?                                  Checkmark                               { get; set; }
        public Sprite?                                  Dropdown                                { get; set; }
        public Sprite?                                  Mask                                    { get; set; }

        public static Resources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Resources();

            value.Standard                                  = GetObject<Sprite>(new IntPtr(p + 0x010), ReversePrism.DataModels.Sprite.FromPointer); // 0270068D9DE8 0x10 Standard                    ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.Background                                = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0270068D9E08 0x18 Background                  ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.InputField                                = GetObject<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 0270068D9E28 0x20 InputField                  ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.Knob                                      = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0270068D9E48 0x28 Knob                        ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.Checkmark                                 = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0270068D9E68 0x30 Checkmark                   ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.Dropdown                                  = GetObject<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0270068D9E88 0x38 Dropdown                    ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.Mask                                      = GetObject<Sprite>(new IntPtr(p + 0x040), ReversePrism.DataModels.Sprite.FromPointer); // 0270068D9EA8 0x40 Mask                        ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
