using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 ReuseIdentifier                          000186671910 ModelPrimitiveType string string string String
    // 030 IsAutoResize                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 LifeCycle                                0001866F7BD0 ModelEnumType UITableViewCellLifeCycle UITableViewCellLifeCycle UITableViewCellLifeCycle Int32
    // 038 <index>k__BackingField                   Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class UITableViewCell
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
            var value   = new UITableViewCell();

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 027002D432A0 0x20 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ReuseIdentifier                           = GetString(new IntPtr(p + 0x028)); // 027002D432C0 0x28 ReuseIdentifier             ( 000186671910 ModelPrimitiveType string string string String )
            value.IsAutoResize                              = GetBool(new IntPtr(p + 0x030)); // 027002D432E0 0x30 IsAutoResize                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LifeCycle                                 = (UITableViewCellLifeCycle)GetInt32(new IntPtr(p + 0x034)); // 027002D43300 0x34 LifeCycle                   ( 0001866F7BD0 ModelEnumType UITableViewCellLifeCycle UITableViewCellLifeCycle UITableViewCellLifeCycle Int32 )

            return value;
        }
    }
}
