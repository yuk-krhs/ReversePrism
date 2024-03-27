using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0B8 _parentKey                               Nullable`1<DataKey> IL2CPP_TYPE_GENERICINST
    // 0C8 ChildKey                                 00018667B160 ModelEnumType DataKey DataKey DataKey Int32
    // 0D0 ParentRowView                            0001866802C0 ModelClassType DataRowView DataRowView DataRowView Pointer
    // 0D8 _filterValues                            <object>[] IL2CPP_TYPE_SZARRAY
    public partial class RelatedView
    {
        public DataKey                                  ChildKey                                { get; set; }
        public DataRowView?                             ParentRowView                           { get; set; }

        public static RelatedView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RelatedView();

            value.ChildKey                                  = (DataKey)GetInt32(new IntPtr(p + 0x0C8)); // 0270D894DDF8 0xC8 ChildKey                    ( 00018667B160 ModelEnumType DataKey DataKey DataKey Int32 )
            value.ParentRowView                             = GetObject<DataRowView>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.DataRowView.FromPointer); // 0270D894DE18 0xD0 ParentRowView               ( 0001866802C0 ModelClassType DataRowView DataRowView DataRowView Pointer )

            return value;
        }
    }
}
