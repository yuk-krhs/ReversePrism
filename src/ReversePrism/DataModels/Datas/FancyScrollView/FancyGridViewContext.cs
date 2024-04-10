using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FancyScrollView.IFancyScrollRectContext.ScrollDirection 0001866F7950 ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32
    // 018 <FancyScrollView.IFancyScrollRectContext.CalculateScrollSize>k__BackingField Func`1<ValueTuple`2<float, float>> IL2CPP_TYPE_GENERICINST
    // 020 FancyScrollView.IFancyCellGroupContext.CellTemplate 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 <FancyScrollView.IFancyCellGroupContext.GetGroupCount>k__BackingField Func`1<int> IL2CPP_TYPE_GENERICINST
    // 030 <FancyScrollView.IFancyGridViewContext.GetStartAxisSpacing>k__BackingField Func`1<float> IL2CPP_TYPE_GENERICINST
    // 038 <FancyScrollView.IFancyGridViewContext.GetCellSize>k__BackingField Func`1<float> IL2CPP_TYPE_GENERICINST
    public partial class FancyGridViewContext : DataModel
    {
        public ScrollDirection                          FancyScrollView.IFancyScrollRectContext.ScrollDirection { get; set; }
        public GameObject?                              FancyScrollView.IFancyCellGroupContext.CellTemplate { get; set; }

        public static FancyGridViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FancyGridViewContext() { Pointer= p0 };

            value.FancyScrollView.IFancyScrollRectContext.ScrollDirection = (ScrollDirection)GetInt32(new IntPtr(p + 0x010)); // 024664CCCF50 0x10 FancyScrollView.IFancyScrollRectContext.ScrollDirection ( 0001866F7950 ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32 )
            value.FancyScrollView.IFancyCellGroupContext.CellTemplate = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024664CCCF90 0x20 FancyScrollView.IFancyCellGroupContext.CellTemplate ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
