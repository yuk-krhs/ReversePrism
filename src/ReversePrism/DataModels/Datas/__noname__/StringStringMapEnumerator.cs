using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionRef                            ModelClassType StringStringMap StringStringMap StringStringMap Pointer
    // 018 keyCollection                            IList`1<string> IL2CPP_TYPE_GENERICINST
    // 020 CurrentIndex                             ModelPrimitiveType int int int Int32
    // 028 currentObject                            <object> IL2CPP_TYPE_OBJECT
    // 030 CurrentSize                              ModelPrimitiveType int int int Int32
    public partial class StringStringMapEnumerator : DataModel
    {
        public StringStringMap?                         CollectionRef                           { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      CurrentSize                             { get; set; }

        public static StringStringMapEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringStringMapEnumerator() { Pointer= p0 };

            value.CollectionRef                             = GetObject<StringStringMap>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringStringMap.FromPointer); // 0x10 CollectionRef               ( ModelClassType StringStringMap StringStringMap StringStringMap Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentIndex                ( ModelPrimitiveType int int int Int32 )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentSize                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
