using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Mode                                   000186509B00 ModelEnumType Mode Mode Mode Int32
    // 014 M_WrapAround                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_SelectOnUp                             00018671EC20 ModelClassType Selectable Selectable Selectable Pointer
    // 020 M_SelectOnDown                           00018671EC20 ModelClassType Selectable Selectable Selectable Pointer
    // 028 M_SelectOnLeft                           00018671EC20 ModelClassType Selectable Selectable Selectable Pointer
    // 030 M_SelectOnRight                          00018671EC20 ModelClassType Selectable Selectable Selectable Pointer
    public partial class Navigation : DataModel
    {
        public Mode                                     M_Mode                                  { get; set; }
        public bool                                     M_WrapAround                            { get; set; }
        public Selectable?                              M_SelectOnUp                            { get; set; }
        public Selectable?                              M_SelectOnDown                          { get; set; }
        public Selectable?                              M_SelectOnLeft                          { get; set; }
        public Selectable?                              M_SelectOnRight                         { get; set; }

        public static Navigation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Navigation() { Pointer= p0 };

            value.M_Mode                                    = (Mode)GetInt32(new IntPtr(p + 0x010)); // 024660A781D8 0x10 M_Mode                      ( 000186509B00 ModelEnumType Mode Mode Mode Int32 )
            value.M_WrapAround                              = GetBool(new IntPtr(p + 0x014)); // 024660A781F8 0x14 M_WrapAround                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SelectOnUp                              = GetObject<Selectable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Selectable.FromPointer); // 024660A78218 0x18 M_SelectOnUp                ( 00018671EC20 ModelClassType Selectable Selectable Selectable Pointer )
            value.M_SelectOnDown                            = GetObject<Selectable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Selectable.FromPointer); // 024660A78238 0x20 M_SelectOnDown              ( 00018671EC20 ModelClassType Selectable Selectable Selectable Pointer )
            value.M_SelectOnLeft                            = GetObject<Selectable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Selectable.FromPointer); // 024660A78258 0x28 M_SelectOnLeft              ( 00018671EC20 ModelClassType Selectable Selectable Selectable Pointer )
            value.M_SelectOnRight                           = GetObject<Selectable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Selectable.FromPointer); // 024660A78278 0x30 M_SelectOnRight             ( 00018671EC20 ModelClassType Selectable Selectable Selectable Pointer )

            return value;
        }
    }
}
