using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 018 Current                                  ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class SerialDisposable : DataModel
    {
        public IDisposable?                             Current                                 { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static SerialDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerialDisposable() { Pointer= p0 };

            value.Current                                   = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Current                     ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
