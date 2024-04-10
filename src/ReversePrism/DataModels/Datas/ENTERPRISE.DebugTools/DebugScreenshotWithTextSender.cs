using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextBytes                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 ImageBytes                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class DebugScreenshotWithTextSender : DataModel
    {
        public List<sbyte>?                             TextBytes                               { get; set; }
        public List<sbyte>?                             ImageBytes                              { get; set; }

        public static DebugScreenshotWithTextSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugScreenshotWithTextSender() { Pointer= p0 };

            value.TextBytes                                 = GetSByteList(new IntPtr(p + 0x010)); // 02466B76C618 0x10 TextBytes                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ImageBytes                                = GetSByteList(new IntPtr(p + 0x018)); // 02466B76C638 0x18 ImageBytes                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
