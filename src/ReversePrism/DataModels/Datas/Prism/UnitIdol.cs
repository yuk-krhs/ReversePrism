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
    public partial class UnitIdol : DataModel
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
            var value   = new UnitIdol() { Pointer= p0 };

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 024660BE5960 0x10 CharaId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ClothId                                   = GetInt32(new IntPtr(p + 0x014)); // 024660BE5980 0x14 ClothId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HairId                                    = GetInt32(new IntPtr(p + 0x018)); // 024660BE59A0 0x18 HairId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AccessoryIds                              = GetInt32List(new IntPtr(p + 0x020)); // 024660BE59C0 0x20 AccessoryIds                ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x028)); // 024660BE59E0 0x28 IconId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
