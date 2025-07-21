using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Type                                     ModelClassType Type Type Type Pointer
    // 068 ComponentClass                           ModelClassType Type Type Type Pointer
    // 070 AddMethod                                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 078 RemoveMethod                             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 RealEvent                                ModelClassType EventInfo EventInfo EventInfo Pointer
    // 088 FilledMethods                            ModelPrimitiveType bool bool bool Bool
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

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0x60 Type                        ( ModelClassType Type Type Type Pointer )
            value.ComponentClass                            = GetObject<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 0x68 ComponentClass              ( ModelClassType Type Type Type Pointer )
            value.AddMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x70 AddMethod                   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.RemoveMethod                              = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x78 RemoveMethod                ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.RealEvent                                 = GetObject<EventInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.EventInfo.FromPointer); // 0x80 RealEvent                   ( ModelClassType EventInfo EventInfo EventInfo Pointer )
            value.FilledMethods                             = GetBool(new IntPtr(p + 0x088)); // 0x88 FilledMethods               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
