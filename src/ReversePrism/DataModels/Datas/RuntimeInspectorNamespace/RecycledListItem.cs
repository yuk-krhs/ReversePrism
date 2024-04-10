using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 <Tag>k__BackingField                     <object> IL2CPP_TYPE_OBJECT
    // 028 Position                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Adapter                                  0001865929A0 ModelClassType IListViewAdapter IListViewAdapter IListViewAdapter Pointer
    public partial class RecycledListItem : DataModel
    {
        public int                                      Position                                { get; set; }
        public IListViewAdapter?                        Adapter                                 { get; set; }

        public static RecycledListItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecycledListItem() { Pointer= p0 };

            value.Position                                  = GetInt32(new IntPtr(p + 0x028)); // 02466B1E4400 0x28 Position                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Adapter                                   = GetObject<IListViewAdapter>(new IntPtr(p + 0x030), ReversePrism.DataModels.IListViewAdapter.FromPointer); // 02466B1E4420 0x30 Adapter                     ( 0001865929A0 ModelClassType IListViewAdapter IListViewAdapter IListViewAdapter Pointer )

            return value;
        }
    }
}
