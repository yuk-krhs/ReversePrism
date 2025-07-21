using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   ModelPrimitiveType int int int Int32
    // 014 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 018 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 01C ProduceProgress                          ModelPrimitiveType int int int Int32
    // 020 ProduceProgressMax                       ModelPrimitiveType int int int Int32
    // 028 Rewards                                  IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    public partial class ProduceFailureResultRewardViewModel : DataModel
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
            var value   = new ProduceFailureResultRewardViewModel() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.ProduceProgress                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ProduceProgress             ( ModelPrimitiveType int int int Int32 )
            value.ProduceProgressMax                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 ProduceProgressMax          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
