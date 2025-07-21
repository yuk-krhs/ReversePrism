using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 TopLevel                                 ModelClassType GUILayoutGroup GUILayoutGroup GUILayoutGroup Pointer
    // 020 LayoutGroups                             ModelClassType GenericStack GenericStack GenericStack Pointer
    // 028 Windows                                  ModelClassType GUILayoutGroup GUILayoutGroup GUILayoutGroup Pointer
    public partial class LayoutCache : DataModel
    {
        public int                                      Id                                      { get; set; }
        public GUILayoutGroup?                          TopLevel                                { get; set; }
        public GenericStack?                            LayoutGroups                            { get; set; }
        public GUILayoutGroup?                          Windows                                 { get; set; }

        public static LayoutCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutCache() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.TopLevel                                  = GetObject<GUILayoutGroup>(new IntPtr(p + 0x018), ReversePrism.DataModels.GUILayoutGroup.FromPointer); // 0x18 TopLevel                    ( ModelClassType GUILayoutGroup GUILayoutGroup GUILayoutGroup Pointer )
            value.LayoutGroups                              = GetObject<GenericStack>(new IntPtr(p + 0x020), ReversePrism.DataModels.GenericStack.FromPointer); // 0x20 LayoutGroups                ( ModelClassType GenericStack GenericStack GenericStack Pointer )
            value.Windows                                   = GetObject<GUILayoutGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.GUILayoutGroup.FromPointer); // 0x28 Windows                     ( ModelClassType GUILayoutGroup GUILayoutGroup GUILayoutGroup Pointer )

            return value;
        }
    }
}
