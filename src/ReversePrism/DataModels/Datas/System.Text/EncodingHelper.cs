using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 utf8EncodingWithoutMarkers               Encoding IL2CPP_TYPE_CLASS
    // 008 lockobj                                  <object> IL2CPP_TYPE_OBJECT
    // 010 I18nAssembly                             00018658B940 ModelClassType Assembly Assembly Assembly Pointer
    // 018 I18nDisabled                             000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class EncodingHelper
    {
        public Assembly?                                I18nAssembly                            { get; set; }
        public bool                                     I18nDisabled                            { get; set; }

        public static EncodingHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncodingHelper();

            value.I18nAssembly                              = GetObject<Assembly>(new IntPtr(p + 0x010), ReversePrism.DataModels.Assembly.FromPointer); // 0270D0FCFAE8 0x10 I18nAssembly                ( 00018658B940 ModelClassType Assembly Assembly Assembly Pointer )
            value.I18nDisabled                              = GetBool(new IntPtr(p + 0x018)); // 0270D0FCFB08 0x18 I18nDisabled                ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
