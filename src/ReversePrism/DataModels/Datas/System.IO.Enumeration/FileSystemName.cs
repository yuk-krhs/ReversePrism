using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_wildcardChars                          char[] IL2CPP_TYPE_SZARRAY
    // 008 s_simpleWildcardChars                    char[] IL2CPP_TYPE_SZARRAY
    public partial class FileSystemName : DataModel
    {

        public static FileSystemName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileSystemName() { Pointer= p0 };


            return value;
        }
    }
}
