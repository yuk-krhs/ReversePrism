using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _args                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 018 SerializedArgs                           ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 PropertyCount                            ModelPrimitiveType int int int Int32
    // 028 CallContext                              ModelClassType CADArgHolder CADArgHolder CADArgHolder Pointer
    // 030 SerializedMethod                         ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
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

            value.SerializedArgs                            = GetSByteList(new IntPtr(p + 0x018)); // 0x18 SerializedArgs              ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.PropertyCount                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 PropertyCount               ( ModelPrimitiveType int int int Int32 )
            value.CallContext                               = GetObject<CADArgHolder>(new IntPtr(p + 0x028), ReversePrism.DataModels.CADArgHolder.FromPointer); // 0x28 CallContext                 ( ModelClassType CADArgHolder CADArgHolder CADArgHolder Pointer )
            value.SerializedMethod                          = GetSByteList(new IntPtr(p + 0x030)); // 0x30 SerializedMethod            ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
