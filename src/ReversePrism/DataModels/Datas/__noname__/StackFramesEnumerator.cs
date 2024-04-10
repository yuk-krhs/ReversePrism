using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionRef                            00018655F9C0 ModelClassType StackFrames StackFrames StackFrames Pointer
    // 018 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 currentObject                            <object> IL2CPP_TYPE_OBJECT
    // 028 CurrentSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StackFramesEnumerator : DataModel
    {
        public StackFrames?                             CollectionRef                           { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      CurrentSize                             { get; set; }

        public static StackFramesEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackFramesEnumerator() { Pointer= p0 };

            value.CollectionRef                             = GetObject<StackFrames>(new IntPtr(p + 0x010), ReversePrism.DataModels.StackFrames.FromPointer); // 02466BCE36C8 0x10 CollectionRef               ( 00018655F9C0 ModelClassType StackFrames StackFrames StackFrames Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x018)); // 02466BCE36E8 0x18 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x028)); // 02466BCE3728 0x28 CurrentSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
