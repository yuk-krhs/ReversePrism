using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 018 Current                                  0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SingleAssignmentDisposable
    {
        public IDisposable?                             Current                                 { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static SingleAssignmentDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleAssignmentDisposable();

            value.Current                                   = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D8F80110 0x18 Current                     ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x020)); // 0270D8F80130 0x20 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
