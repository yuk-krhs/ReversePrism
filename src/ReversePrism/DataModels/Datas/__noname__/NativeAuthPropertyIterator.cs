using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AuthContext                              <int> IL2CPP_TYPE_I
    // 018 Index                                    <uint> IL2CPP_TYPE_U
    // 020 Name                                     <int> IL2CPP_TYPE_I
    public partial class NativeAuthPropertyIterator : DataModel
    {

        public static NativeAuthPropertyIterator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeAuthPropertyIterator() { Pointer= p0 };


            return value;
        }
    }
}
