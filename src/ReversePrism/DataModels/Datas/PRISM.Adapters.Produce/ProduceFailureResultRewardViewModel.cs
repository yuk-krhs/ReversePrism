using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 014 ScheduleDetailType                       000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 018 ScheduleLevel                            0001865F4940 ModelPrimitiveType int int int Int32
    // 01C ProduceProgress                          0001865F4940 ModelPrimitiveType int int int Int32
    // 020 ProduceProgressMax                       0001865F4940 ModelPrimitiveType int int int Int32
    // 028 Rewards                                  IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    public partial class ProduceFailureResultRewardViewModel
    {
        public int                                      UnitID                                  { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public int                                      ProduceProgress                         { get; set; }
        public int                                      ProduceProgressMax                      { get; set; }

        public static ProduceFailureResultRewardViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultRewardViewModel();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D681F350 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 0270D681F370 0x14 ScheduleDetailType          ( 000186615580 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0270D681F390 0x18 ScheduleLevel               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceProgress                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D681F3B0 0x1C ProduceProgress             ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProduceProgressMax                        = GetInt32(new IntPtr(p + 0x020)); // 0270D681F3D0 0x20 ProduceProgressMax          ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
