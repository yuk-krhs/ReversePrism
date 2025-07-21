using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DwSize                                   ModelPrimitiveType uint uint uint UInt32
    // 014 DwCopyFlags                              ModelPrimitiveType uint uint uint UInt32
    // 018 pfCancel                                 <int> IL2CPP_TYPE_I
    // 020 pProgressRoutine                         <int> IL2CPP_TYPE_I
    // 028 pvCallbackContext                        <int> IL2CPP_TYPE_I
    public partial class COPYFILE2_EXTENDED_PARAMETERS : DataModel
    {
        public uint                                     DwSize                                  { get; set; }
        public uint                                     DwCopyFlags                             { get; set; }

        public static COPYFILE2_EXTENDED_PARAMETERS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new COPYFILE2_EXTENDED_PARAMETERS() { Pointer= p0 };

            value.DwSize                                    = GetUInt32(new IntPtr(p + 0x010)); // 0x10 DwSize                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.DwCopyFlags                               = GetUInt32(new IntPtr(p + 0x014)); // 0x14 DwCopyFlags                 ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
