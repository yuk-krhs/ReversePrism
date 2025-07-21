using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LoadedCell                               ModelClassType UITableViewCell UITableViewCell UITableViewCell Pointer
    // 018 Scalar                                   ModelPrimitiveType float float float Single
    // 01C UpperMargin                              ModelPrimitiveType float float float Single
    // 020 LowerMargin                              ModelPrimitiveType float float float Single
    // 024 Position                                 ModelPrimitiveType float float float Single
    public partial class UITableViewCellHolder : DataModel
    {
        public UITableViewCell?                         LoadedCell                              { get; set; }
        public float                                    Scalar                                  { get; set; }
        public float                                    UpperMargin                             { get; set; }
        public float                                    LowerMargin                             { get; set; }
        public float                                    Position                                { get; set; }

        public static UITableViewCellHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITableViewCellHolder() { Pointer= p0 };

            value.LoadedCell                                = GetObject<UITableViewCell>(new IntPtr(p + 0x010), ReversePrism.DataModels.UITableViewCell.FromPointer); // 0x10 LoadedCell                  ( ModelClassType UITableViewCell UITableViewCell UITableViewCell Pointer )
            value.Scalar                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 Scalar                      ( ModelPrimitiveType float float float Single )
            value.UpperMargin                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C UpperMargin                 ( ModelPrimitiveType float float float Single )
            value.LowerMargin                               = GetSingle(new IntPtr(p + 0x020)); // 0x20 LowerMargin                 ( ModelPrimitiveType float float float Single )
            value.Position                                  = GetSingle(new IntPtr(p + 0x024)); // 0x24 Position                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
