using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Float32                                  string IL2CPP_TYPE_STRING
    // 000 Float64                                  string IL2CPP_TYPE_STRING
    // 000 Int8                                     string IL2CPP_TYPE_STRING
    // 000 Int16                                    string IL2CPP_TYPE_STRING
    // 000 Int32                                    string IL2CPP_TYPE_STRING
    // 000 Int64                                    string IL2CPP_TYPE_STRING
    // 000 UInt8                                    string IL2CPP_TYPE_STRING
    // 000 UInt16                                   string IL2CPP_TYPE_STRING
    // 000 UInt32                                   string IL2CPP_TYPE_STRING
    // 000 UInt64                                   string IL2CPP_TYPE_STRING
    // 000 String                                   string IL2CPP_TYPE_STRING
    // 000 Image                                    string IL2CPP_TYPE_STRING
    // 000 Video                                    string IL2CPP_TYPE_STRING
    // 000 Audio                                    string IL2CPP_TYPE_STRING
    // 000 Binary                                   string IL2CPP_TYPE_STRING
    public partial class DataType : DataModel
    {

        public static DataType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataType() { Pointer= p0 };


            return value;
        }
    }
}
