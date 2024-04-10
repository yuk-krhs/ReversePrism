using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 InvokeButton                             0001865140C0 ModelClassType Button Button Button Pointer
    // 088 BoundMethod                              000186529440 ModelEnumType ExposedMethod ExposedMethod ExposedMethod Int32
    public partial class ExposedMethodField : DataModel
    {
        public Button?                                  InvokeButton                            { get; set; }
        public ExposedMethod                            BoundMethod                             { get; set; }

        public static ExposedMethodField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExposedMethodField() { Pointer= p0 };

            value.InvokeButton                              = GetObject<Button>(new IntPtr(p + 0x080), ReversePrism.DataModels.Button.FromPointer); // 02466B240D68 0x80 InvokeButton                ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.BoundMethod                               = (ExposedMethod)GetInt32(new IntPtr(p + 0x088)); // 02466B240D88 0x88 BoundMethod                 ( 000186529440 ModelEnumType ExposedMethod ExposedMethod ExposedMethod Int32 )

            return value;
        }
    }
}
