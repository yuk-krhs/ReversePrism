using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Chara_id                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Cloth_id                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Hair_id                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Accessory_ids                            000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 Icon_id                                  0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class UnitIdolData
    {
        public int                                      Chara_id                                { get; set; }
        public int                                      Cloth_id                                { get; set; }
        public int                                      Hair_id                                 { get; set; }
        public List<int>?                               Accessory_ids                           { get; set; }
        public int                                      Icon_id                                 { get; set; }

        public static UnitIdolData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitIdolData();

            value.Chara_id                                  = GetInt32(new IntPtr(p + 0x010)); // 02700608F6D8 0x10 Chara_id                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Cloth_id                                  = GetInt32(new IntPtr(p + 0x014)); // 02700608F6F8 0x14 Cloth_id                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Hair_id                                   = GetInt32(new IntPtr(p + 0x018)); // 02700608F718 0x18 Hair_id                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Accessory_ids                             = GetInt32List(new IntPtr(p + 0x020)); // 02700608F738 0x20 Accessory_ids               ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Icon_id                                   = GetInt32(new IntPtr(p + 0x028)); // 02700608F758 0x28 Icon_id                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
