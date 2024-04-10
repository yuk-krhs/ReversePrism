using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourInGameCardActionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PhaseChangeCountFieldNumber              int IL2CPP_TYPE_I4
    // 018 PhaseChangeCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CostOneCardUseCountFieldNumber           int IL2CPP_TYPE_I4
    // 01C CostOneCardUseCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardCostDownCountFieldNumber             int IL2CPP_TYPE_I4
    // 020 CardCostDownCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardExcludeCountFieldNumber              int IL2CPP_TYPE_I4
    // 024 CardExcludeCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourInGameCardActionStatus : DataModel
    {
        public int                                      PhaseChangeCount                        { get; set; }
        public int                                      CostOneCardUseCount                     { get; set; }
        public int                                      CardCostDownCount                       { get; set; }
        public int                                      CardExcludeCount                        { get; set; }

        public static ChallengeTourInGameCardActionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameCardActionStatus() { Pointer= p0 };

            value.PhaseChangeCount                          = GetInt32(new IntPtr(p + 0x018)); // 024660ECFEE0 0x18 PhaseChangeCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CostOneCardUseCount                       = GetInt32(new IntPtr(p + 0x01C)); // 024660ECFF20 0x1C CostOneCardUseCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardCostDownCount                         = GetInt32(new IntPtr(p + 0x020)); // 024660ECFF60 0x20 CardCostDownCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardExcludeCount                          = GetInt32(new IntPtr(p + 0x024)); // 024660ECFFA0 0x24 CardExcludeCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
