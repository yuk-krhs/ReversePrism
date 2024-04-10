using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentsType                             0001865F7B00 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 014 MstId                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 NormalRate                               000186666CB0 ModelPrimitiveType float float float Single
    // 024 PromiseRate                              000186666CB0 ModelPrimitiveType float float float Single
    // 028 IsPickUp                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class StepUpRateModel : DataModel
    {
        public GashaContentsType                        ContentsType                            { get; set; }
        public int                                      MstId                                   { get; set; }
        public int                                      Rarity                                  { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public float                                    NormalRate                              { get; set; }
        public float                                    PromiseRate                             { get; set; }
        public bool                                     IsPickUp                                { get; set; }

        public static StepUpRateModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpRateModel() { Pointer= p0 };

            value.ContentsType                              = (GashaContentsType)GetInt32(new IntPtr(p + 0x010)); // 02466545BA68 0x10 ContentsType                ( 0001865F7B00 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x014)); // 02466545BA88 0x14 MstId                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x018)); // 02466545BAA8 0x18 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 02466545BAC8 0x1C MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NormalRate                                = GetSingle(new IntPtr(p + 0x020)); // 02466545BAE8 0x20 NormalRate                  ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.PromiseRate                               = GetSingle(new IntPtr(p + 0x024)); // 02466545BB08 0x24 PromiseRate                 ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.IsPickUp                                  = GetBool(new IntPtr(p + 0x028)); // 02466545BB28 0x28 IsPickUp                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
