using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionRef                            0001865C0D50 ModelClassType StringList StringList StringList Pointer
    // 018 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 currentObject                            <object> IL2CPP_TYPE_OBJECT
    // 028 CurrentSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StringListEnumerator
    {
        public StringList?                              CollectionRef                           { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      CurrentSize                             { get; set; }

        public static StringListEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringListEnumerator();

            value.CollectionRef                             = GetObject<StringList>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringList.FromPointer); // 0270DB749010 0x10 CollectionRef               ( 0001865C0D50 ModelClassType StringList StringList StringList Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x018)); // 0270DB749030 0x18 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x028)); // 0270DB749070 0x28 CurrentSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
