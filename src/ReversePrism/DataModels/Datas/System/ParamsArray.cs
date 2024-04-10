using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_oneArgArray                            <object>[] IL2CPP_TYPE_SZARRAY
    // 008 s_twoArgArray                            <object>[] IL2CPP_TYPE_SZARRAY
    // 010 s_threeArgArray                          <object>[] IL2CPP_TYPE_SZARRAY
    // 010 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    // 018 _arg1                                    <object> IL2CPP_TYPE_OBJECT
    // 020 _arg2                                    <object> IL2CPP_TYPE_OBJECT
    // 028 _args                                    <object>[] IL2CPP_TYPE_SZARRAY
    public partial class ParamsArray : DataModel
    {

        public static ParamsArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParamsArray() { Pointer= p0 };


            return value;
        }
    }
}
