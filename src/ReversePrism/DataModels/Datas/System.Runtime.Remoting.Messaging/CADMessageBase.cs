using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _args                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 018 SerializedArgs                           000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 PropertyCount                            0001865F3220 ModelPrimitiveType int int int Int32
    // 028 CallContext                              00018651E500 ModelClassType CADArgHolder CADArgHolder CADArgHolder Pointer
    // 030 SerializedMethod                         000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class CADMessageBase : DataModel
    {
        public List<sbyte>?                             SerializedArgs                          { get; set; }
        public int                                      PropertyCount                           { get; set; }
        public CADArgHolder?                            CallContext                             { get; set; }
        public List<sbyte>?                             SerializedMethod                        { get; set; }

        public static CADMessageBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CADMessageBase() { Pointer= p0 };

            value.SerializedArgs                            = GetSByteList(new IntPtr(p + 0x018)); // 024666AC4580 0x18 SerializedArgs              ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.PropertyCount                             = GetInt32(new IntPtr(p + 0x020)); // 024666AC45A0 0x20 PropertyCount               ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.CallContext                               = GetObject<CADArgHolder>(new IntPtr(p + 0x028), ReversePrism.DataModels.CADArgHolder.FromPointer); // 024666AC45C0 0x28 CallContext                 ( 00018651E500 ModelClassType CADArgHolder CADArgHolder CADArgHolder Pointer )
            value.SerializedMethod                          = GetSByteList(new IntPtr(p + 0x030)); // 024666AC45E0 0x30 SerializedMethod            ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
