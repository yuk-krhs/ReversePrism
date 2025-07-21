using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentsType                             ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 014 MstId                                    ModelPrimitiveType int int int Int32
    // 018 Rarity                                   ModelPrimitiveType int int int Int32
    // 01C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 020 NormalRate                               ModelPrimitiveType float float float Single
    // 024 PromiseRate                              ModelPrimitiveType float float float Single
    // 028 IsPickUp                                 ModelPrimitiveType bool bool bool Bool
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

            value.ContentsType                              = (GashaContentsType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ContentsType                ( ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstId                       ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.NormalRate                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 NormalRate                  ( ModelPrimitiveType float float float Single )
            value.PromiseRate                               = GetSingle(new IntPtr(p + 0x024)); // 0x24 PromiseRate                 ( ModelPrimitiveType float float float Single )
            value.IsPickUp                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 IsPickUp                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
