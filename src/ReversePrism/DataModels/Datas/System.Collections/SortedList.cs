using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 keys                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 018 values                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 020 Size                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Comparer                                 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer
    // 030 KeyList                                  00018654C480 ModelClassType KeyList KeyList KeyList Pointer
    // 038 ValueList                                00018654D0C0 ModelClassType ValueList ValueList ValueList Pointer
    // 040 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    public partial class SortedList
    {
        public int                                      Size                                    { get; set; }
        public int                                      Version                                 { get; set; }
        public IComparer?                               Comparer                                { get; set; }
        public KeyList?                                 KeyList                                 { get; set; }
        public ValueList?                               ValueList                               { get; set; }

        public static SortedList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortedList();

            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D6D80120 0x20 Size                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x024)); // 0270D6D80140 0x24 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IComparer.FromPointer); // 0270D6D80160 0x28 Comparer                    ( 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer )
            value.KeyList                                   = GetObject<KeyList>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeyList.FromPointer); // 0270D6D80180 0x30 KeyList                     ( 00018654C480 ModelClassType KeyList KeyList KeyList Pointer )
            value.ValueList                                 = GetObject<ValueList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValueList.FromPointer); // 0270D6D801A0 0x38 ValueList                   ( 00018654D0C0 ModelClassType ValueList ValueList ValueList Pointer )

            return value;
        }
    }
}
