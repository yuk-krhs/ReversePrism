using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018665CC80 ModelEnumType MtomBinaryDataType MtomBinaryDataType MtomBinaryDataType Int32
    // 018 Provider                                 000186661770 ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer
    // 020 Chunk                                    000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MtomBinaryData
    {
        public MtomBinaryDataType                       Type                                    { get; set; }
        public IStreamProvider?                         Provider                                { get; set; }
        public List<sbyte>?                             Chunk                                   { get; set; }

        public static MtomBinaryData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MtomBinaryData();

            value.Type                                      = (MtomBinaryDataType)GetInt32(new IntPtr(p + 0x010)); // 0270D7C986D8 0x10 Type                        ( 00018665CC80 ModelEnumType MtomBinaryDataType MtomBinaryDataType MtomBinaryDataType Int32 )
            value.Provider                                  = GetObject<IStreamProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStreamProvider.FromPointer); // 0270D7C986F8 0x18 Provider                    ( 000186661770 ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer )
            value.Chunk                                     = GetSByteList(new IntPtr(p + 0x020)); // 0270D7C98718 0x20 Chunk                       ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
