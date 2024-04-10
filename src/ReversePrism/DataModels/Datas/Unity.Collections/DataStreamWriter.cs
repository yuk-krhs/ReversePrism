using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Data                                   00018657A070 ModelEnumType StreamData StreamData StreamData Int32
    // 030 m_SendHandleData                         <int> IL2CPP_TYPE_I
    public partial class DataStreamWriter : DataModel
    {
        public StreamData                               M_Data                                  { get; set; }

        public static DataStreamWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataStreamWriter() { Pointer= p0 };

            value.M_Data                                    = (StreamData)GetInt32(new IntPtr(p + 0x010)); // 0245A51751D0 0x10 M_Data                      ( 00018657A070 ModelEnumType StreamData StreamData StreamData Int32 )

            return value;
        }
    }
}
