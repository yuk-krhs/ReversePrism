using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InternalDelegate                         000186557B60 ModelClassType InternalDelegate InternalDelegate InternalDelegate Pointer
    // 018 <callbackFunction>k__BackingField        <int> IL2CPP_TYPE_I
    // 020 <callbackPointer>k__BackingField         <int> IL2CPP_TYPE_I
    public partial class CriAudioReadStream : DataModel
    {
        public InternalDelegate?                        InternalDelegate                        { get; set; }

        public static CriAudioReadStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAudioReadStream() { Pointer= p0 };

            value.InternalDelegate                          = GetObject<InternalDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.InternalDelegate.FromPointer); // 02466ACDC0C8 0x10 InternalDelegate            ( 000186557B60 ModelClassType InternalDelegate InternalDelegate InternalDelegate Pointer )

            return value;
        }
    }
}
