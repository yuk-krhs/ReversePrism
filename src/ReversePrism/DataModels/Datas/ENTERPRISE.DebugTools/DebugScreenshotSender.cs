using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ImageBytes                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class DebugScreenshotSender
    {
        public List<sbyte>?                             ImageBytes                              { get; set; }

        public static DebugScreenshotSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugScreenshotSender();

            value.ImageBytes                                = GetSByteList(new IntPtr(p + 0x010)); // 0270DB6DFAF0 0x10 ImageBytes                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
