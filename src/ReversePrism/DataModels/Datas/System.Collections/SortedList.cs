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
    // 020 Size                                     ModelPrimitiveType int int int Int32
    // 024 Version                                  ModelPrimitiveType int int int Int32
    // 028 Comparer                                 ModelClassType IComparer IComparer IComparer Pointer
    // 030 KeyList                                  ModelClassType KeyList KeyList KeyList Pointer
    // 038 ValueList                                ModelClassType ValueList ValueList ValueList Pointer
    // 040 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    public partial class SortedList : DataModel
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
            var value   = new SortedList() { Pointer= p0 };

            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Size                        ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 Version                     ( ModelPrimitiveType int int int Int32 )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IComparer.FromPointer); // 0x28 Comparer                    ( ModelClassType IComparer IComparer IComparer Pointer )
            value.KeyList                                   = GetObject<KeyList>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeyList.FromPointer); // 0x30 KeyList                     ( ModelClassType KeyList KeyList KeyList Pointer )
            value.ValueList                                 = GetObject<ValueList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValueList.FromPointer); // 0x38 ValueList                   ( ModelClassType ValueList ValueList ValueList Pointer )

            return value;
        }
    }
}
