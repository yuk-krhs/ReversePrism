using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataView                                 ModelClassType DataView DataView DataView Pointer
    // 018 Row                                      ModelClassType DataRow DataRow DataRow Pointer
    // 020 DelayBeginEdit                           ModelPrimitiveType bool bool bool Bool
    // 000 s_zeroPropertyDescriptorCollection       PropertyDescriptorCollection IL2CPP_TYPE_CLASS
    // 028 PropertyChanged                          ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    public partial class DataRowView : DataModel
    {
        public DataView?                                DataView                                { get; set; }
        public DataRow?                                 Row                                     { get; set; }
        public bool                                     DelayBeginEdit                          { get; set; }
        public PropertyChangedEventHandler?             PropertyChanged                         { get; set; }

        public static DataRowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRowView() { Pointer= p0 };

            value.DataView                                  = GetObject<DataView>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataView.FromPointer); // 0x10 DataView                    ( ModelClassType DataView DataView DataView Pointer )
            value.Row                                       = GetObject<DataRow>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataRow.FromPointer); // 0x18 Row                         ( ModelClassType DataRow DataRow DataRow Pointer )
            value.DelayBeginEdit                            = GetBool(new IntPtr(p + 0x020)); // 0x20 DelayBeginEdit              ( ModelPrimitiveType bool bool bool Bool )
            value.PropertyChanged                           = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0x28 PropertyChanged             ( ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
