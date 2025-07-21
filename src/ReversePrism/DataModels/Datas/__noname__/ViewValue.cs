using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewType                                 ModelClassType Type Type Type Pointer
    // 018 Parameter                                ModelClassType IViewParameter IViewParameter IViewParameter Pointer
    // 020 IsFade                                   ModelPrimitiveType bool bool bool Bool
    public partial class ViewValue : DataModel
    {
        public Type?                                    ViewType                                { get; set; }
        public IViewParameter?                          Parameter                               { get; set; }
        public bool                                     IsFade                                  { get; set; }

        public static ViewValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewValue() { Pointer= p0 };

            value.ViewType                                  = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 ViewType                    ( ModelClassType Type Type Type Pointer )
            value.Parameter                                 = GetObject<IViewParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.IViewParameter.FromPointer); // 0x18 Parameter                   ( ModelClassType IViewParameter IViewParameter IViewParameter Pointer )
            value.IsFade                                    = GetBool(new IntPtr(p + 0x020)); // 0x20 IsFade                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
