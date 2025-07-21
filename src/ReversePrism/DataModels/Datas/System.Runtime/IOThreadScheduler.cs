using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 current                                  IOThreadScheduler IL2CPP_TYPE_CLASS
    // 010 Overlapped                               ModelClassType ScheduledOverlapped ScheduledOverlapped ScheduledOverlapped Pointer
    // 018 Slots                                    ModelEnumListType Slot[] Slot[] List<Slot> Pointer
    // 020 SlotsLowPri                              ModelEnumListType Slot[] Slot[] List<Slot> Pointer
    // 028 HeadTail                                 ModelPrimitiveType int int int Int32
    // 02C HeadTailLowPri                           ModelPrimitiveType int int int Int32
    public partial class IOThreadScheduler : DataModel
    {
        public ScheduledOverlapped?                     Overlapped                              { get; set; }
        public List<Slot>?                              Slots                                   { get; set; }
        public List<Slot>?                              SlotsLowPri                             { get; set; }
        public int                                      HeadTail                                { get; set; }
        public int                                      HeadTailLowPri                          { get; set; }

        public static IOThreadScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IOThreadScheduler() { Pointer= p0 };

            value.Overlapped                                = GetObject<ScheduledOverlapped>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScheduledOverlapped.FromPointer); // 0x10 Overlapped                  ( ModelClassType ScheduledOverlapped ScheduledOverlapped ScheduledOverlapped Pointer )
            value.Slots                                     = GetEnumList<Slot>(new IntPtr(p + 0x018)); // 0x18 Slots                       ( ModelEnumListType Slot[] Slot[] List<Slot> Pointer )
            value.SlotsLowPri                               = GetEnumList<Slot>(new IntPtr(p + 0x020)); // 0x20 SlotsLowPri                 ( ModelEnumListType Slot[] Slot[] List<Slot> Pointer )
            value.HeadTail                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 HeadTail                    ( ModelPrimitiveType int int int Int32 )
            value.HeadTailLowPri                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C HeadTailLowPri              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
