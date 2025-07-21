using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 ReuseIdentifier                          ModelPrimitiveType string string string String
    // 030 IsAutoResize                             ModelPrimitiveType bool bool bool Bool
    // 034 LifeCycle                                ModelEnumType UITableViewCellLifeCycle UITableViewCellLifeCycle UITableViewCellLifeCycle Int32
    // 038 <index>k__BackingField                   Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class UITableViewCell : DataModel
    {
        public RectTransform?                           RectTransform                           { get; set; }
        public string                                   ReuseIdentifier                         { get; set; }
        public bool                                     IsAutoResize                            { get; set; }
        public UITableViewCellLifeCycle                 LifeCycle                               { get; set; }

        public static UITableViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITableViewCell() { Pointer= p0 };

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ReuseIdentifier                           = GetString(new IntPtr(p + 0x028)); // 0x28 ReuseIdentifier             ( ModelPrimitiveType string string string String )
            value.IsAutoResize                              = GetBool(new IntPtr(p + 0x030)); // 0x30 IsAutoResize                ( ModelPrimitiveType bool bool bool Bool )
            value.LifeCycle                                 = (UITableViewCellLifeCycle)GetInt32(new IntPtr(p + 0x034)); // 0x34 LifeCycle                   ( ModelEnumType UITableViewCellLifeCycle UITableViewCellLifeCycle UITableViewCellLifeCycle Int32 )

            return value;
        }
    }
}
