using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 Column                                   000186675EC0 ModelClassType DataColumn DataColumn DataColumn Pointer
    public partial class DataColumnPropertyDescriptor
    {
        public DataColumn?                              Column                                  { get; set; }

        public static DataColumnPropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataColumnPropertyDescriptor();

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x088), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D88BD678 0x88 Column                      ( 000186675EC0 ModelClassType DataColumn DataColumn DataColumn Pointer )

            return value;
        }
    }
}
