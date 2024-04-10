using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 sources                                  IList`1<IObservable`1<Unit>> IL2CPP_TYPE_GENERICINST
    // 028 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 030 CompletedCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class WhenAll_ : DataModel
    {
        public int                                      CompletedCount                          { get; set; }
        public int                                      Length                                  { get; set; }

        public static WhenAll_? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhenAll_() { Pointer= p0 };

            value.CompletedCount                            = GetInt32(new IntPtr(p + 0x030)); // 024669815410 0x30 CompletedCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x034)); // 024669815430 0x34 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
