using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventBreakTimeOptionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PeriodFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Period                                   ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 IsSelectableFieldNumber                  int IL2CPP_TYPE_I4
    // 020 IsSelectable                             ModelPrimitiveType bool bool bool Bool
    // 000 IsSelectedFieldNumber                    int IL2CPP_TYPE_I4
    // 021 IsSelected                               ModelPrimitiveType bool bool bool Bool
    public partial class EventBreakTimeOptionStatus : DataModel
    {
        public PeriodStatus?                            Period                                  { get; set; }
        public bool                                     IsSelectable                            { get; set; }
        public bool                                     IsSelected                              { get; set; }

        public static EventBreakTimeOptionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventBreakTimeOptionStatus() { Pointer= p0 };

            value.Period                                    = GetObject<PeriodStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x18 Period                      ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.IsSelectable                              = GetBool(new IntPtr(p + 0x020)); // 0x20 IsSelectable                ( ModelPrimitiveType bool bool bool Bool )
            value.IsSelected                                = GetBool(new IntPtr(p + 0x021)); // 0x21 IsSelected                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
