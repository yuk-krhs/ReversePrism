using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dress                                    000186743530 ModelClassType ICostumeStatus ICostumeStatus ICostumeStatus Pointer
    // 018 Hairstyle                                0001865640E0 ModelClassType IHairstyleStatus IHairstyleStatus IHairstyleStatus Pointer
    // 020 Glasses                                  0001866EBCB0 ModelClassType IAccessoryStatus IAccessoryStatus IAccessoryStatus Pointer
    // 028 Earrings                                 0001866EBCB0 ModelClassType IAccessoryStatus IAccessoryStatus IAccessoryStatus Pointer
    // 030 Makeup                                   0001866EBCB0 ModelClassType IAccessoryStatus IAccessoryStatus IAccessoryStatus Pointer
    public partial class CharacterCostume : DataModel
    {
        public ICostumeStatus?                          Dress                                   { get; set; }
        public IHairstyleStatus?                        Hairstyle                               { get; set; }
        public IAccessoryStatus?                        Glasses                                 { get; set; }
        public IAccessoryStatus?                        Earrings                                { get; set; }
        public IAccessoryStatus?                        Makeup                                  { get; set; }

        public static CharacterCostume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterCostume() { Pointer= p0 };

            value.Dress                                     = GetObject<ICostumeStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICostumeStatus.FromPointer); // 024664D13328 0x10 Dress                       ( 000186743530 ModelClassType ICostumeStatus ICostumeStatus ICostumeStatus Pointer )
            value.Hairstyle                                 = GetObject<IHairstyleStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHairstyleStatus.FromPointer); // 024664D13348 0x18 Hairstyle                   ( 0001865640E0 ModelClassType IHairstyleStatus IHairstyleStatus IHairstyleStatus Pointer )
            value.Glasses                                   = GetObject<IAccessoryStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IAccessoryStatus.FromPointer); // 024664D13368 0x20 Glasses                     ( 0001866EBCB0 ModelClassType IAccessoryStatus IAccessoryStatus IAccessoryStatus Pointer )
            value.Earrings                                  = GetObject<IAccessoryStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IAccessoryStatus.FromPointer); // 024664D13388 0x28 Earrings                    ( 0001866EBCB0 ModelClassType IAccessoryStatus IAccessoryStatus IAccessoryStatus Pointer )
            value.Makeup                                    = GetObject<IAccessoryStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IAccessoryStatus.FromPointer); // 024664D133A8 0x30 Makeup                      ( 0001866EBCB0 ModelClassType IAccessoryStatus IAccessoryStatus IAccessoryStatus Pointer )

            return value;
        }
    }
}
