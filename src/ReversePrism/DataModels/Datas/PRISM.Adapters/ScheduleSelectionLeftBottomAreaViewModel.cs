using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceParameter                    0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 018 CacheProduceBaseInfo                     0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 CacheFanCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ScheduleSelectionLeftBottomAreaViewModel
    {
        public IProduceParameterStatus?                 CacheProduceParameter                   { get; set; }
        public IProduceBaseInfoStatus?                  CacheProduceBaseInfo                    { get; set; }
        public int                                      CacheFanCount                           { get; set; }

        public static ScheduleSelectionLeftBottomAreaViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionLeftBottomAreaViewModel();

            value.CacheProduceParameter                     = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D5E41CA8 0x10 CacheProduceParameter       ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0270D5E41CC8 0x18 CacheProduceBaseInfo        ( 0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.CacheFanCount                             = GetInt32(new IntPtr(p + 0x020)); // 0270D5E41CE8 0x20 CacheFanCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
