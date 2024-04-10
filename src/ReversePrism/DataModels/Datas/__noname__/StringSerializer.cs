using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SerializedText                           000186672F10 ModelPrimitiveType string string string String
    // 018 CurrentTokenStartIndex                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C State                                    000186585C70 ModelEnumType State State State Int32
    public partial class StringSerializer : DataModel
    {
        public string                                   SerializedText                          { get; set; }
        public int                                      CurrentTokenStartIndex                  { get; set; }
        public State                                    State                                   { get; set; }

        public static StringSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringSerializer() { Pointer= p0 };

            value.SerializedText                            = GetString(new IntPtr(p + 0x010)); // 0246669D8DD0 0x10 SerializedText              ( 000186672F10 ModelPrimitiveType string string string String )
            value.CurrentTokenStartIndex                    = GetInt32(new IntPtr(p + 0x018)); // 0246669D8DF0 0x18 CurrentTokenStartIndex      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (State)GetInt32(new IntPtr(p + 0x01C)); // 0246669D8E10 0x1C State                       ( 000186585C70 ModelEnumType State State State Int32 )

            return value;
        }
    }
}
