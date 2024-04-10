using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 current                                  IOThreadScheduler IL2CPP_TYPE_CLASS
    // 010 Overlapped                               0001865B0330 ModelClassType ScheduledOverlapped ScheduledOverlapped ScheduledOverlapped Pointer
    // 018 Slots                                    000185CBC138 ModelEnumListType Slot[] Slot[] List<Slot> Pointer
    // 020 SlotsLowPri                              000185CBC138 ModelEnumListType Slot[] Slot[] List<Slot> Pointer
    // 028 HeadTail                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C HeadTailLowPri                           0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Overlapped                                = GetObject<ScheduledOverlapped>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScheduledOverlapped.FromPointer); // 02466BAB2AF8 0x10 Overlapped                  ( 0001865B0330 ModelClassType ScheduledOverlapped ScheduledOverlapped ScheduledOverlapped Pointer )
            value.Slots                                     = GetEnumList<Slot>(new IntPtr(p + 0x018)); // 02466BAB2B18 0x18 Slots                       ( 000185CBC138 ModelEnumListType Slot[] Slot[] List<Slot> Pointer )
            value.SlotsLowPri                               = GetEnumList<Slot>(new IntPtr(p + 0x020)); // 02466BAB2B38 0x20 SlotsLowPri                 ( 000185CBC138 ModelEnumListType Slot[] Slot[] List<Slot> Pointer )
            value.HeadTail                                  = GetInt32(new IntPtr(p + 0x028)); // 02466BAB2B58 0x28 HeadTail                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HeadTailLowPri                            = GetInt32(new IntPtr(p + 0x02C)); // 02466BAB2B78 0x2C HeadTailLowPri              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
