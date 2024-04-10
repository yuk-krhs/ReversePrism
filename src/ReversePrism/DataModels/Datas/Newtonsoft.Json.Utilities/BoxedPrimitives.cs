using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BooleanTrue                              <object> IL2CPP_TYPE_OBJECT
    // 008 BooleanFalse                             <object> IL2CPP_TYPE_OBJECT
    // 010 Int32_M1                                 <object> IL2CPP_TYPE_OBJECT
    // 018 Int32_0                                  <object> IL2CPP_TYPE_OBJECT
    // 020 Int32_1                                  <object> IL2CPP_TYPE_OBJECT
    // 028 Int32_2                                  <object> IL2CPP_TYPE_OBJECT
    // 030 Int32_3                                  <object> IL2CPP_TYPE_OBJECT
    // 038 Int32_4                                  <object> IL2CPP_TYPE_OBJECT
    // 040 Int32_5                                  <object> IL2CPP_TYPE_OBJECT
    // 048 Int32_6                                  <object> IL2CPP_TYPE_OBJECT
    // 050 Int32_7                                  <object> IL2CPP_TYPE_OBJECT
    // 058 Int32_8                                  <object> IL2CPP_TYPE_OBJECT
    // 060 Int64_M1                                 <object> IL2CPP_TYPE_OBJECT
    // 068 Int64_0                                  <object> IL2CPP_TYPE_OBJECT
    // 070 Int64_1                                  <object> IL2CPP_TYPE_OBJECT
    // 078 Int64_2                                  <object> IL2CPP_TYPE_OBJECT
    // 080 Int64_3                                  <object> IL2CPP_TYPE_OBJECT
    // 088 Int64_4                                  <object> IL2CPP_TYPE_OBJECT
    // 090 Int64_5                                  <object> IL2CPP_TYPE_OBJECT
    // 098 Int64_6                                  <object> IL2CPP_TYPE_OBJECT
    // 0A0 Int64_7                                  <object> IL2CPP_TYPE_OBJECT
    // 0A8 Int64_8                                  <object> IL2CPP_TYPE_OBJECT
    // 0B0 DecimalZero                              <object> IL2CPP_TYPE_OBJECT
    // 0B8 DoubleNaN                                <object> IL2CPP_TYPE_OBJECT
    // 0C0 DoublePositiveInfinity                   <object> IL2CPP_TYPE_OBJECT
    // 0C8 DoubleNegativeInfinity                   <object> IL2CPP_TYPE_OBJECT
    // 0D0 DoubleZero                               <object> IL2CPP_TYPE_OBJECT
    public partial class BoxedPrimitives : DataModel
    {

        public static BoxedPrimitives? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoxedPrimitives() { Pointer= p0 };


            return value;
        }
    }
}
