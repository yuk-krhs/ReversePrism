using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ClothId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 HairId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 AccessoryIds                             000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 IconId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class UnitIdol
    {
        public int                                      CharaId                                 { get; set; }
        public int                                      ClothId                                 { get; set; }
        public int                                      HairId                                  { get; set; }
        public List<int>?                               AccessoryIds                            { get; set; }
        public int                                      IconId                                  { get; set; }

        public static UnitIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitIdol();

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D0CC38C8 0x10 CharaId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ClothId                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D0CC38E8 0x14 ClothId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HairId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D0CC3908 0x18 HairId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AccessoryIds                              = GetInt32List(new IntPtr(p + 0x020)); // 0270D0CC3928 0x20 AccessoryIds                ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D0CC3948 0x28 IconId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
