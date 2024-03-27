using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InternalDelegate                         000186558810 ModelClassType InternalDelegate InternalDelegate InternalDelegate Pointer
    // 018 <callbackFunction>k__BackingField        <int> IL2CPP_TYPE_I
    // 020 <callbackPointer>k__BackingField         <int> IL2CPP_TYPE_I
    public partial class CriAudioWriteStream
    {
        public InternalDelegate?                        InternalDelegate                        { get; set; }

        public static CriAudioWriteStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAudioWriteStream();

            value.InternalDelegate                          = GetObject<InternalDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.InternalDelegate.FromPointer); // 0270DAC76B10 0x10 InternalDelegate            ( 000186558810 ModelClassType InternalDelegate InternalDelegate InternalDelegate Pointer )

            return value;
        }
    }
}
