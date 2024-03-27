using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionRef                            000186773F00 ModelClassType VariantVariantMap VariantVariantMap VariantVariantMap Pointer
    // 018 keyCollection                            IList`1<Variant> IL2CPP_TYPE_GENERICINST
    // 020 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 currentObject                            <object> IL2CPP_TYPE_OBJECT
    // 030 CurrentSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class VariantVariantMapEnumerator
    {
        public VariantVariantMap?                       CollectionRef                           { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      CurrentSize                             { get; set; }

        public static VariantVariantMapEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VariantVariantMapEnumerator();

            value.CollectionRef                             = GetObject<VariantVariantMap>(new IntPtr(p + 0x010), ReversePrism.DataModels.VariantVariantMap.FromPointer); // 0270DB77D0D8 0x10 CollectionRef               ( 000186773F00 ModelClassType VariantVariantMap VariantVariantMap VariantVariantMap Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x020)); // 0270DB77D118 0x20 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x030)); // 0270DB77D158 0x30 CurrentSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
