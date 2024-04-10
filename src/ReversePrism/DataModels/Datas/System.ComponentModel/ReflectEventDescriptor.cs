using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 068 ComponentClass                           0001866936B0 ModelClassType Type Type Type Pointer
    // 070 AddMethod                                000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 078 RemoveMethod                             000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 RealEvent                                0001867599C0 ModelClassType EventInfo EventInfo EventInfo Pointer
    // 088 FilledMethods                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ReflectEventDescriptor : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public Type?                                    ComponentClass                          { get; set; }
        public MethodInfo?                              AddMethod                               { get; set; }
        public MethodInfo?                              RemoveMethod                            { get; set; }
        public EventInfo?                               RealEvent                               { get; set; }
        public bool                                     FilledMethods                           { get; set; }

        public static ReflectEventDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectEventDescriptor() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 024667BA14D0 0x60 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.ComponentClass                            = GetObject<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 024667BA14F0 0x68 ComponentClass              ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.AddMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 024667BA1510 0x70 AddMethod                   ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.RemoveMethod                              = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 024667BA1530 0x78 RemoveMethod                ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.RealEvent                                 = GetObject<EventInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.EventInfo.FromPointer); // 024667BA1550 0x80 RealEvent                   ( 0001867599C0 ModelClassType EventInfo EventInfo EventInfo Pointer )
            value.FilledMethods                             = GetBool(new IntPtr(p + 0x088)); // 024667BA1570 0x88 FilledMethods               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
