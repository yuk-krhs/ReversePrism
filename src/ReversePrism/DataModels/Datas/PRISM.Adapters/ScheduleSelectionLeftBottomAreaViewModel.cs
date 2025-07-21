using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceParameter                    ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 018 CacheProduceBaseInfo                     ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 CacheFanCount                            ModelPrimitiveType int int int Int32
    public partial class ScheduleSelectionLeftBottomAreaViewModel : DataModel
    {
        public IProduceParameterStatus?                 CacheProduceParameter                   { get; set; }
        public IProduceBaseInfoStatus?                  CacheProduceBaseInfo                    { get; set; }
        public int                                      CacheFanCount                           { get; set; }

        public static ScheduleSelectionLeftBottomAreaViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftBottomAreaViewModel() { Pointer= p0 };

            value.CacheProduceParameter                     = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x10 CacheProduceParameter       ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x18 CacheProduceBaseInfo        ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.CacheFanCount                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 CacheFanCount               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
