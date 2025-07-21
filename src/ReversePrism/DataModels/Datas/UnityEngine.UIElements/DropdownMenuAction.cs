using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Status                                   ModelEnumType Status Status Status Int32
    // 020 EventInfo                                ModelClassType DropdownMenuEventInfo DropdownMenuEventInfo DropdownMenuEventInfo Pointer
    // 028 <userData>k__BackingField                <object> IL2CPP_TYPE_OBJECT
    // 030 actionCallback                           Action`1<DropdownMenuAction> IL2CPP_TYPE_GENERICINST
    // 038 actionStatusCallback                     Func`2<DropdownMenuAction, Status> IL2CPP_TYPE_GENERICINST
    public partial class DropdownMenuAction : DataModel
    {
        public string                                   Name                                    { get; set; }
        public Status                                   Status                                  { get; set; }
        public DropdownMenuEventInfo?                   EventInfo                               { get; set; }

        public static DropdownMenuAction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropdownMenuAction() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x018)); // 0x18 Status                      ( ModelEnumType Status Status Status Int32 )
            value.EventInfo                                 = GetObject<DropdownMenuEventInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.DropdownMenuEventInfo.FromPointer); // 0x20 EventInfo                   ( ModelClassType DropdownMenuEventInfo DropdownMenuEventInfo DropdownMenuEventInfo Pointer )

            return value;
        }
    }
}
