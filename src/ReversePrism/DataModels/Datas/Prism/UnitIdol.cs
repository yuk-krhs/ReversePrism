using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  ModelPrimitiveType int int int Int32
    // 014 ClothId                                  ModelPrimitiveType int int int Int32
    // 018 HairId                                   ModelPrimitiveType int int int Int32
    // 020 AccessoryIds                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 IconId                                   ModelPrimitiveType int int int Int32
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

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.ClothId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 ClothId                     ( ModelPrimitiveType int int int Int32 )
            value.HairId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 HairId                      ( ModelPrimitiveType int int int Int32 )
            value.AccessoryIds                              = GetInt32List(new IntPtr(p + 0x020)); // 0x20 AccessoryIds                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 IconId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
